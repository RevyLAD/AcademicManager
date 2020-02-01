﻿namespace Academic_Manager
{
    partial class MockRecordInsUpForm
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
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblStudentName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lblStudentID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cmbSemester = new MetroFramework.Controls.MetroComboBox();
            this.cmbGrade = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtMath = new MetroFramework.Controls.MetroTextBox();
            this.txtEnglish = new MetroFramework.Controls.MetroTextBox();
            this.txtKorean = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtSub1 = new MetroFramework.Controls.MetroTextBox();
            this.txtSub2 = new MetroFramework.Controls.MetroTextBox();
            this.txtForegin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(214, 223);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(126, 223);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentName.Location = new System.Drawing.Point(220, 14);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(51, 19);
            this.lblStudentName.TabIndex = 59;
            this.lblStudentName.Text = "홍길동";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(178, 14);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(45, 19);
            this.metroLabel16.TabIndex = 60;
            this.metroLabel16.Text = "이름 :";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentID.Location = new System.Drawing.Point(66, 14);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 19);
            this.lblStudentID.TabIndex = 61;
            this.lblStudentID.Text = "2014001";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(10, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 62;
            this.metroLabel5.Text = "학생ID :";
            this.metroLabel5.UseStyleColors = true;
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.ItemHeight = 23;
            this.cmbSemester.Location = new System.Drawing.Point(216, 51);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(52, 29);
            this.cmbSemester.TabIndex = 1;
            this.cmbSemester.UseSelectable = true;
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.ItemHeight = 23;
            this.cmbGrade.Location = new System.Drawing.Point(50, 51);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(52, 29);
            this.cmbGrade.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmbGrade.TabIndex = 0;
            this.cmbGrade.UseSelectable = true;
            this.cmbGrade.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(150, 55);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 55;
            this.metroLabel3.Text = "모의고사";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(10, 55);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "학년";
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
            this.txtMath.Location = new System.Drawing.Point(50, 184);
            this.txtMath.MaxLength = 4;
            this.txtMath.Name = "txtMath";
            this.txtMath.PasswordChar = '\0';
            this.txtMath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMath.SelectedText = "";
            this.txtMath.SelectionLength = 0;
            this.txtMath.SelectionStart = 0;
            this.txtMath.ShortcutsEnabled = true;
            this.txtMath.Size = new System.Drawing.Size(52, 23);
            this.txtMath.TabIndex = 6;
            this.txtMath.UseSelectable = true;
            this.txtMath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKorean_KeyPress);
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
            this.txtEnglish.Location = new System.Drawing.Point(50, 142);
            this.txtEnglish.MaxLength = 4;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.PasswordChar = '\0';
            this.txtEnglish.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnglish.SelectedText = "";
            this.txtEnglish.SelectionLength = 0;
            this.txtEnglish.SelectionStart = 0;
            this.txtEnglish.ShortcutsEnabled = true;
            this.txtEnglish.Size = new System.Drawing.Size(52, 23);
            this.txtEnglish.TabIndex = 4;
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
            this.txtKorean.Location = new System.Drawing.Point(50, 98);
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 184);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "수학";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "영어";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "국어";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(142, 100);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(75, 19);
            this.metroLabel6.TabIndex = 54;
            this.metroLabel6.Text = "사회/과학1";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(142, 142);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(77, 19);
            this.metroLabel8.TabIndex = 53;
            this.metroLabel8.Text = "사회/과학2";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(142, 184);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 52;
            this.metroLabel9.Text = "제2외국어";
            // 
            // txtSub1
            // 
            // 
            // 
            // 
            this.txtSub1.CustomButton.Image = null;
            this.txtSub1.CustomButton.Location = new System.Drawing.Point(26, 1);
            this.txtSub1.CustomButton.Name = "";
            this.txtSub1.CustomButton.Size = new System.Drawing.Size(18, 17);
            this.txtSub1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSub1.CustomButton.TabIndex = 1;
            this.txtSub1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSub1.CustomButton.UseSelectable = true;
            this.txtSub1.CustomButton.Visible = false;
            this.txtSub1.Lines = new string[0];
            this.txtSub1.Location = new System.Drawing.Point(216, 100);
            this.txtSub1.MaxLength = 4;
            this.txtSub1.Name = "txtSub1";
            this.txtSub1.PasswordChar = '\0';
            this.txtSub1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSub1.SelectedText = "";
            this.txtSub1.SelectionLength = 0;
            this.txtSub1.SelectionStart = 0;
            this.txtSub1.ShortcutsEnabled = true;
            this.txtSub1.Size = new System.Drawing.Size(52, 23);
            this.txtSub1.TabIndex = 3;
            this.txtSub1.UseSelectable = true;
            this.txtSub1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSub1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSub1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKorean_KeyPress);
            // 
            // txtSub2
            // 
            // 
            // 
            // 
            this.txtSub2.CustomButton.Image = null;
            this.txtSub2.CustomButton.Location = new System.Drawing.Point(26, 1);
            this.txtSub2.CustomButton.Name = "";
            this.txtSub2.CustomButton.Size = new System.Drawing.Size(18, 17);
            this.txtSub2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSub2.CustomButton.TabIndex = 1;
            this.txtSub2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSub2.CustomButton.UseSelectable = true;
            this.txtSub2.CustomButton.Visible = false;
            this.txtSub2.Lines = new string[0];
            this.txtSub2.Location = new System.Drawing.Point(216, 142);
            this.txtSub2.MaxLength = 4;
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.PasswordChar = '\0';
            this.txtSub2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSub2.SelectedText = "";
            this.txtSub2.SelectionLength = 0;
            this.txtSub2.SelectionStart = 0;
            this.txtSub2.ShortcutsEnabled = true;
            this.txtSub2.Size = new System.Drawing.Size(52, 23);
            this.txtSub2.TabIndex = 5;
            this.txtSub2.UseSelectable = true;
            this.txtSub2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSub2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSub2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKorean_KeyPress);
            // 
            // txtForegin
            // 
            // 
            // 
            // 
            this.txtForegin.CustomButton.Image = null;
            this.txtForegin.CustomButton.Location = new System.Drawing.Point(26, 1);
            this.txtForegin.CustomButton.Name = "";
            this.txtForegin.CustomButton.Size = new System.Drawing.Size(18, 17);
            this.txtForegin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtForegin.CustomButton.TabIndex = 1;
            this.txtForegin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtForegin.CustomButton.UseSelectable = true;
            this.txtForegin.CustomButton.Visible = false;
            this.txtForegin.Lines = new string[0];
            this.txtForegin.Location = new System.Drawing.Point(216, 184);
            this.txtForegin.MaxLength = 4;
            this.txtForegin.Name = "txtForegin";
            this.txtForegin.PasswordChar = '\0';
            this.txtForegin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtForegin.SelectedText = "";
            this.txtForegin.SelectionLength = 0;
            this.txtForegin.SelectionStart = 0;
            this.txtForegin.ShortcutsEnabled = true;
            this.txtForegin.Size = new System.Drawing.Size(52, 23);
            this.txtForegin.TabIndex = 7;
            this.txtForegin.UseSelectable = true;
            this.txtForegin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtForegin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtForegin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKorean_KeyPress);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(107, 100);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(23, 19);
            this.metroLabel10.TabIndex = 54;
            this.metroLabel10.Text = "점";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(107, 145);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(23, 19);
            this.metroLabel11.TabIndex = 54;
            this.metroLabel11.Text = "점";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(273, 186);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(23, 19);
            this.metroLabel12.TabIndex = 54;
            this.metroLabel12.Text = "점";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(273, 144);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(23, 19);
            this.metroLabel13.TabIndex = 54;
            this.metroLabel13.Text = "점";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(273, 102);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(23, 19);
            this.metroLabel14.TabIndex = 54;
            this.metroLabel14.Text = "점";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(107, 186);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(23, 19);
            this.metroLabel15.TabIndex = 54;
            this.metroLabel15.Text = "점";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(273, 55);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(23, 19);
            this.metroLabel17.TabIndex = 54;
            this.metroLabel17.Text = "월";
            // 
            // MockRecordInsUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 266);
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
            this.Controls.Add(this.txtForegin);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtSub1);
            this.Controls.Add(this.txtKorean);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MockRecordInsUpForm";
            this.Padding = new System.Windows.Forms.Padding(18, 48, 18, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.MockRecordInsUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MetroFramework.Controls.MetroLabel lblStudentName;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblStudentID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cmbSemester;
        private MetroFramework.Controls.MetroComboBox cmbGrade;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtMath;
        private MetroFramework.Controls.MetroTextBox txtEnglish;
        private MetroFramework.Controls.MetroTextBox txtKorean;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtSub1;
        private MetroFramework.Controls.MetroTextBox txtSub2;
        private MetroFramework.Controls.MetroTextBox txtForegin;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel17;
    }
}