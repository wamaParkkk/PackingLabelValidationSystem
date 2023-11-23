using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

enum EditMode : byte
{
    NORMAL_MODE = 0,
    VIEW_MODE = 1,
    EDIT_MODE = 2
}

namespace PackingLabelValidationSystem
{
    public partial class VoiceMessageForm : Form
    {
        KeyboardDlg KeyDlg;

        string voiceRecipePath;
        string voiceRecipePath2;

        byte m_nEditMode;


        public VoiceMessageForm()
        {
            InitializeComponent();
        }

        private void VoiceMessageForm_Load(object sender, EventArgs e)
        {
            Width = 700;
            Height = 880;
            Left = 30;
            Top = 10;

            _voiceRecipeFilePath_Load();

            LoadDirectory(voiceRecipePath);            

            nEditMode = (byte)EditMode.NORMAL_MODE;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
                    voiceRecipePath2 = lines[1].ToString();
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

        private void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tn = treeView.Nodes.Add(di.Name);
            tn.Tag = di.FullName;
            LoadFiles(Dir, tn);
            LoadSubDirectories(Dir, tn);
            treeView.ExpandAll();
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tn = td.Nodes.Add(fi.Name);
                tn.Tag = fi.FullName;
                tn.ImageIndex = 2;
                tn.SelectedImageIndex = 2;
            }
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tn = td.Nodes.Add(di.Name);
                tn.ImageIndex = 0;
                tn.SelectedImageIndex = 0;
                tn.Tag = di.FullName;
                LoadFiles(subdirectory, tn);
                LoadSubDirectories(subdirectory, tn);
            }
        }        

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            richTextBox.Clear();

            if (e.Node.Text.Contains(".txt"))
            {
                txt_RecipeFileName.Text = e.Node.Text;

                //string sBasePath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\"));
                string sBasePath = voiceRecipePath2;
                string sNodePath = e.Node.FullPath;                
                string sFullPath = sBasePath + sNodePath;

                //richTextBox.LoadFile(sFullPath, RichTextBoxStreamType.PlainText);

                using (StreamReader sr = new StreamReader(sFullPath, Encoding.UTF8))
                {
                    richTextBox.Text = sr.ReadToEnd();
                }

                nEditMode = (byte)EditMode.VIEW_MODE;
            }
        }

        private void _Items_init()
        {
            comboBoxTrayCnt.SelectedIndex = 0;
            comboBoxCoverTrayCnt.SelectedIndex = 0;
            comboBoxDesiccantCnt.SelectedIndex = 0;
            comboBoxHICCnt.SelectedIndex = 0;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Text = string.Format("{0}\n{1}\n{2}\n{3}",
                comboBoxTrayCnt.Text, comboBoxCoverTrayCnt.Text, comboBoxDesiccantCnt.Text, comboBoxHICCnt.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region VOICE MESSAGE FILE 관련
        private void btn_RecipeFile_New_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Clear();

                KeyDlg = new KeyboardDlg();
                KeyDlg.Set_Password(false);
                if (KeyDlg.ShowDialog() == DialogResult.OK)
                {
                    txt_RecipeFileName.Text = KeyDlg.m_strResult;
                    if (txt_RecipeFileName.Text.IndexOf(".txt") < 0)
                    {
                        txt_RecipeFileName.Text += ".txt";
                    }

                    string RecipePath = voiceRecipePath;
                    if (File.Exists(RecipePath + txt_RecipeFileName.Text))
                    {
                        MessageBox.Show("A file with the same name already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        nEditMode = (byte)EditMode.EDIT_MODE;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RecipeFile_Edit_Click(object sender, EventArgs e)
        {
            nEditMode = (byte)EditMode.EDIT_MODE;
        }

        private void btn_RecipeFile_Copy_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView.Nodes.Count > 0)
                {
                    string strFileName = txt_RecipeFileName.Text;
                    string strCopyName = "";
                    string RecipePath = "";

                    KeyDlg = new KeyboardDlg();
                    KeyDlg.Set_Password(false);

                    if (KeyDlg.ShowDialog() == DialogResult.OK)
                    {
                        strCopyName = KeyDlg.m_strResult;
                        if (strCopyName.IndexOf(".txt") < 0)
                        {
                            strCopyName += ".txt";
                        }

                        RecipePath = voiceRecipePath;

                        strFileName = RecipePath + strFileName;
                        strCopyName = RecipePath + strCopyName;

                        if (File.Exists(strFileName))
                        {
                            if (File.Exists(strCopyName))
                            {
                                MessageBox.Show("A file with the same name already exists", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                File.Copy(strFileName, strCopyName, true);
                            }
                        }
                    }

                    _Refresh_Directory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_RecipeFile_Save_Click(object sender, EventArgs e)
        {
            string RecipePath = voiceRecipePath;
            RecipePath += txt_RecipeFileName.Text;
            string strTextValue = richTextBox.Text;
            File.WriteAllText(RecipePath, strTextValue, Encoding.UTF8);

            _Refresh_Directory();

            nEditMode = (int)EditMode.NORMAL_MODE;
        }

        private void btn_RecipeFile_Del_Click(object sender, EventArgs e)
        {
            string RecipePath = voiceRecipePath;
            RecipePath += txt_RecipeFileName.Text;
            File.Delete(RecipePath);

            _Refresh_Directory();
        }

        private void btn_RecipeFile_Cancel_Click(object sender, EventArgs e)
        {
            nEditMode = (int)EditMode.NORMAL_MODE;

            _Refresh_Directory();
        }

        private void _Refresh_Directory()
        {
            treeView.Nodes.Clear();
            LoadDirectory(voiceRecipePath);
        }

        private byte nEditMode
        {
            get
            {
                return m_nEditMode;
            }
            set
            {
                m_nEditMode = value;
                switch (value)
                {
                    case (byte)EditMode.NORMAL_MODE:
                        {
                            btn_RecipeFile_New.Enabled = true;
                            btn_RecipeFile_Edit.Enabled = false;
                            btn_RecipeFile_Copy.Enabled = false;
                            btn_RecipeFile_Save.Enabled = false;
                            btn_RecipeFile_Del.Enabled = false;
                            btn_RecipeFile_Cancel.Enabled = false;

                            comboBoxTrayCnt.Enabled = false;
                            comboBoxCoverTrayCnt.Enabled = false;
                            comboBoxDesiccantCnt.Enabled = false;
                            comboBoxHICCnt.Enabled = false;

                            btnItemAdd.Enabled = false;

                            _Items_init();                            
                        }
                        break;

                    case (byte)EditMode.VIEW_MODE:
                        {
                            btn_RecipeFile_New.Enabled = true;
                            btn_RecipeFile_Edit.Enabled = true;
                            btn_RecipeFile_Copy.Enabled = true;
                            btn_RecipeFile_Save.Enabled = false;
                            btn_RecipeFile_Del.Enabled = true;
                            btn_RecipeFile_Cancel.Enabled = false;

                            comboBoxTrayCnt.Enabled = false;
                            comboBoxCoverTrayCnt.Enabled = false;
                            comboBoxDesiccantCnt.Enabled = false;
                            comboBoxHICCnt.Enabled = false;

                            btnItemAdd.Enabled = false;

                            _Items_init();                            
                        }
                        break;

                    case (byte)EditMode.EDIT_MODE:
                        {
                            btn_RecipeFile_New.Enabled = false;
                            btn_RecipeFile_Edit.Enabled = false;
                            btn_RecipeFile_Copy.Enabled = false;
                            btn_RecipeFile_Save.Enabled = true;
                            btn_RecipeFile_Del.Enabled = false;
                            btn_RecipeFile_Cancel.Enabled = true;

                            comboBoxTrayCnt.Enabled = true;
                            comboBoxCoverTrayCnt.Enabled = true;
                            comboBoxDesiccantCnt.Enabled = true;
                            comboBoxHICCnt.Enabled = true;

                            btnItemAdd.Enabled = true;
                        }
                        break;
                }
            }
        }
        #endregion        
    }
}
