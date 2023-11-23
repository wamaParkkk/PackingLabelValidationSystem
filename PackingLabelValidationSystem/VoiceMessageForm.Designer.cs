namespace PackingLabelValidationSystem
{
    partial class VoiceMessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceMessageForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxTrayCnt = new System.Windows.Forms.ComboBox();
            this.comboBoxCoverTrayCnt = new System.Windows.Forms.ComboBox();
            this.comboBoxDesiccantCnt = new System.Windows.Forms.ComboBox();
            this.comboBoxHICCnt = new System.Windows.Forms.ComboBox();
            this.txt_RecipeFileName = new System.Windows.Forms.Label();
            this.btn_RecipeFile_Save = new System.Windows.Forms.Button();
            this.btn_RecipeFile_Edit = new System.Windows.Forms.Button();
            this.btn_RecipeFile_Cancel = new System.Windows.Forms.Button();
            this.btn_RecipeFile_Copy = new System.Windows.Forms.Button();
            this.btn_RecipeFile_Del = new System.Windows.Forms.Button();
            this.btn_RecipeFile_New = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(659, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 598;
            this.btnExit.Text = "r";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxTrayCnt
            // 
            this.comboBoxTrayCnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrayCnt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTrayCnt.FormattingEnabled = true;
            this.comboBoxTrayCnt.Items.AddRange(new object[] {
            "1+1 자재입니다",
            "2+1 자재입니다",
            "3+1 자재입니다",
            "4+1 자재입니다",
            "5+1 자재입니다",
            "6+1 자재입니다",
            "7+1 자재입니다",
            "8+1 자재입니다",
            "9+1 자재입니다",
            "10+1 자재입니다"});
            this.comboBoxTrayCnt.Location = new System.Drawing.Point(12, 539);
            this.comboBoxTrayCnt.Name = "comboBoxTrayCnt";
            this.comboBoxTrayCnt.Size = new System.Drawing.Size(290, 33);
            this.comboBoxTrayCnt.TabIndex = 600;
            // 
            // comboBoxCoverTrayCnt
            // 
            this.comboBoxCoverTrayCnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCoverTrayCnt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCoverTrayCnt.FormattingEnabled = true;
            this.comboBoxCoverTrayCnt.Items.AddRange(new object[] {
            "커버트레이 한 개 사용해주세요",
            "커버트레이 미사용"});
            this.comboBoxCoverTrayCnt.Location = new System.Drawing.Point(12, 609);
            this.comboBoxCoverTrayCnt.Name = "comboBoxCoverTrayCnt";
            this.comboBoxCoverTrayCnt.Size = new System.Drawing.Size(290, 33);
            this.comboBoxCoverTrayCnt.TabIndex = 601;
            // 
            // comboBoxDesiccantCnt
            // 
            this.comboBoxDesiccantCnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDesiccantCnt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDesiccantCnt.FormattingEnabled = true;
            this.comboBoxDesiccantCnt.Items.AddRange(new object[] {
            "데시칸트 한 개 넣어주세요",
            "데시칸트 두 개 넣어주세요",
            "데시칸트 미사용"});
            this.comboBoxDesiccantCnt.Location = new System.Drawing.Point(12, 679);
            this.comboBoxDesiccantCnt.Name = "comboBoxDesiccantCnt";
            this.comboBoxDesiccantCnt.Size = new System.Drawing.Size(290, 33);
            this.comboBoxDesiccantCnt.TabIndex = 602;
            // 
            // comboBoxHICCnt
            // 
            this.comboBoxHICCnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHICCnt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHICCnt.FormattingEnabled = true;
            this.comboBoxHICCnt.Items.AddRange(new object[] {
            "H I C 한 개 넣어주세요",
            "H I C 두 개 넣어주세요",
            "H I C 미사용"});
            this.comboBoxHICCnt.Location = new System.Drawing.Point(12, 749);
            this.comboBoxHICCnt.Name = "comboBoxHICCnt";
            this.comboBoxHICCnt.Size = new System.Drawing.Size(290, 33);
            this.comboBoxHICCnt.TabIndex = 603;
            // 
            // txt_RecipeFileName
            // 
            this.txt_RecipeFileName.BackColor = System.Drawing.Color.White;
            this.txt_RecipeFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RecipeFileName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RecipeFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_RecipeFileName.Location = new System.Drawing.Point(12, 491);
            this.txt_RecipeFileName.Name = "txt_RecipeFileName";
            this.txt_RecipeFileName.Size = new System.Drawing.Size(677, 30);
            this.txt_RecipeFileName.TabIndex = 613;
            this.txt_RecipeFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_RecipeFile_Save
            // 
            this.btn_RecipeFile_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_RecipeFile_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RecipeFile_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RecipeFile_Save.FlatAppearance.BorderSize = 0;
            this.btn_RecipeFile_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RecipeFile_Save.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecipeFile_Save.ForeColor = System.Drawing.Color.Navy;
            this.btn_RecipeFile_Save.Location = new System.Drawing.Point(589, 788);
            this.btn_RecipeFile_Save.Name = "btn_RecipeFile_Save";
            this.btn_RecipeFile_Save.Size = new System.Drawing.Size(67, 37);
            this.btn_RecipeFile_Save.TabIndex = 612;
            this.btn_RecipeFile_Save.Text = "Save";
            this.btn_RecipeFile_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_RecipeFile_Save.UseVisualStyleBackColor = false;
            this.btn_RecipeFile_Save.Click += new System.EventHandler(this.btn_RecipeFile_Save_Click);
            // 
            // btn_RecipeFile_Edit
            // 
            this.btn_RecipeFile_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_RecipeFile_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RecipeFile_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RecipeFile_Edit.FlatAppearance.BorderSize = 0;
            this.btn_RecipeFile_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RecipeFile_Edit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecipeFile_Edit.ForeColor = System.Drawing.Color.Navy;
            this.btn_RecipeFile_Edit.Location = new System.Drawing.Point(443, 788);
            this.btn_RecipeFile_Edit.Name = "btn_RecipeFile_Edit";
            this.btn_RecipeFile_Edit.Size = new System.Drawing.Size(67, 37);
            this.btn_RecipeFile_Edit.TabIndex = 611;
            this.btn_RecipeFile_Edit.Text = "Edit";
            this.btn_RecipeFile_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_RecipeFile_Edit.UseVisualStyleBackColor = false;
            this.btn_RecipeFile_Edit.Click += new System.EventHandler(this.btn_RecipeFile_Edit_Click);
            // 
            // btn_RecipeFile_Cancel
            // 
            this.btn_RecipeFile_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_RecipeFile_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RecipeFile_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RecipeFile_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_RecipeFile_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RecipeFile_Cancel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecipeFile_Cancel.ForeColor = System.Drawing.Color.Navy;
            this.btn_RecipeFile_Cancel.Location = new System.Drawing.Point(443, 831);
            this.btn_RecipeFile_Cancel.Name = "btn_RecipeFile_Cancel";
            this.btn_RecipeFile_Cancel.Size = new System.Drawing.Size(67, 37);
            this.btn_RecipeFile_Cancel.TabIndex = 610;
            this.btn_RecipeFile_Cancel.Text = "Cancel";
            this.btn_RecipeFile_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_RecipeFile_Cancel.UseVisualStyleBackColor = false;
            this.btn_RecipeFile_Cancel.Click += new System.EventHandler(this.btn_RecipeFile_Cancel_Click);
            // 
            // btn_RecipeFile_Copy
            // 
            this.btn_RecipeFile_Copy.BackColor = System.Drawing.Color.Transparent;
            this.btn_RecipeFile_Copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RecipeFile_Copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RecipeFile_Copy.FlatAppearance.BorderSize = 0;
            this.btn_RecipeFile_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RecipeFile_Copy.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecipeFile_Copy.ForeColor = System.Drawing.Color.Navy;
            this.btn_RecipeFile_Copy.Location = new System.Drawing.Point(516, 788);
            this.btn_RecipeFile_Copy.Name = "btn_RecipeFile_Copy";
            this.btn_RecipeFile_Copy.Size = new System.Drawing.Size(67, 37);
            this.btn_RecipeFile_Copy.TabIndex = 609;
            this.btn_RecipeFile_Copy.Text = "Copy";
            this.btn_RecipeFile_Copy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_RecipeFile_Copy.UseVisualStyleBackColor = false;
            this.btn_RecipeFile_Copy.Click += new System.EventHandler(this.btn_RecipeFile_Copy_Click);
            // 
            // btn_RecipeFile_Del
            // 
            this.btn_RecipeFile_Del.BackColor = System.Drawing.Color.Transparent;
            this.btn_RecipeFile_Del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RecipeFile_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RecipeFile_Del.FlatAppearance.BorderSize = 0;
            this.btn_RecipeFile_Del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RecipeFile_Del.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecipeFile_Del.ForeColor = System.Drawing.Color.Red;
            this.btn_RecipeFile_Del.Location = new System.Drawing.Point(370, 831);
            this.btn_RecipeFile_Del.Name = "btn_RecipeFile_Del";
            this.btn_RecipeFile_Del.Size = new System.Drawing.Size(67, 37);
            this.btn_RecipeFile_Del.TabIndex = 608;
            this.btn_RecipeFile_Del.Text = "Delete";
            this.btn_RecipeFile_Del.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_RecipeFile_Del.UseVisualStyleBackColor = false;
            this.btn_RecipeFile_Del.Click += new System.EventHandler(this.btn_RecipeFile_Del_Click);
            // 
            // btn_RecipeFile_New
            // 
            this.btn_RecipeFile_New.BackColor = System.Drawing.Color.Transparent;
            this.btn_RecipeFile_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_RecipeFile_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RecipeFile_New.FlatAppearance.BorderSize = 0;
            this.btn_RecipeFile_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RecipeFile_New.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecipeFile_New.ForeColor = System.Drawing.Color.Navy;
            this.btn_RecipeFile_New.Location = new System.Drawing.Point(370, 788);
            this.btn_RecipeFile_New.Name = "btn_RecipeFile_New";
            this.btn_RecipeFile_New.Size = new System.Drawing.Size(67, 37);
            this.btn_RecipeFile_New.TabIndex = 607;
            this.btn_RecipeFile_New.Text = "New";
            this.btn_RecipeFile_New.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_RecipeFile_New.UseVisualStyleBackColor = false;
            this.btn_RecipeFile_New.Click += new System.EventHandler(this.btn_RecipeFile_New_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(641, 30);
            this.label10.TabIndex = 606;
            this.label10.Text = "Voice file list";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Ivory;
            this.richTextBox.Enabled = false;
            this.richTextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.ForeColor = System.Drawing.Color.Black;
            this.richTextBox.Location = new System.Drawing.Point(370, 539);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(320, 243);
            this.richTextBox.TabIndex = 605;
            this.richTextBox.Text = "";
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.ForeColor = System.Drawing.Color.Black;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList1;
            this.treeView.Location = new System.Drawing.Point(12, 48);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 1;
            this.treeView.ShowRootLines = false;
            this.treeView.Size = new System.Drawing.Size(677, 429);
            this.treeView.TabIndex = 604;
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_close.png");
            this.imageList1.Images.SetKeyName(1, "folder_open.png");
            this.imageList1.Images.SetKeyName(2, "file.png");
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItemAdd.Font = new System.Drawing.Font("Wingdings 3", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnItemAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnItemAdd.Location = new System.Drawing.Point(314, 636);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(50, 50);
            this.btnItemAdd.TabIndex = 614;
            this.btnItemAdd.Text = "_";
            this.btnItemAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // VoiceMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(700, 880);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.txt_RecipeFileName);
            this.Controls.Add(this.btn_RecipeFile_Save);
            this.Controls.Add(this.btn_RecipeFile_Edit);
            this.Controls.Add(this.btn_RecipeFile_Cancel);
            this.Controls.Add(this.btn_RecipeFile_Copy);
            this.Controls.Add(this.btn_RecipeFile_Del);
            this.Controls.Add(this.btn_RecipeFile_New);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.comboBoxHICCnt);
            this.Controls.Add(this.comboBoxDesiccantCnt);
            this.Controls.Add(this.comboBoxCoverTrayCnt);
            this.Controls.Add(this.comboBoxTrayCnt);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoiceMessageForm";
            this.Text = "VoiceMessageForm";
            this.Load += new System.EventHandler(this.VoiceMessageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxTrayCnt;
        private System.Windows.Forms.ComboBox comboBoxCoverTrayCnt;
        private System.Windows.Forms.ComboBox comboBoxDesiccantCnt;
        private System.Windows.Forms.ComboBox comboBoxHICCnt;
        private System.Windows.Forms.Label txt_RecipeFileName;
        private System.Windows.Forms.Button btn_RecipeFile_Save;
        private System.Windows.Forms.Button btn_RecipeFile_Edit;
        private System.Windows.Forms.Button btn_RecipeFile_Cancel;
        private System.Windows.Forms.Button btn_RecipeFile_Copy;
        private System.Windows.Forms.Button btn_RecipeFile_Del;
        private System.Windows.Forms.Button btn_RecipeFile_New;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnItemAdd;
    }
}