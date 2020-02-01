namespace Academic_Manager
{
    partial class SchoolRecordInsUpForm
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
            this.txtEnglish = new MetroFramework.Controls.MetroTextBox();
            this.txtKorean = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbGrade = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmbSemester = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMath = new MetroFramework.Controls.MetroTextBox();
            this.lblStudentName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lblStudentID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtEnglish
            // 
            // 
            // 
            // 
            this.txtEnglish.CustomButton.Image = null;
            this.txtEnglish.CustomButton.Location = new System.Drawing.Point(26, 1);
            this.txtEnglish.CustomButton.Name = "";
            this.txtEnglish.CustomButton.Size = new System.Drawing.Size(18, 17);
            this.txtEnglish.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnglish.CustomButton.TabIndex = 1;
            this.txtEnglish.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnglish.CustomButton.UseSelectable = true;
            this.txtEnglish.CustomButton.Visible = false;
            this.txtEnglish.Lines = new string[0];
            this.txtEnglish.Location = new System.Drawing.Point(177, 112);
            this.txtEnglish.MaxLength = 4;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.PasswordChar = '\0';
            this.txtEnglish.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnglish.SelectedText = "";
            this.txtEnglish.SelectionLength = 0;
            this.txtEnglish.SelectionStart = 0;
            this.txtEnglish.ShortcutsEnabled = true;
            this.txtEnglish.Size = new System.Drawing.Size(52, 23);
            this.txtEnglish.TabIndex = 3;
            this.txtEnglish.UseSelectable = true;
            this.txtEnglish.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnglish.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEnglish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKorean_KeyPress);
            // 
            // txtKorean
            // 
            // 
            // 
            // 
            this.txtKorean.CustomButton.Image = null;
            this.txtKorean.CustomButton.Location = new System.Drawing.Point(26, 1);
            this.txtKorean.CustomButton.Name = "";
            this.txtKorean.CustomButton.Size = new System.Drawing.Size(18, 17);
            this.txtKorean.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKorean.CustomButton.TabIndex = 1;
            this.txtKorean.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKorean.CustomButton.UseSelectable = true;
            this.txtKorean.CustomButton.Visible = false;
            this.txtKorean.Lines = new string[0];
            this.txtKorean.Location = new System.Drawing.Point(177, 69);
            this.txtKorean.MaxLength = 4;
            this.txtKorean.Name = "txtKorean";
            this.txtKorean.PasswordChar = '\0';
            this.txtKorean.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKorean.SelectedText = "";
            this.txtKorean.SelectionLength = 0;
            this.txtKorean.SelectionStart = 0;
            this.txtKorean.ShortcutsEnabled = true;
            this.txtKorean.Size = new System.Drawing.Size(52, 23);
            this.txtKorean.TabIndex = 2;
            this.txtKorean.UseSelectable = true;
            this.txtKorean.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKorean.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKorean.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKorean_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(134, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "영어";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(134, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "국어";
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.ItemHeight = 23;
            this.cmbGrade.Location = new System.Drawing.Point(54, 70);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(44, 29);
            this.cmbGrade.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmbGrade.TabIndex = 0;
            this.cmbGrade.UseSelectable = true;
            this.cmbGrade.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(11, 70);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "학년";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "학기";
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.ItemHeight = 23;
            this.cmbSemester.Location = new System.Drawing.Point(54, 115);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(44, 29);
            this.cmbSemester.TabIndex = 1;
            this.cmbSemester.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(134, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "수학";
            // 
            // txtMath
            // 
            // 
            // 
            // 
            this.txtMath.CustomButton.Image = null;
            this.txtMath.CustomButton.Location = new System.Drawing.Point(26, 1);
            this.txtMath.CustomButton.Name = "";
            this.txtMath.CustomButton.Size = new System.Drawing.Size(18, 17);
            this.txtMath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMath.CustomButton.TabIndex = 1;
            this.txtMath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMath.CustomButton.UseSelectable = true;
            this.txtMath.CustomButton.Visible = false;
            this.txtMath.Lines = new string[0];
            this.txtMath.Location = new System.Drawing.Point(177, 153);
            this.txtMath.MaxLength = 4;
            this.txtMath.Name = "txtMath";
            this.txtMath.PasswordChar = '\0';
            this.txtMath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMath.SelectedText = "";
            this.txtMath.SelectionLength = 0;
            this.txtMath.SelectionStart = 0;
            this.txtMath.ShortcutsEnabled = true;
            this.txtMath.Size = new System.Drawing.Size(52, 23);
            this.txtMath.TabIndex = 4;
            this.txtMath.UseSelectable = true;
            this.txtMath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKorean_KeyPress);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentName.Location = new System.Drawing.Point(202, 30);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(51, 19);
            this.lblStudentName.TabIndex = 10;
            this.lblStudentName.Text = "홍길동";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(159, 30);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(45, 19);
            this.metroLabel16.TabIndex = 11;
            this.metroLabel16.Text = "이름 :";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentID.Location = new System.Drawing.Point(66, 30);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 19);
            this.lblStudentID.TabIndex = 12;
            this.lblStudentID.Text = "2014001";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(11, 30);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 13;
            this.metroLabel5.Text = "학생ID :";
            this.metroLabel5.UseStyleColors = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(180, 196);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(91, 196);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(234, 114);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(23, 19);
            this.metroLabel10.TabIndex = 55;
            this.metroLabel10.Text = "점";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(234, 154);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(23, 19);
            this.metroLabel6.TabIndex = 55;
            this.metroLabel6.Text = "점";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(234, 70);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(23, 19);
            this.metroLabel8.TabIndex = 55;
            this.metroLabel8.Text = "점";
            // 
            // SchoolRecordInsUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 230);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.cmbGrade);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtKorean);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchoolRecordInsUpForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.SchoolRecordInsUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtEnglish;
        private MetroFramework.Controls.MetroTextBox txtKorean;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbGrade;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cmbSemester;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMath;
        private MetroFramework.Controls.MetroLabel lblStudentName;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblStudentID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}