namespace Academic_Manager
{
    partial class UniversityForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUnivSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtMajorSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.lblStudentName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lblStudentID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.UnivMajorGrid = new MetroFramework.Controls.MetroGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSelectMajor = new System.Windows.Forms.TextBox();
            this.txtSelectUniv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnMajorSearch = new MetroFramework.Controls.MetroTile();
            this.btnUnivSearch = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.UnivMajorGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Gray;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(23, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 28);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "대학";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtUnivSearch
            // 
            // 
            // 
            // 
            this.txtUnivSearch.CustomButton.Image = null;
            this.txtUnivSearch.CustomButton.Location = new System.Drawing.Point(250, 2);
            this.txtUnivSearch.CustomButton.Name = "";
            this.txtUnivSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUnivSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnivSearch.CustomButton.TabIndex = 1;
            this.txtUnivSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnivSearch.CustomButton.UseSelectable = true;
            this.txtUnivSearch.CustomButton.Visible = false;
            this.txtUnivSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUnivSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtUnivSearch.Lines = new string[0];
            this.txtUnivSearch.Location = new System.Drawing.Point(79, 80);
            this.txtUnivSearch.MaxLength = 32767;
            this.txtUnivSearch.Name = "txtUnivSearch";
            this.txtUnivSearch.PasswordChar = '\0';
            this.txtUnivSearch.PromptText = "대학명을 입력해주세요.";
            this.txtUnivSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnivSearch.SelectedText = "";
            this.txtUnivSearch.SelectionLength = 0;
            this.txtUnivSearch.SelectionStart = 0;
            this.txtUnivSearch.ShortcutsEnabled = true;
            this.txtUnivSearch.Size = new System.Drawing.Size(276, 28);
            this.txtUnivSearch.TabIndex = 0;
            this.txtUnivSearch.UseSelectable = true;
            this.txtUnivSearch.WaterMark = "대학명을 입력해주세요.";
            this.txtUnivSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnivSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnivSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUnivSearch_KeyPress);
            // 
            // txtMajorSearch
            // 
            // 
            // 
            // 
            this.txtMajorSearch.CustomButton.Image = null;
            this.txtMajorSearch.CustomButton.Location = new System.Drawing.Point(249, 2);
            this.txtMajorSearch.CustomButton.Name = "";
            this.txtMajorSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMajorSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMajorSearch.CustomButton.TabIndex = 1;
            this.txtMajorSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMajorSearch.CustomButton.UseSelectable = true;
            this.txtMajorSearch.CustomButton.Visible = false;
            this.txtMajorSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMajorSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtMajorSearch.Lines = new string[0];
            this.txtMajorSearch.Location = new System.Drawing.Point(80, 126);
            this.txtMajorSearch.MaxLength = 32767;
            this.txtMajorSearch.Name = "txtMajorSearch";
            this.txtMajorSearch.PasswordChar = '\0';
            this.txtMajorSearch.PromptText = "학과 관련 키워드";
            this.txtMajorSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMajorSearch.SelectedText = "";
            this.txtMajorSearch.SelectionLength = 0;
            this.txtMajorSearch.SelectionStart = 0;
            this.txtMajorSearch.ShortcutsEnabled = true;
            this.txtMajorSearch.Size = new System.Drawing.Size(275, 28);
            this.txtMajorSearch.TabIndex = 1;
            this.txtMajorSearch.UseSelectable = true;
            this.txtMajorSearch.WaterMark = "학과 관련 키워드";
            this.txtMajorSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMajorSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajorSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMajorSearch_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.BackColor = System.Drawing.Color.Gray;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(23, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 28);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "학과";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.White;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(15, 164);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 29);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "검색결과";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.Black;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(121, 115);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(142, 39);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "분석";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            this.metroLabel5.Click += new System.EventHandler(this.MetroLabel5_Click_1);
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel27.Location = new System.Drawing.Point(1, 6);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(111, 19);
            this.metroLabel27.TabIndex = 47;
            this.metroLabel27.Text = "대학별 성적분석";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentName.Location = new System.Drawing.Point(205, 47);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(51, 19);
            this.lblStudentName.TabIndex = 48;
            this.lblStudentName.Text = "홍길동";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(162, 47);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(45, 19);
            this.metroLabel16.TabIndex = 49;
            this.metroLabel16.Text = "이름 :";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentID.Location = new System.Drawing.Point(78, 47);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(65, 19);
            this.lblStudentID.TabIndex = 50;
            this.lblStudentID.Text = "2014001";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(23, 47);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = "학생ID :";
            this.metroLabel6.UseStyleColors = true;
            // 
            // UnivMajorGrid
            // 
            this.UnivMajorGrid.AllowUserToResizeRows = false;
            this.UnivMajorGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UnivMajorGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnivMajorGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UnivMajorGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnivMajorGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UnivMajorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UnivMajorGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UnivMajorGrid.EnableHeadersVisualStyles = false;
            this.UnivMajorGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UnivMajorGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UnivMajorGrid.Location = new System.Drawing.Point(23, 189);
            this.UnivMajorGrid.Name = "UnivMajorGrid";
            this.UnivMajorGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UnivMajorGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UnivMajorGrid.RowHeadersWidth = 51;
            this.UnivMajorGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.UnivMajorGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.UnivMajorGrid.RowTemplate.Height = 23;
            this.UnivMajorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnivMajorGrid.Size = new System.Drawing.Size(373, 347);
            this.UnivMajorGrid.Style = MetroFramework.MetroColorStyle.Silver;
            this.UnivMajorGrid.TabIndex = 52;
            this.UnivMajorGrid.UseStyleColors = true;
            this.UnivMajorGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnivMajorGrid_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSelectMajor);
            this.panel1.Controls.Add(this.txtSelectUniv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Location = new System.Drawing.Point(16, 541);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 160);
            this.panel1.TabIndex = 53;
            // 
            // txtSelectMajor
            // 
            this.txtSelectMajor.Enabled = false;
            this.txtSelectMajor.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSelectMajor.Location = new System.Drawing.Point(66, 75);
            this.txtSelectMajor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectMajor.Multiline = true;
            this.txtSelectMajor.Name = "txtSelectMajor";
            this.txtSelectMajor.Size = new System.Drawing.Size(308, 29);
            this.txtSelectMajor.TabIndex = 9;
            // 
            // txtSelectUniv
            // 
            this.txtSelectUniv.Enabled = false;
            this.txtSelectUniv.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSelectUniv.Location = new System.Drawing.Point(66, 32);
            this.txtSelectUniv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelectUniv.Multiline = true;
            this.txtSelectUniv.Name = "txtSelectUniv";
            this.txtSelectUniv.Size = new System.Drawing.Size(308, 29);
            this.txtSelectUniv.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "선택결과";
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.Color.DarkRed;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(10, 75);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 28);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "학과";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            this.metroLabel8.Visible = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.BackColor = System.Drawing.Color.DarkRed;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(10, 32);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 28);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "대학";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            this.metroLabel7.Visible = false;
            // 
            // btnMajorSearch
            // 
            this.btnMajorSearch.ActiveControl = null;
            this.btnMajorSearch.BackColor = System.Drawing.Color.Black;
            this.btnMajorSearch.Location = new System.Drawing.Point(361, 126);
            this.btnMajorSearch.Name = "btnMajorSearch";
            this.btnMajorSearch.Size = new System.Drawing.Size(35, 35);
            this.btnMajorSearch.Style = MetroFramework.MetroColorStyle.White;
            this.btnMajorSearch.TabIndex = 5;
            this.btnMajorSearch.TileImage = global::Academic_Manager.Properties.Resources.loupe;
            this.btnMajorSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMajorSearch.UseSelectable = true;
            this.btnMajorSearch.UseStyleColors = true;
            this.btnMajorSearch.UseTileImage = true;
            this.btnMajorSearch.Click += new System.EventHandler(this.BtnMajorSearch_Click);
            // 
            // btnUnivSearch
            // 
            this.btnUnivSearch.ActiveControl = null;
            this.btnUnivSearch.BackColor = System.Drawing.Color.Black;
            this.btnUnivSearch.Location = new System.Drawing.Point(361, 80);
            this.btnUnivSearch.Name = "btnUnivSearch";
            this.btnUnivSearch.Size = new System.Drawing.Size(35, 35);
            this.btnUnivSearch.Style = MetroFramework.MetroColorStyle.White;
            this.btnUnivSearch.TabIndex = 5;
            this.btnUnivSearch.TileImage = global::Academic_Manager.Properties.Resources.loupe;
            this.btnUnivSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUnivSearch.UseSelectable = true;
            this.btnUnivSearch.UseStyleColors = true;
            this.btnUnivSearch.UseTileImage = true;
            this.btnUnivSearch.Click += new System.EventHandler(this.BtnUnivSearch_Click);
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UnivMajorGrid);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.btnMajorSearch);
            this.Controls.Add(this.btnUnivSearch);
            this.Controls.Add(this.txtMajorSearch);
            this.Controls.Add(this.txtUnivSearch);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.MaximizeBox = false;
            this.Name = "UniversityForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.AwardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnivMajorGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUnivSearch;
        private MetroFramework.Controls.MetroTile btnUnivSearch;
        private MetroFramework.Controls.MetroTextBox txtMajorSearch;
        private MetroFramework.Controls.MetroTile btnMajorSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel lblStudentName;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblStudentID;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroGrid UnivMajorGrid;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txtSelectMajor;
        private System.Windows.Forms.TextBox txtSelectUniv;
        private System.Windows.Forms.Label label1;
    }
}