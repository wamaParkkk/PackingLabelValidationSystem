namespace PackingLabelValidationSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox_AlTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_TargetDevice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Lead = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Dimension = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Pakage = new System.Windows.Forms.TextBox();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.textBox_CustomerCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_LotNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVoiceStop = new System.Windows.Forms.Button();
            this.btnPPTfolderOpen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVoiceMessage = new System.Windows.Forms.Button();
            this.textBoxTrayMsg = new System.Windows.Forms.TextBox();
            this.textBoxCoverTrayMsg = new System.Windows.Forms.TextBox();
            this.textBoxDesiccantMsg = new System.Windows.Forms.TextBox();
            this.textBoxHICMsg = new System.Windows.Forms.TextBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ExitButton.png");
            this.imageList1.Images.SetKeyName(1, "Save.png");
            this.imageList1.Images.SetKeyName(2, "Scanner.png");
            this.imageList1.Images.SetKeyName(3, "voice_message.png");
            this.imageList1.Images.SetKeyName(4, "folder_close.png");
            this.imageList1.Images.SetKeyName(5, "folder_open.png");
            this.imageList1.Images.SetKeyName(6, "file.png");
            this.imageList1.Images.SetKeyName(7, "voice_stop.png");
            this.imageList1.Images.SetKeyName(8, "UserGuide.png");
            this.imageList1.Images.SetKeyName(9, "log.png");
            // 
            // textBox_AlTag
            // 
            this.textBox_AlTag.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox_AlTag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_AlTag.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AlTag.ForeColor = System.Drawing.Color.White;
            this.textBox_AlTag.Location = new System.Drawing.Point(183, 9);
            this.textBox_AlTag.Name = "textBox_AlTag";
            this.textBox_AlTag.Size = new System.Drawing.Size(434, 33);
            this.textBox_AlTag.TabIndex = 579;
            this.textBox_AlTag.Tag = "0";
            this.textBox_AlTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_AlTag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_LotNo_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 578;
            this.label1.Text = "Al tag";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(12, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 33);
            this.label7.TabIndex = 577;
            this.label7.Text = "Target device";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_TargetDevice
            // 
            this.textBox_TargetDevice.BackColor = System.Drawing.Color.Black;
            this.textBox_TargetDevice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TargetDevice.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TargetDevice.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_TargetDevice.Location = new System.Drawing.Point(183, 282);
            this.textBox_TargetDevice.Name = "textBox_TargetDevice";
            this.textBox_TargetDevice.ReadOnly = true;
            this.textBox_TargetDevice.Size = new System.Drawing.Size(434, 33);
            this.textBox_TargetDevice.TabIndex = 576;
            this.textBox_TargetDevice.Tag = "2";
            this.textBox_TargetDevice.Text = "--";
            this.textBox_TargetDevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 33);
            this.label6.TabIndex = 575;
            this.label6.Text = "Lead";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Lead
            // 
            this.textBox_Lead.BackColor = System.Drawing.Color.Black;
            this.textBox_Lead.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Lead.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Lead.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_Lead.Location = new System.Drawing.Point(183, 243);
            this.textBox_Lead.Name = "textBox_Lead";
            this.textBox_Lead.ReadOnly = true;
            this.textBox_Lead.Size = new System.Drawing.Size(434, 33);
            this.textBox_Lead.TabIndex = 574;
            this.textBox_Lead.Tag = "2";
            this.textBox_Lead.Text = "--";
            this.textBox_Lead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 33);
            this.label5.TabIndex = 573;
            this.label5.Text = "Dimension";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Dimension
            // 
            this.textBox_Dimension.BackColor = System.Drawing.Color.Black;
            this.textBox_Dimension.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Dimension.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Dimension.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_Dimension.Location = new System.Drawing.Point(183, 204);
            this.textBox_Dimension.Name = "textBox_Dimension";
            this.textBox_Dimension.ReadOnly = true;
            this.textBox_Dimension.Size = new System.Drawing.Size(434, 33);
            this.textBox_Dimension.TabIndex = 572;
            this.textBox_Dimension.Tag = "2";
            this.textBox_Dimension.Text = "--";
            this.textBox_Dimension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 33);
            this.label4.TabIndex = 571;
            this.label4.Text = "Package";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 570;
            this.label3.Text = "Customer name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Pakage
            // 
            this.textBox_Pakage.BackColor = System.Drawing.Color.Black;
            this.textBox_Pakage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Pakage.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pakage.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_Pakage.Location = new System.Drawing.Point(183, 165);
            this.textBox_Pakage.Name = "textBox_Pakage";
            this.textBox_Pakage.ReadOnly = true;
            this.textBox_Pakage.Size = new System.Drawing.Size(434, 33);
            this.textBox_Pakage.TabIndex = 569;
            this.textBox_Pakage.Tag = "2";
            this.textBox_Pakage.Text = "--";
            this.textBox_Pakage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.BackColor = System.Drawing.Color.Black;
            this.textBox_CustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_CustomerName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CustomerName.Location = new System.Drawing.Point(183, 126);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.ReadOnly = true;
            this.textBox_CustomerName.Size = new System.Drawing.Size(434, 33);
            this.textBox_CustomerName.TabIndex = 568;
            this.textBox_CustomerName.Tag = "1";
            this.textBox_CustomerName.Text = "--";
            this.textBox_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_CustomerCode
            // 
            this.textBox_CustomerCode.BackColor = System.Drawing.Color.Black;
            this.textBox_CustomerCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_CustomerCode.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerCode.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CustomerCode.Location = new System.Drawing.Point(183, 87);
            this.textBox_CustomerCode.Name = "textBox_CustomerCode";
            this.textBox_CustomerCode.ReadOnly = true;
            this.textBox_CustomerCode.Size = new System.Drawing.Size(434, 33);
            this.textBox_CustomerCode.TabIndex = 567;
            this.textBox_CustomerCode.Tag = "0";
            this.textBox_CustomerCode.Text = "--";
            this.textBox_CustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 566;
            this.label2.Text = "Customer code";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.ImageIndex = 2;
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(623, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 33);
            this.label8.TabIndex = 580;
            // 
            // textBox_LotNo
            // 
            this.textBox_LotNo.BackColor = System.Drawing.Color.Black;
            this.textBox_LotNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_LotNo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LotNo.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_LotNo.Location = new System.Drawing.Point(183, 48);
            this.textBox_LotNo.Name = "textBox_LotNo";
            this.textBox_LotNo.ReadOnly = true;
            this.textBox_LotNo.Size = new System.Drawing.Size(434, 33);
            this.textBox_LotNo.TabIndex = 583;
            this.textBox_LotNo.Tag = "0";
            this.textBox_LotNo.Text = "--";
            this.textBox_LotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(12, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 33);
            this.label9.TabIndex = 582;
            this.label9.Text = "Lot No";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoiceStop
            // 
            this.btnVoiceStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoiceStop.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoiceStop.ForeColor = System.Drawing.Color.Navy;
            this.btnVoiceStop.ImageIndex = 7;
            this.btnVoiceStop.ImageList = this.imageList1;
            this.btnVoiceStop.Location = new System.Drawing.Point(199, 321);
            this.btnVoiceStop.Name = "btnVoiceStop";
            this.btnVoiceStop.Size = new System.Drawing.Size(100, 60);
            this.btnVoiceStop.TabIndex = 595;
            this.btnVoiceStop.Text = "Voice stop";
            this.btnVoiceStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoiceStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoiceStop.UseVisualStyleBackColor = true;
            this.btnVoiceStop.Click += new System.EventHandler(this.btnVoiceStop_Click);
            // 
            // btnPPTfolderOpen
            // 
            this.btnPPTfolderOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPPTfolderOpen.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPPTfolderOpen.ForeColor = System.Drawing.Color.Navy;
            this.btnPPTfolderOpen.ImageIndex = 4;
            this.btnPPTfolderOpen.ImageList = this.imageList1;
            this.btnPPTfolderOpen.Location = new System.Drawing.Point(411, 321);
            this.btnPPTfolderOpen.Name = "btnPPTfolderOpen";
            this.btnPPTfolderOpen.Size = new System.Drawing.Size(100, 60);
            this.btnPPTfolderOpen.TabIndex = 596;
            this.btnPPTfolderOpen.Text = "PPT folder";
            this.btnPPTfolderOpen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPPTfolderOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPPTfolderOpen.UseVisualStyleBackColor = true;
            this.btnPPTfolderOpen.Click += new System.EventHandler(this.btnPPTfolderOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(703, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 597;
            this.btnExit.Text = "r";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVoiceMessage
            // 
            this.btnVoiceMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoiceMessage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoiceMessage.ForeColor = System.Drawing.Color.Navy;
            this.btnVoiceMessage.ImageIndex = 3;
            this.btnVoiceMessage.ImageList = this.imageList1;
            this.btnVoiceMessage.Location = new System.Drawing.Point(305, 321);
            this.btnVoiceMessage.Name = "btnVoiceMessage";
            this.btnVoiceMessage.Size = new System.Drawing.Size(100, 60);
            this.btnVoiceMessage.TabIndex = 598;
            this.btnVoiceMessage.Text = "Voice recipe";
            this.btnVoiceMessage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoiceMessage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoiceMessage.UseVisualStyleBackColor = true;
            this.btnVoiceMessage.Click += new System.EventHandler(this.btnVoiceMessage_Click);
            // 
            // textBoxTrayMsg
            // 
            this.textBoxTrayMsg.BackColor = System.Drawing.Color.Black;
            this.textBoxTrayMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTrayMsg.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTrayMsg.ForeColor = System.Drawing.Color.White;
            this.textBoxTrayMsg.Location = new System.Drawing.Point(17, 418);
            this.textBoxTrayMsg.Name = "textBoxTrayMsg";
            this.textBoxTrayMsg.ReadOnly = true;
            this.textBoxTrayMsg.Size = new System.Drawing.Size(600, 57);
            this.textBoxTrayMsg.TabIndex = 599;
            this.textBoxTrayMsg.Tag = "0";
            this.textBoxTrayMsg.Text = "--";
            this.textBoxTrayMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCoverTrayMsg
            // 
            this.textBoxCoverTrayMsg.BackColor = System.Drawing.Color.Black;
            this.textBoxCoverTrayMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCoverTrayMsg.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoverTrayMsg.ForeColor = System.Drawing.Color.White;
            this.textBoxCoverTrayMsg.Location = new System.Drawing.Point(17, 481);
            this.textBoxCoverTrayMsg.Name = "textBoxCoverTrayMsg";
            this.textBoxCoverTrayMsg.ReadOnly = true;
            this.textBoxCoverTrayMsg.Size = new System.Drawing.Size(600, 57);
            this.textBoxCoverTrayMsg.TabIndex = 600;
            this.textBoxCoverTrayMsg.Tag = "0";
            this.textBoxCoverTrayMsg.Text = "--";
            this.textBoxCoverTrayMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDesiccantMsg
            // 
            this.textBoxDesiccantMsg.BackColor = System.Drawing.Color.Black;
            this.textBoxDesiccantMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDesiccantMsg.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesiccantMsg.ForeColor = System.Drawing.Color.White;
            this.textBoxDesiccantMsg.Location = new System.Drawing.Point(17, 544);
            this.textBoxDesiccantMsg.Name = "textBoxDesiccantMsg";
            this.textBoxDesiccantMsg.ReadOnly = true;
            this.textBoxDesiccantMsg.Size = new System.Drawing.Size(600, 57);
            this.textBoxDesiccantMsg.TabIndex = 601;
            this.textBoxDesiccantMsg.Tag = "0";
            this.textBoxDesiccantMsg.Text = "--";
            this.textBoxDesiccantMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHICMsg
            // 
            this.textBoxHICMsg.BackColor = System.Drawing.Color.Black;
            this.textBoxHICMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxHICMsg.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHICMsg.ForeColor = System.Drawing.Color.White;
            this.textBoxHICMsg.Location = new System.Drawing.Point(17, 607);
            this.textBoxHICMsg.Name = "textBoxHICMsg";
            this.textBoxHICMsg.ReadOnly = true;
            this.textBoxHICMsg.Size = new System.Drawing.Size(600, 57);
            this.textBoxHICMsg.TabIndex = 602;
            this.textBoxHICMsg.Tag = "0";
            this.textBoxHICMsg.Text = "--";
            this.textBoxHICMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnManual
            // 
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManual.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.Navy;
            this.btnManual.ImageIndex = 8;
            this.btnManual.ImageList = this.imageList1;
            this.btnManual.Location = new System.Drawing.Point(623, 321);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(100, 60);
            this.btnManual.TabIndex = 603;
            this.btnManual.Text = "Manual";
            this.btnManual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnLog
            // 
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.Navy;
            this.btnLog.ImageIndex = 9;
            this.btnLog.ImageList = this.imageList1;
            this.btnLog.Location = new System.Drawing.Point(517, 321);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(100, 60);
            this.btnLog.TabIndex = 604;
            this.btnLog.Text = "Log";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 1024);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.textBoxHICMsg);
            this.Controls.Add(this.textBoxDesiccantMsg);
            this.Controls.Add(this.textBoxCoverTrayMsg);
            this.Controls.Add(this.textBoxTrayMsg);
            this.Controls.Add(this.btnVoiceMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPPTfolderOpen);
            this.Controls.Add(this.btnVoiceStop);
            this.Controls.Add(this.textBox_LotNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_AlTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_TargetDevice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Lead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Dimension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Pakage);
            this.Controls.Add(this.textBox_CustomerName);
            this.Controls.Add(this.textBox_CustomerCode);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Packing label validation system";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox_AlTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_TargetDevice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Lead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Dimension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Pakage;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private System.Windows.Forms.TextBox textBox_CustomerCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_LotNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVoiceStop;
        private System.Windows.Forms.Button btnPPTfolderOpen;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnVoiceMessage;
        private System.Windows.Forms.TextBox textBoxTrayMsg;
        private System.Windows.Forms.TextBox textBoxCoverTrayMsg;
        private System.Windows.Forms.TextBox textBoxDesiccantMsg;
        private System.Windows.Forms.TextBox textBoxHICMsg;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnLog;
    }
}

