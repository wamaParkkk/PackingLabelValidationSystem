using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Speech.Synthesis;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.Media;

namespace PackingLabelValidationSystem
{
    public partial class MainForm : Form
    {
        string pptFilePath;
        string voiceRecipePath;
        string soundFilePath;
        static string logfilePath;

        VoiceMessageForm voiceMessageForm;

        string strAmkorID;
        string strSubID;
        string strCustomerCode;
        string strCustomerName;
        string strPakage;
        string strDimension;
        string strLead;
        string strNickName;
        string strTestChgInWIP;

        string strVoiceTrayCnt;
        string strVoiceCoverTrayCnt;
        string strVoiceDesiccantCnt;
        string strVoiceHICCnt;

        private SoundPlayer soundPlayer = null;

        string strVoiceValue = string.Empty;
        SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();

        private Timer wavPlayTimer = new Timer();
        private Timer voiceTimer = new Timer();

        int iWavPlayInterval;        

        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Width = 740;
            Height = 1024;
            Left = 0;
            Top = 0;

            _pptFilePath_Load();
            _voiceRecipeFilePath_Load();
            _logFilePath_Load();

            wavPlayTimer.Interval = 1000;
            wavPlayTimer.Elapsed += new ElapsedEventHandler(_wavPlay_loop);

            voiceTimer.Interval = 1000;
            voiceTimer.Elapsed += new ElapsedEventHandler(_Voice_loop);           
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            textBox_AlTag.Focus();
        }

        private void _pptFilePath_Load()
        {
            try
            {
                string sFileName = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\PPTFilePath.txt"));                

                if (File.Exists(string.Format("{0}", sFileName)))
                {
                    string[] lines = File.ReadAllLines(sFileName, Encoding.UTF8);
                    pptFilePath = lines[0].ToString();                    
                }
                else
                {
                    MessageBox.Show("PPT path file does not exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _voiceRecipeFilePath_Load()
        {
            try
            {
                string sFileName = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\VoiceRecipeFilePath.txt"));

                if (File.Exists(string.Format("{0}", sFileName)))
                {
                    string[] lines = File.ReadAllLines(sFileName, Encoding.UTF8);
                    voiceRecipePath = lines[0].ToString();
                    soundFilePath = lines[2].ToString();
                }
                else
                {
                    MessageBox.Show("Voice recipe path file does not exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void _logFilePath_Load()
        {
            try
            {
                string sFileName = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\LogFilePath.txt"));

                if (File.Exists(string.Format("{0}", sFileName)))
                {
                    string[] lines = File.ReadAllLines(sFileName, Encoding.UTF8);
                    logfilePath = lines[0].ToString();
                }
                else
                {
                    MessageBox.Show("Log path file does not exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하겠습니까?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Dispose();
                //Application.Exit();
                System.Windows.Forms.Application.ExitThread();
                Environment.Exit(0);
            }
        }

        private void textBox_LotNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 음성 송출 중지
                //_Voice_stop();

                // 바코드 데이터 파싱
                _BARCODE_DATA_PARSING();
            }
        }

        private void _BARCODE_DATA_PARSING()
        {
            try
            {
                string strLotNo = string.Empty;                

                if ((textBox_AlTag.Text != "") && (textBox_AlTag.Text != null))
                {
                    strLotNo = textBox_AlTag.Text;

                    // 16진수로 변환
                    string rtnLotNo = _ByteToString(strLotNo);

                    // Web service 호출
                    _Web_Service_Call(rtnLotNo);

                    EventLog(string.Format("[{0}]\n{1} / {2} / {3} / {4} / {5} / {6} / {7}\n", strLotNo, 
                        strCustomerCode, 
                        strCustomerName, 
                        strPakage, 
                        strDimension, 
                        strLead, 
                        strTestChgInWIP, 
                        strNickName), "PM1", "Event");

                    // ppt file open
                    _PPT_File_Open();
                    
                    // Al tag box init
                    textBox_AlTag.Text = string.Empty;
                    textBox_AlTag.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string _ByteToString(string _strData)
        {
            string rtnVal = string.Empty;
            try
            {
                var sb = new StringBuilder();
                byte[] bytes = Encoding.UTF8.GetBytes(_strData);
                foreach (var t in bytes)
                {
                    sb.Append(t.ToString("X2"));
                }
                rtnVal = sb.ToString();
                return rtnVal;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return rtnVal;
            }            
        }

        private void _Web_Service_Call(string _strData)
        {
            try
            {
                strAmkorID = string.Empty;
                strSubID = string.Empty;
                strCustomerCode = string.Empty;
                strCustomerName = string.Empty;
                strPakage = string.Empty;
                strDimension = string.Empty;
                strLead = string.Empty;
                strNickName = string.Empty;
                strTestChgInWIP = string.Empty;

                string strServerAllData = string.Empty;

                // Create a request for the URL.            
                WebRequest request = WebRequest.Create(
                    "http://cim_service.amkor.co.kr:8080/ysj/lot_info/get_lot_info_by_al_tag/" + _strData);

                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;

                // Get the response.
                WebResponse response = request.GetResponse();

                // Display the status.
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream containing content returned by the server.
                // The using block ensures the stream is automatically closed.
                using (Stream dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    strServerAllData = responseFromServer;
                }

                // Close the response.
                response.Close();


                string[] phrase = strServerAllData.Split('\n'); // LF로 구분
                string[] words = phrase[1].Split('\t');         // tab으로 구분

                strAmkorID = words[2];                  // Amkor ID
                strSubID = words[3];                    // Sub ID
                textBox_LotNo.Text = words[4];          // Lot_No
                textBox_CustomerCode.Text = words[9];   // Customer_Code
                textBox_CustomerName.Text = words[10];  // Cust_Name
                textBox_Pakage.Text = words[11];        // Package
                textBox_Dimension.Text = words[12];     // Dimension
                textBox_Lead.Text = words[13];          // Lead
                textBox_TargetDevice.Text = words[34];  // Target_Device
                strTestChgInWIP = words[48];            // Test_chg_in_WIP 

                strCustomerCode = textBox_CustomerCode.Text;
                strCustomerName = textBox_CustomerName.Text;
                strPakage = textBox_Pakage.Text;
                strDimension = textBox_Dimension.Text;
                strLead = textBox_Lead.Text;

                // NickName 조회
                strNickName = _Web_NickName_Call(strAmkorID, strSubID);                
            }
            catch( Exception ex ) 
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private string _Web_NickName_Call(string sAmkorID, string sSubID)
        {
            string strServerAllData = string.Empty;

            // Create a request for the URL.            
            WebRequest request = WebRequest.Create(
                "http://10.101.14.130:8180/eMES_Webservice/lot_info_list/rmi_get_test_nickname/" + string.Format("{0},{1}", sAmkorID, sSubID));

            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();

            // Display the status.
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                strServerAllData = responseFromServer;
            }

            // Close the response.
            response.Close();

            return strServerAllData;
        }

        private void _PPT_File_Open()
        {
            try
            {
                ProcessFindAndKill();

                Microsoft.Office.Interop.PowerPoint.Application objApp = new Microsoft.Office.Interop.PowerPoint.Application();
                var objPresSet = objApp.Presentations;

                // Conversion Customer name
                string strConvCustomerName = _conv_CustomerName(strCustomerName);
                var objPres = objPresSet.Open(pptFilePath + 
                    string.Format("{0};{1};{2}{3}{4};{5};{6};.ppt", 
                    strCustomerCode, 
                    strConvCustomerName, 
                    strPakage, 
                    strDimension, 
                    strLead, 
                    strTestChgInWIP, 
                    strNickName),                    
                    MsoTriState.msoTrue, MsoTriState.msoTrue, MsoTriState.msoFalse); 
                var objSlides = objPres.Slides;                

                // Run the Slide show
                var objSSS = objPres.SlideShowSettings;
                objSSS.ShowType = PpSlideShowType.ppShowTypeWindow;
                //objSSS.LoopUntilStopped = MsoTriState.msoTrue;
                objSSS.Run();
                
                objPres.SlideShowWindow.Height = 775;
                objPres.SlideShowWindow.Width = 600;
                objPres.SlideShowWindow.Top = 0;
                objPres.SlideShowWindow.Left = 560;

                // 음성 송출
                /*
                _Text_to_Speech(string.Format("{0}{1}{2}{3}{4}", 
                    strCustomerCode, strConvCustomerName, strPakage, strDimension, strLead));
                */

                _Voice_File_Parsing(string.Format("{0};{1};{2}{3}{4};{5};{6};",
                    strCustomerCode, strConvCustomerName, strPakage, strDimension, strLead, strTestChgInWIP, strNickName));

                iWavPlayInterval = 1;                
                _Voice_Play();

            }
            catch ( Exception ex ) 
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }

        private void ProcessFindAndKill()
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.StartsWith("POWERPNT"))
                {
                    process.Kill();                                       
                }
            }
        }

        private string _conv_CustomerName(string strName)
        {
            string rtnVal = string.Empty;

            if (strName == "")
            {
                return strName;
            }

            if (strName.Contains(" "))
            {
                string[] phrase = strName.Split(' ');
                rtnVal = string.Format("{0}{1}{2}", phrase[0], "-", phrase[1]);                
                return rtnVal;
            }
            else
            {
                return strName;
            }           
        }

        #region Wav파일 Play
        private void _Voice_File_Parsing(string sFileName)
        {           
            try
            {
                strVoiceTrayCnt = string.Empty;
                strVoiceCoverTrayCnt = string.Empty;
                strVoiceDesiccantCnt = string.Empty;
                strVoiceHICCnt = string.Empty;

                string RecipePath = voiceRecipePath;
                RecipePath += sFileName + ".txt";                

                if (File.Exists(string.Format("{0}", RecipePath)))
                {
                    string[] lines = File.ReadAllLines(RecipePath, Encoding.UTF8);

                    strVoiceTrayCnt = lines[0].ToString();
                    strVoiceCoverTrayCnt = lines[1].ToString();
                    strVoiceDesiccantCnt = lines[2].ToString();
                    strVoiceHICCnt = lines[3].ToString();

                    textBoxTrayMsg.Text = strVoiceTrayCnt;
                    textBoxCoverTrayMsg.Text = strVoiceCoverTrayCnt;
                    textBoxDesiccantMsg.Text = strVoiceDesiccantCnt;
                    textBoxHICMsg.Text = strVoiceHICCnt;
                }
                else
                {
                    MessageBox.Show("Voice recipe file does not exist", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (IOException)
            {

            }
        }

        private void _Voice_Play()
        {
            wavPlayTimer.Enabled = true;            
        }

        private void _wavPlay_loop(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (iWavPlayInterval == 2)
                {
                    PlayWaveFile(string.Format("{0}{1}.wav", soundFilePath, strVoiceTrayCnt), false);                    
                }
                    
                if (File.Exists(string.Format("{0}{1}.wav", soundFilePath, strVoiceCoverTrayCnt)))
                {
                    if (iWavPlayInterval == 5)
                    {
                        PlayWaveFile(string.Format("{0}{1}.wav", soundFilePath, strVoiceCoverTrayCnt), false);                        
                    }                        
                }                
                
                if (File.Exists(string.Format("{0}{1}.wav", soundFilePath, strVoiceDesiccantCnt)))
                {
                    if (iWavPlayInterval == 8)
                    {
                        PlayWaveFile(string.Format("{0}{1}.wav", soundFilePath, strVoiceDesiccantCnt), false);                        
                    }                        
                }                                

                if (File.Exists(string.Format("{0}{1}.wav", soundFilePath, strVoiceHICCnt)))
                {
                    if (iWavPlayInterval == 11)
                    {
                        PlayWaveFile(string.Format("{0}{1}.wav", soundFilePath, strVoiceHICCnt), false);                        
                    }                        
                }                
                
                if (iWavPlayInterval >= 11)
                    iWavPlayInterval = 0;
                else
                    iWavPlayInterval++;                
            }
            catch
            {
            }
        }

        private void PlayWaveFile(string filePath, bool playLooping)
        {
            if (soundPlayer != null)
            {
                soundPlayer.Stop();

                soundPlayer.Dispose();

                soundPlayer = null;
            }

            if (string.IsNullOrWhiteSpace(filePath))
            {
                return;
            }

            soundPlayer = new SoundPlayer(filePath);

            if (playLooping)
            {
                soundPlayer.PlayLooping();
            }
            else
            {
                soundPlayer.Play();                
            }
        }

        private void _wavPlay_stop()
        {
            try
            {
                wavPlayTimer.Enabled = false;

                soundPlayer.Stop();
            }
            catch
            {
            }
        }
        #endregion

        #region Text를 음성으로 출력
        private void _Text_to_Speech(string sFileName)
        {
            string RecipePath = voiceRecipePath;
            RecipePath += sFileName + ".txt";
            strVoiceValue = File.ReadAllText(RecipePath);

            voiceTimer.Enabled = true;           
        }

        private void _Voice_loop(object sender, ElapsedEventArgs e)
        {
            try
            {
                speechSynthesizer.SetOutputToDefaultAudioDevice();
                speechSynthesizer.Volume = 100;
                speechSynthesizer.SelectVoice("Microsoft Heami Desktop");
                speechSynthesizer.Speak(strVoiceValue);                
            }
            catch
            {
            }            
        }

        private void _Voice_stop()
        {
            try
            {
                voiceTimer.Enabled = false;

                if (speechSynthesizer.State == SynthesizerState.Speaking)
                    speechSynthesizer.SpeakAsyncCancelAll();
            }
            catch
            {
            }
        }
        
        private void btnVoiceStop_Click(object sender, EventArgs e)
        {
            //_Voice_stop();
            _wavPlay_stop();
        }
        #endregion

        private void btnVoiceMessage_Click(object sender, EventArgs e)
        {
            voiceMessageForm = new VoiceMessageForm();
            voiceMessageForm.Show();
        }

        private void btnPPTfolderOpen_Click(object sender, EventArgs e)
        {
            Process.Start(pptFilePath);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Process.Start(logfilePath);
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            String openPDFFile = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Document\Manual.pdf"));
            File.WriteAllBytes(openPDFFile, Properties.Resources.Manual);
            Process.Start(openPDFFile);
        }

        #region 이벤트로그 파일 폴더 및 파일 생성       
        public static void EventLog(string Msg, string moduleName, string Mode)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
            string sDate = string.Format("{0}-{1}-{2}", sYear, sMonth, sDay);
            string sTime = DateTime.Now.ToString("HH:mm:ss");
            string sDateTime;
            sDateTime = string.Format("[{0}, {1}] ", sDate, sTime);

            WriteFile(string.Format("{0}{1}", sDateTime, Msg), moduleName, Mode);            
        }

        private static void WriteFile(string Msg, string moduleName, string Mode)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
            string FileName = string.Format("{0}.txt", sDay);
            string sPath = string.Empty;
            if (Mode == "Event")
            {
                sPath = logfilePath;
            }            

            try
            {
                if (!Directory.Exists(string.Format("{0}{1}\\{2}", sPath, moduleName, sYear)))
                {
                    CreateYearFolder(string.Format("{0}{1}", sPath, moduleName));
                }

                if (!Directory.Exists(string.Format("{0}{1}\\{2}\\{3}", sPath, moduleName, sYear, sMonth)))
                {
                    CreateMonthFolder(string.Format("{0}{1}", sPath, moduleName));
                }

                if (File.Exists(string.Format("{0}{1}\\{2}\\{3}\\{4}", sPath, moduleName, sYear, sMonth, FileName)))
                {
                    StreamWriter writer;
                    writer = File.AppendText(string.Format("{0}{1}\\{2}\\{3}\\{4}", sPath, moduleName, sYear, sMonth, FileName));
                    writer.WriteLine(Msg);
                    writer.Close();
                }
                else
                {
                    CreateFile(string.Format("{0}{1}", sPath, moduleName), Msg);

                    StreamWriter writer;
                    writer = File.AppendText(string.Format("{0}{1}\\{2}\\{3}\\{4}", sPath, moduleName, sYear, sMonth, FileName));
                    writer.WriteLine(Msg);
                    writer.Close();
                }
            }
            catch (IOException)
            {

            }
        }

        private static void CreateYearFolder(string Path)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string FolderName = sYear;

            Directory.CreateDirectory(string.Format("{0}\\{1}", Path, FolderName));
        }

        private static void CreateMonthFolder(string Path)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string FolderName = sMonth;

            Directory.CreateDirectory(string.Format("{0}\\{1}\\{2}", Path, sYear, FolderName));
        }

        private static void CreateFile(string Path, string Msg)
        {
            string sYear = string.Format("{0:yyyy}", DateTime.Now).Trim();
            string sMonth = string.Format("{0:MM}", DateTime.Now).Trim();
            string sDay = string.Format("{0:dd}", DateTime.Now).Trim();
            string FileName = string.Format("{0}.txt", sDay);

            if (!File.Exists(string.Format("{0}\\{1}\\{2}\\{3}", Path, sYear, sMonth, FileName)))
            {
                using (File.Create(string.Format("{0}\\{1}\\{2}\\{3}", Path, sYear, sMonth, FileName))) ;
            }
        }
        #endregion    
    }
}
