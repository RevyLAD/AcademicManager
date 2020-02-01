namespace Academic_Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.cmbFind = new MetroFramework.Controls.MetroComboBox();
            this.txtFindName = new MetroFramework.Controls.MetroTextBox();
            this.StudentGrid = new MetroFramework.Controls.MetroGrid();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.btnJobSearch = new MetroFramework.Controls.MetroButton();
            this.btnMajorSearch = new MetroFramework.Controls.MetroButton();
            this.txtCircle = new System.Windows.Forms.TextBox();
            this.txtHobby = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmbMain3 = new MetroFramework.Controls.MetroComboBox();
            this.cmbMain2 = new MetroFramework.Controls.MetroComboBox();
            this.cmbMain1 = new MetroFramework.Controls.MetroComboBox();
            this.txtJob = new MetroFramework.Controls.MetroTextBox();
            this.txtMajor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnSaveFile = new MetroFramework.Controls.MetroButton();
            this.btnOpenFile = new MetroFramework.Controls.MetroButton();
            this.txtPhone2 = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone3 = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPhone1 = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentName = new MetroFramework.Controls.MetroTextBox();
            this.txtStudentID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상담관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.성적관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직업정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tileUniversity = new MetroFramework.Controls.MetroTile();
            this.tileAllData = new MetroFramework.Controls.MetroTile();
            this.tileAward = new MetroFramework.Controls.MetroTile();
            this.tileConsult = new MetroFramework.Controls.MetroTile();
            this.tileScore = new MetroFramework.Controls.MetroTile();
            this.btnEcxel = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.tileUpdate = new MetroFramework.Controls.MetroTile();
            this.tileSave = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.학생별성적조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.성적순조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상담현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.대학리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.학과리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.직업리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressUserControl2 = new Academic_Manager.AddressUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 54);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tileUniversity);
            this.splitContainer1.Panel1.Controls.Add(this.tileAllData);
            this.splitContainer1.Panel1.Controls.Add(this.tileAward);
            this.splitContainer1.Panel1.Controls.Add(this.tileConsult);
            this.splitContainer1.Panel1.Controls.Add(this.tileScore);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 621);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1137, 621);
            this.splitContainer2.SplitterDistance = 532;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.btnEcxel);
            this.splitContainer4.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer4.Panel1.Controls.Add(this.btnCreate);
            this.splitContainer4.Panel1.Controls.Add(this.cmbFind);
            this.splitContainer4.Panel1.Controls.Add(this.txtFindName);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.StudentGrid);
            this.splitContainer4.Size = new System.Drawing.Size(532, 621);
            this.splitContainer4.SplitterDistance = 62;
            this.splitContainer4.TabIndex = 0;
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.ItemHeight = 23;
            this.cmbFind.Items.AddRange(new object[] {
            "이름"});
            this.cmbFind.Location = new System.Drawing.Point(3, 28);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(94, 29);
            this.cmbFind.TabIndex = 3;
            this.cmbFind.UseSelectable = true;
            // 
            // txtFindName
            // 
            // 
            // 
            // 
            this.txtFindName.CustomButton.Image = null;
            this.txtFindName.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtFindName.CustomButton.Name = "";
            this.txtFindName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFindName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFindName.CustomButton.TabIndex = 1;
            this.txtFindName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFindName.CustomButton.UseSelectable = true;
            this.txtFindName.CustomButton.Visible = false;
            this.txtFindName.Lines = new string[0];
            this.txtFindName.Location = new System.Drawing.Point(103, 28);
            this.txtFindName.MaxLength = 32767;
            this.txtFindName.Multiline = true;
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.PasswordChar = '\0';
            this.txtFindName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFindName.SelectedText = "";
            this.txtFindName.SelectionLength = 0;
            this.txtFindName.SelectionStart = 0;
            this.txtFindName.ShortcutsEnabled = true;
            this.txtFindName.Size = new System.Drawing.Size(131, 29);
            this.txtFindName.TabIndex = 2;
            this.txtFindName.UseSelectable = true;
            this.txtFindName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFindName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFindName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFindName_KeyPress);
            // 
            // StudentGrid
            // 
            this.StudentGrid.AllowUserToResizeRows = false;
            this.StudentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StudentGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentGrid.ColumnHeadersHeight = 15;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentGrid.EnableHeadersVisualStyles = false;
            this.StudentGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.StudentGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentGrid.Location = new System.Drawing.Point(0, 0);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentGrid.RowHeadersWidth = 51;
            this.StudentGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.StudentGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StudentGrid.RowTemplate.Height = 23;
            this.StudentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentGrid.Size = new System.Drawing.Size(532, 555);
            this.StudentGrid.Style = MetroFramework.MetroColorStyle.Silver;
            this.StudentGrid.TabIndex = 0;
            this.StudentGrid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.StudentGrid.UseCustomBackColor = true;
            this.StudentGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGrid_CellDoubleClick);
            this.StudentGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentGrid_CellMouseDown);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tileUpdate);
            this.splitContainer3.Panel1.Controls.Add(this.tileSave);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.metroTabControl1);
            this.splitContainer3.Size = new System.Drawing.Size(601, 621);
            this.splitContainer3.SplitterDistance = 30;
            this.splitContainer3.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(601, 587);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.addressUserControl2);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.metroLabel17);
            this.metroTabPage1.Controls.Add(this.metroLabel16);
            this.metroTabPage1.Controls.Add(this.metroLabel26);
            this.metroTabPage1.Controls.Add(this.metroLabel25);
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.btnSaveFile);
            this.metroTabPage1.Controls.Add(this.btnOpenFile);
            this.metroTabPage1.Controls.Add(this.txtPhone2);
            this.metroTabPage1.Controls.Add(this.txtPhone3);
            this.metroTabPage1.Controls.Add(this.pictureBox1);
            this.metroTabPage1.Controls.Add(this.txtEmail);
            this.metroTabPage1.Controls.Add(this.txtPhone1);
            this.metroTabPage1.Controls.Add(this.txtStudentName);
            this.metroTabPage1.Controls.Add(this.txtStudentID);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel14);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(593, 545);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "학생정보";
            this.metroTabPage1.UseCustomForeColor = true;
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroLabel20);
            this.panel1.Controls.Add(this.metroLabel24);
            this.panel1.Controls.Add(this.metroLabel23);
            this.panel1.Controls.Add(this.metroLabel19);
            this.panel1.Controls.Add(this.metroLabel22);
            this.panel1.Controls.Add(this.metroLabel21);
            this.panel1.Controls.Add(this.metroLabel18);
            this.panel1.Controls.Add(this.btnJobSearch);
            this.panel1.Controls.Add(this.btnMajorSearch);
            this.panel1.Controls.Add(this.txtCircle);
            this.panel1.Controls.Add(this.txtHobby);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.cmbMain3);
            this.panel1.Controls.Add(this.cmbMain2);
            this.panel1.Controls.Add(this.cmbMain1);
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.txtMajor);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.metroLabel12);
            this.panel1.Controls.Add(this.metroLabel11);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Location = new System.Drawing.Point(1, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 241);
            this.panel1.TabIndex = 18;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.Location = new System.Drawing.Point(5, 93);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(65, 19);
            this.metroLabel20.TabIndex = 16;
            this.metroLabel20.Text = "희망직업";
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel24.Location = new System.Drawing.Point(328, 93);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(51, 19);
            this.metroLabel24.TabIndex = 16;
            this.metroLabel24.Text = "동아리";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel23.Location = new System.Drawing.Point(328, 52);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(71, 19);
            this.metroLabel23.TabIndex = 16;
            this.metroLabel23.Text = "취미/특기";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(5, 52);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(65, 19);
            this.metroLabel19.TabIndex = 16;
            this.metroLabel19.Text = "희망학과";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.Location = new System.Drawing.Point(339, 9);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(65, 19);
            this.metroLabel22.TabIndex = 16;
            this.metroLabel22.Text = "학원등록";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel21.Location = new System.Drawing.Point(181, 9);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(65, 19);
            this.metroLabel21.TabIndex = 16;
            this.metroLabel21.Text = "보충수업";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel18.Location = new System.Drawing.Point(5, 9);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(65, 19);
            this.metroLabel18.TabIndex = 16;
            this.metroLabel18.Text = "야간학습";
            // 
            // btnJobSearch
            // 
            this.btnJobSearch.Enabled = false;
            this.btnJobSearch.Location = new System.Drawing.Point(267, 93);
            this.btnJobSearch.Name = "btnJobSearch";
            this.btnJobSearch.Size = new System.Drawing.Size(41, 23);
            this.btnJobSearch.TabIndex = 15;
            this.btnJobSearch.Text = "검색";
            this.btnJobSearch.UseSelectable = true;
            this.btnJobSearch.Click += new System.EventHandler(this.BtnJobSearch_Click);
            // 
            // btnMajorSearch
            // 
            this.btnMajorSearch.Enabled = false;
            this.btnMajorSearch.Location = new System.Drawing.Point(267, 52);
            this.btnMajorSearch.Name = "btnMajorSearch";
            this.btnMajorSearch.Size = new System.Drawing.Size(41, 23);
            this.btnMajorSearch.TabIndex = 15;
            this.btnMajorSearch.Text = "검색";
            this.btnMajorSearch.UseSelectable = true;
            this.btnMajorSearch.Click += new System.EventHandler(this.BtnMajorSearch_Click);
            // 
            // txtCircle
            // 
            this.txtCircle.Enabled = false;
            this.txtCircle.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCircle.Location = new System.Drawing.Point(405, 93);
            this.txtCircle.Multiline = true;
            this.txtCircle.Name = "txtCircle";
            this.txtCircle.Size = new System.Drawing.Size(174, 23);
            this.txtCircle.TabIndex = 14;
            // 
            // txtHobby
            // 
            this.txtHobby.Enabled = false;
            this.txtHobby.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtHobby.Location = new System.Drawing.Point(405, 52);
            this.txtHobby.Multiline = true;
            this.txtHobby.Name = "txtHobby";
            this.txtHobby.Size = new System.Drawing.Size(174, 23);
            this.txtHobby.TabIndex = 14;
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNote.Location = new System.Drawing.Point(7, 140);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(572, 95);
            this.txtNote.TabIndex = 14;
            // 
            // cmbMain3
            // 
            this.cmbMain3.Enabled = false;
            this.cmbMain3.FormattingEnabled = true;
            this.cmbMain3.ItemHeight = 23;
            this.cmbMain3.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmbMain3.Location = new System.Drawing.Point(405, 9);
            this.cmbMain3.Name = "cmbMain3";
            this.cmbMain3.Size = new System.Drawing.Size(50, 29);
            this.cmbMain3.TabIndex = 9;
            this.cmbMain3.UseSelectable = true;
            // 
            // cmbMain2
            // 
            this.cmbMain2.Enabled = false;
            this.cmbMain2.FormattingEnabled = true;
            this.cmbMain2.ItemHeight = 23;
            this.cmbMain2.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmbMain2.Location = new System.Drawing.Point(247, 9);
            this.cmbMain2.Name = "cmbMain2";
            this.cmbMain2.Size = new System.Drawing.Size(50, 29);
            this.cmbMain2.TabIndex = 8;
            this.cmbMain2.UseSelectable = true;
            // 
            // cmbMain1
            // 
            this.cmbMain1.Enabled = false;
            this.cmbMain1.FormattingEnabled = true;
            this.cmbMain1.ItemHeight = 23;
            this.cmbMain1.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmbMain1.Location = new System.Drawing.Point(92, 9);
            this.cmbMain1.Name = "cmbMain1";
            this.cmbMain1.Size = new System.Drawing.Size(50, 29);
            this.cmbMain1.TabIndex = 7;
            this.cmbMain1.UseSelectable = true;
            // 
            // txtJob
            // 
            // 
            // 
            // 
            this.txtJob.CustomButton.Image = null;
            this.txtJob.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtJob.CustomButton.Name = "";
            this.txtJob.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtJob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJob.CustomButton.TabIndex = 1;
            this.txtJob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJob.CustomButton.UseSelectable = true;
            this.txtJob.CustomButton.Visible = false;
            this.txtJob.Enabled = false;
            this.txtJob.Lines = new string[0];
            this.txtJob.Location = new System.Drawing.Point(92, 93);
            this.txtJob.MaxLength = 32767;
            this.txtJob.Name = "txtJob";
            this.txtJob.PasswordChar = '\0';
            this.txtJob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJob.SelectedText = "";
            this.txtJob.SelectionLength = 0;
            this.txtJob.SelectionStart = 0;
            this.txtJob.ShortcutsEnabled = true;
            this.txtJob.Size = new System.Drawing.Size(169, 23);
            this.txtJob.TabIndex = 11;
            this.txtJob.UseSelectable = true;
            this.txtJob.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJob.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMajor
            // 
            // 
            // 
            // 
            this.txtMajor.CustomButton.Image = null;
            this.txtMajor.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtMajor.CustomButton.Name = "";
            this.txtMajor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMajor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMajor.CustomButton.TabIndex = 1;
            this.txtMajor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMajor.CustomButton.UseSelectable = true;
            this.txtMajor.CustomButton.Visible = false;
            this.txtMajor.Enabled = false;
            this.txtMajor.Lines = new string[0];
            this.txtMajor.Location = new System.Drawing.Point(92, 52);
            this.txtMajor.MaxLength = 32767;
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.PasswordChar = '\0';
            this.txtMajor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMajor.SelectedText = "";
            this.txtMajor.SelectionLength = 0;
            this.txtMajor.SelectionStart = 0;
            this.txtMajor.ShortcutsEnabled = true;
            this.txtMajor.Size = new System.Drawing.Size(169, 23);
            this.txtMajor.TabIndex = 11;
            this.txtMajor.UseSelectable = true;
            this.txtMajor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMajor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(187, 9);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(0, 0);
            this.metroLabel8.TabIndex = 2;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(339, 52);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(0, 0);
            this.metroLabel12.TabIndex = 2;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(339, 97);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(0, 0);
            this.metroLabel11.TabIndex = 2;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(5, 93);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(0, 0);
            this.metroLabel10.TabIndex = 2;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(5, 52);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(0, 0);
            this.metroLabel9.TabIndex = 2;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(5, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 2;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(352, 9);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 2;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(4, 144);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(51, 19);
            this.metroLabel17.TabIndex = 16;
            this.metroLabel17.Text = "이메일";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(4, 103);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(51, 19);
            this.metroLabel16.TabIndex = 16;
            this.metroLabel16.Text = "휴대폰";
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Enabled = false;
            this.metroLabel26.Location = new System.Drawing.Point(213, 106);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(15, 19);
            this.metroLabel26.TabIndex = 16;
            this.metroLabel26.Text = "-";
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Enabled = false;
            this.metroLabel25.Location = new System.Drawing.Point(144, 106);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(15, 19);
            this.metroLabel25.TabIndex = 16;
            this.metroLabel25.Text = "-";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(4, 62);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(43, 19);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel15.TabIndex = 16;
            this.metroLabel15.Text = "*이름";
            this.metroLabel15.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(4, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "*학생ID";
            this.metroLabel5.UseStyleColors = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Enabled = false;
            this.btnSaveFile.Location = new System.Drawing.Point(519, 222);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(67, 23);
            this.btnSaveFile.TabIndex = 15;
            this.btnSaveFile.Text = "저장";
            this.btnSaveFile.UseSelectable = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Enabled = false;
            this.btnOpenFile.Location = new System.Drawing.Point(434, 222);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(67, 23);
            this.btnOpenFile.TabIndex = 15;
            this.btnOpenFile.Text = "파일선택";
            this.btnOpenFile.UseSelectable = true;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // txtPhone2
            // 
            // 
            // 
            // 
            this.txtPhone2.CustomButton.Image = null;
            this.txtPhone2.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.txtPhone2.CustomButton.Name = "";
            this.txtPhone2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone2.CustomButton.TabIndex = 1;
            this.txtPhone2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone2.CustomButton.UseSelectable = true;
            this.txtPhone2.CustomButton.Visible = false;
            this.txtPhone2.Enabled = false;
            this.txtPhone2.Lines = new string[0];
            this.txtPhone2.Location = new System.Drawing.Point(160, 103);
            this.txtPhone2.MaxLength = 32767;
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.PasswordChar = '\0';
            this.txtPhone2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone2.SelectedText = "";
            this.txtPhone2.SelectionLength = 0;
            this.txtPhone2.SelectionStart = 0;
            this.txtPhone2.ShortcutsEnabled = true;
            this.txtPhone2.Size = new System.Drawing.Size(51, 23);
            this.txtPhone2.TabIndex = 3;
            this.txtPhone2.UseSelectable = true;
            this.txtPhone2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone3
            // 
            // 
            // 
            // 
            this.txtPhone3.CustomButton.Image = null;
            this.txtPhone3.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.txtPhone3.CustomButton.Name = "";
            this.txtPhone3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone3.CustomButton.TabIndex = 1;
            this.txtPhone3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone3.CustomButton.UseSelectable = true;
            this.txtPhone3.CustomButton.Visible = false;
            this.txtPhone3.Enabled = false;
            this.txtPhone3.Lines = new string[0];
            this.txtPhone3.Location = new System.Drawing.Point(229, 104);
            this.txtPhone3.MaxLength = 32767;
            this.txtPhone3.Name = "txtPhone3";
            this.txtPhone3.PasswordChar = '\0';
            this.txtPhone3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone3.SelectedText = "";
            this.txtPhone3.SelectionLength = 0;
            this.txtPhone3.SelectionStart = 0;
            this.txtPhone3.ShortcutsEnabled = true;
            this.txtPhone3.Size = new System.Drawing.Size(51, 23);
            this.txtPhone3.TabIndex = 4;
            this.txtPhone3.UseSelectable = true;
            this.txtPhone3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Enabled = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(90, 144);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(190, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhone1
            // 
            // 
            // 
            // 
            this.txtPhone1.CustomButton.Image = null;
            this.txtPhone1.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.txtPhone1.CustomButton.Name = "";
            this.txtPhone1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone1.CustomButton.TabIndex = 1;
            this.txtPhone1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone1.CustomButton.UseSelectable = true;
            this.txtPhone1.CustomButton.Visible = false;
            this.txtPhone1.Enabled = false;
            this.txtPhone1.Lines = new string[0];
            this.txtPhone1.Location = new System.Drawing.Point(90, 104);
            this.txtPhone1.MaxLength = 32767;
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.PasswordChar = '\0';
            this.txtPhone1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone1.SelectedText = "";
            this.txtPhone1.SelectionLength = 0;
            this.txtPhone1.SelectionStart = 0;
            this.txtPhone1.ShortcutsEnabled = true;
            this.txtPhone1.Size = new System.Drawing.Size(51, 23);
            this.txtPhone1.TabIndex = 2;
            this.txtPhone1.UseSelectable = true;
            this.txtPhone1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentName
            // 
            // 
            // 
            // 
            this.txtStudentName.CustomButton.Image = null;
            this.txtStudentName.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtStudentName.CustomButton.Name = "";
            this.txtStudentName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentName.CustomButton.TabIndex = 1;
            this.txtStudentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentName.CustomButton.UseSelectable = true;
            this.txtStudentName.CustomButton.Visible = false;
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Lines = new string[0];
            this.txtStudentName.Location = new System.Drawing.Point(90, 62);
            this.txtStudentName.MaxLength = 32767;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.PasswordChar = '\0';
            this.txtStudentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentName.SelectedText = "";
            this.txtStudentName.SelectionLength = 0;
            this.txtStudentName.SelectionStart = 0;
            this.txtStudentName.ShortcutsEnabled = true;
            this.txtStudentName.Size = new System.Drawing.Size(102, 23);
            this.txtStudentName.TabIndex = 1;
            this.txtStudentName.UseSelectable = true;
            this.txtStudentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStudentID
            // 
            // 
            // 
            // 
            this.txtStudentID.CustomButton.Image = null;
            this.txtStudentID.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtStudentID.CustomButton.Name = "";
            this.txtStudentID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStudentID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStudentID.CustomButton.TabIndex = 1;
            this.txtStudentID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStudentID.CustomButton.UseSelectable = true;
            this.txtStudentID.CustomButton.Visible = false;
            this.txtStudentID.Enabled = false;
            this.txtStudentID.Lines = new string[0];
            this.txtStudentID.Location = new System.Drawing.Point(90, 21);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.SelectionLength = 0;
            this.txtStudentID.SelectionStart = 0;
            this.txtStudentID.ShortcutsEnabled = true;
            this.txtStudentID.Size = new System.Drawing.Size(102, 23);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.UseSelectable = true;
            this.txtStudentID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStudentID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 144);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 2;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Enabled = false;
            this.metroLabel14.Location = new System.Drawing.Point(212, 104);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(0, 0);
            this.metroLabel14.TabIndex = 2;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Enabled = false;
            this.metroLabel13.Location = new System.Drawing.Point(144, 104);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(0, 0);
            this.metroLabel13.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수정ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(123, 48);
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.수정ToolStripMenuItem.Text = "정보수정";
            this.수정ToolStripMenuItem.Click += new System.EventHandler(this.수정ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // 상담관리ToolStripMenuItem
            // 
            this.상담관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상담현황ToolStripMenuItem});
            this.상담관리ToolStripMenuItem.Name = "상담관리ToolStripMenuItem";
            this.상담관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.상담관리ToolStripMenuItem.Text = "상담목록";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.대학리스트ToolStripMenuItem,
            this.학과리스트ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.설정ToolStripMenuItem.Text = "대학정보";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.성적관리ToolStripMenuItem,
            this.상담관리ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.직업정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 성적관리ToolStripMenuItem
            // 
            this.성적관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.학생별성적조회ToolStripMenuItem,
            this.성적순조회ToolStripMenuItem});
            this.성적관리ToolStripMenuItem.Name = "성적관리ToolStripMenuItem";
            this.성적관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.성적관리ToolStripMenuItem.Text = "성적조회";
            // 
            // 직업정보ToolStripMenuItem
            // 
            this.직업정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.직업리스트ToolStripMenuItem});
            this.직업정보ToolStripMenuItem.Name = "직업정보ToolStripMenuItem";
            this.직업정보ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.직업정보ToolStripMenuItem.Text = "직업정보";
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel27.Location = new System.Drawing.Point(1062, 7);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(125, 19);
            this.metroLabel27.TabIndex = 46;
            this.metroLabel27.Text = "학사관리 프로그램";
            // 
            // tileUniversity
            // 
            this.tileUniversity.ActiveControl = null;
            this.tileUniversity.Location = new System.Drawing.Point(3, 398);
            this.tileUniversity.Name = "tileUniversity";
            this.tileUniversity.Size = new System.Drawing.Size(100, 109);
            this.tileUniversity.Style = MetroFramework.MetroColorStyle.Black;
            this.tileUniversity.TabIndex = 2;
            this.tileUniversity.Text = "대입분석";
            this.tileUniversity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileUniversity.TileImage = global::Academic_Manager.Properties.Resources.school;
            this.tileUniversity.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileUniversity.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileUniversity.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileUniversity.UseSelectable = true;
            this.tileUniversity.UseStyleColors = true;
            this.tileUniversity.UseTileImage = true;
            this.tileUniversity.Click += new System.EventHandler(this.TileUniversity_Click);
            // 
            // tileAllData
            // 
            this.tileAllData.ActiveControl = null;
            this.tileAllData.Location = new System.Drawing.Point(3, 511);
            this.tileAllData.Name = "tileAllData";
            this.tileAllData.Size = new System.Drawing.Size(100, 109);
            this.tileAllData.Style = MetroFramework.MetroColorStyle.Black;
            this.tileAllData.TabIndex = 2;
            this.tileAllData.Text = "종합데이터";
            this.tileAllData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileAllData.TileImage = global::Academic_Manager.Properties.Resources.presentation;
            this.tileAllData.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileAllData.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileAllData.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileAllData.UseSelectable = true;
            this.tileAllData.UseStyleColors = true;
            this.tileAllData.UseTileImage = true;
            this.tileAllData.Click += new System.EventHandler(this.TileAllData_Click);
            // 
            // tileAward
            // 
            this.tileAward.ActiveControl = null;
            this.tileAward.Location = new System.Drawing.Point(3, 284);
            this.tileAward.Name = "tileAward";
            this.tileAward.Size = new System.Drawing.Size(100, 109);
            this.tileAward.Style = MetroFramework.MetroColorStyle.Black;
            this.tileAward.TabIndex = 2;
            this.tileAward.Text = "수상내역관리";
            this.tileAward.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileAward.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAward.TileImage")));
            this.tileAward.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileAward.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileAward.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileAward.UseSelectable = true;
            this.tileAward.UseStyleColors = true;
            this.tileAward.UseTileImage = true;
            this.tileAward.Click += new System.EventHandler(this.TileAward_Click);
            // 
            // tileConsult
            // 
            this.tileConsult.ActiveControl = null;
            this.tileConsult.Location = new System.Drawing.Point(3, 172);
            this.tileConsult.Name = "tileConsult";
            this.tileConsult.Size = new System.Drawing.Size(100, 107);
            this.tileConsult.Style = MetroFramework.MetroColorStyle.Black;
            this.tileConsult.TabIndex = 1;
            this.tileConsult.Text = "상담관리";
            this.tileConsult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileConsult.TileImage = global::Academic_Manager.Properties.Resources.consulting;
            this.tileConsult.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileConsult.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileConsult.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileConsult.UseSelectable = true;
            this.tileConsult.UseStyleColors = true;
            this.tileConsult.UseTileImage = true;
            this.tileConsult.Click += new System.EventHandler(this.TileConsult_Click);
            // 
            // tileScore
            // 
            this.tileScore.ActiveControl = null;
            this.tileScore.Location = new System.Drawing.Point(3, 66);
            this.tileScore.Name = "tileScore";
            this.tileScore.Size = new System.Drawing.Size(100, 100);
            this.tileScore.Style = MetroFramework.MetroColorStyle.Black;
            this.tileScore.TabIndex = 0;
            this.tileScore.Text = "성적관리";
            this.tileScore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileScore.TileImage = ((System.Drawing.Image)(resources.GetObject("tileScore.TileImage")));
            this.tileScore.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tileScore.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileScore.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileScore.UseSelectable = true;
            this.tileScore.UseStyleColors = true;
            this.tileScore.UseTileImage = true;
            this.tileScore.Click += new System.EventHandler(this.TileScore_Click);
            // 
            // btnEcxel
            // 
            this.btnEcxel.ActiveControl = null;
            this.btnEcxel.Location = new System.Drawing.Point(459, 25);
            this.btnEcxel.Name = "btnEcxel";
            this.btnEcxel.Size = new System.Drawing.Size(32, 32);
            this.btnEcxel.Style = MetroFramework.MetroColorStyle.White;
            this.btnEcxel.TabIndex = 54;
            this.btnEcxel.TileImage = global::Academic_Manager.Properties.Resources.Excel2;
            this.btnEcxel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEcxel.UseSelectable = true;
            this.btnEcxel.UseStyleColors = true;
            this.btnEcxel.UseTileImage = true;
            this.btnEcxel.Click += new System.EventHandler(this.BtnEcxel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.Location = new System.Drawing.Point(240, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.White;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.TileImage = global::Academic_Manager.Properties.Resources.loupe;
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseStyleColors = true;
            this.btnSearch.UseTileImage = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(497, 25);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(32, 32);
            this.btnCreate.Style = MetroFramework.MetroColorStyle.White;
            this.btnCreate.TabIndex = 4;
            this.btnCreate.TileImage = global::Academic_Manager.Properties.Resources.new_user;
            this.btnCreate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.UseStyleColors = true;
            this.btnCreate.UseTileImage = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // tileUpdate
            // 
            this.tileUpdate.ActiveControl = null;
            this.tileUpdate.Location = new System.Drawing.Point(537, 3);
            this.tileUpdate.Name = "tileUpdate";
            this.tileUpdate.Size = new System.Drawing.Size(24, 24);
            this.tileUpdate.Style = MetroFramework.MetroColorStyle.White;
            this.tileUpdate.TabIndex = 4;
            this.tileUpdate.TileImage = global::Academic_Manager.Properties.Resources.pencil1;
            this.tileUpdate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUpdate.UseSelectable = true;
            this.tileUpdate.UseStyleColors = true;
            this.tileUpdate.UseTileImage = true;
            this.tileUpdate.Click += new System.EventHandler(this.TileUpdate_Click);
            // 
            // tileSave
            // 
            this.tileSave.ActiveControl = null;
            this.tileSave.Location = new System.Drawing.Point(566, 3);
            this.tileSave.Name = "tileSave";
            this.tileSave.Size = new System.Drawing.Size(24, 24);
            this.tileSave.Style = MetroFramework.MetroColorStyle.White;
            this.tileSave.TabIndex = 4;
            this.tileSave.TileImage = global::Academic_Manager.Properties.Resources.save1;
            this.tileSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSave.UseSelectable = true;
            this.tileSave.UseStyleColors = true;
            this.tileSave.UseTileImage = true;
            this.tileSave.Click += new System.EventHandler(this.TileSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(434, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 184);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // 학생별성적조회ToolStripMenuItem
            // 
            this.학생별성적조회ToolStripMenuItem.Image = global::Academic_Manager.Properties.Resources.report;
            this.학생별성적조회ToolStripMenuItem.Name = "학생별성적조회ToolStripMenuItem";
            this.학생별성적조회ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.학생별성적조회ToolStripMenuItem.Text = "학생별 성적조회";
            this.학생별성적조회ToolStripMenuItem.Click += new System.EventHandler(this.학생별성적조회ToolStripMenuItem_Click);
            // 
            // 성적순조회ToolStripMenuItem
            // 
            this.성적순조회ToolStripMenuItem.Image = global::Academic_Manager.Properties.Resources.grades;
            this.성적순조회ToolStripMenuItem.Name = "성적순조회ToolStripMenuItem";
            this.성적순조회ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.성적순조회ToolStripMenuItem.Text = "성적순 조회";
            this.성적순조회ToolStripMenuItem.Click += new System.EventHandler(this.성적순조회ToolStripMenuItem_Click);
            // 
            // 상담현황ToolStripMenuItem
            // 
            this.상담현황ToolStripMenuItem.Image = global::Academic_Manager.Properties.Resources.consulting2;
            this.상담현황ToolStripMenuItem.Name = "상담현황ToolStripMenuItem";
            this.상담현황ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.상담현황ToolStripMenuItem.Text = "상담현황";
            this.상담현황ToolStripMenuItem.Click += new System.EventHandler(this.상담현황ToolStripMenuItem_Click);
            // 
            // 대학리스트ToolStripMenuItem
            // 
            this.대학리스트ToolStripMenuItem.Image = global::Academic_Manager.Properties.Resources.university;
            this.대학리스트ToolStripMenuItem.Name = "대학리스트ToolStripMenuItem";
            this.대학리스트ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.대학리스트ToolStripMenuItem.Text = "대학리스트";
            this.대학리스트ToolStripMenuItem.Click += new System.EventHandler(this.대학리스트ToolStripMenuItem_Click);
            // 
            // 학과리스트ToolStripMenuItem
            // 
            this.학과리스트ToolStripMenuItem.Image = global::Academic_Manager.Properties.Resources.scholarship;
            this.학과리스트ToolStripMenuItem.Name = "학과리스트ToolStripMenuItem";
            this.학과리스트ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.학과리스트ToolStripMenuItem.Text = "학과리스트";
            this.학과리스트ToolStripMenuItem.Click += new System.EventHandler(this.학과리스트ToolStripMenuItem_Click);
            // 
            // 직업리스트ToolStripMenuItem
            // 
            this.직업리스트ToolStripMenuItem.Image = global::Academic_Manager.Properties.Resources.doctor;
            this.직업리스트ToolStripMenuItem.Name = "직업리스트ToolStripMenuItem";
            this.직업리스트ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.직업리스트ToolStripMenuItem.Text = "직업리스트";
            this.직업리스트ToolStripMenuItem.Click += new System.EventHandler(this.직업리스트ToolStripMenuItem_Click);
            // 
            // addressUserControl2
            // 
            this.addressUserControl2.Address1 = "";
            this.addressUserControl2.Address2 = "";
            this.addressUserControl2.BackColor = System.Drawing.Color.White;
            this.addressUserControl2.Enabled = false;
            this.addressUserControl2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addressUserControl2.Location = new System.Drawing.Point(-6, 174);
            this.addressUserControl2.Margin = new System.Windows.Forms.Padding(4);
            this.addressUserControl2.Name = "addressUserControl2";
            this.addressUserControl2.Size = new System.Drawing.Size(408, 116);
            this.addressUserControl2.TabIndex = 19;
            this.addressUserControl2.Zipcode = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1266, 685);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private MetroFramework.Controls.MetroGrid StudentGrid;
        private MetroFramework.Controls.MetroTile tileAward;
        private MetroFramework.Controls.MetroTile tileConsult;
        private MetroFramework.Controls.MetroTile tileScore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnOpenFile;
        private AddressUserControl addressUserControl1;
        private System.Windows.Forms.TextBox txtNote;
        private MetroFramework.Controls.MetroComboBox cmbMain3;
        private MetroFramework.Controls.MetroComboBox cmbMain2;
        private MetroFramework.Controls.MetroComboBox cmbMain1;
        private MetroFramework.Controls.MetroTextBox txtPhone2;
        private MetroFramework.Controls.MetroTextBox txtPhone3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPhone1;
        private MetroFramework.Controls.MetroTextBox txtStudentName;
        private MetroFramework.Controls.MetroTextBox txtStudentID;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroComboBox cmbFind;
        private MetroFramework.Controls.MetroTextBox txtFindName;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 성적관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상담관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroButton btnSaveFile;
        private MetroFramework.Controls.MetroTile tileAllData;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroTile tileUpdate;
        private MetroFramework.Controls.MetroTile tileSave;
        private MetroFramework.Controls.MetroTile tileUniversity;
        private System.Windows.Forms.ToolStripMenuItem 대학리스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 학과리스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 학생별성적조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 성적순조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상담현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직업정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 직업리스트ToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnJobSearch;
        private MetroFramework.Controls.MetroButton btnMajorSearch;
        private MetroFramework.Controls.MetroTextBox txtJob;
        private MetroFramework.Controls.MetroTextBox txtMajor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCircle;
        private System.Windows.Forms.TextBox txtHobby;
        private AddressUserControl addressUserControl2;
        private MetroFramework.Controls.MetroTile btnEcxel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

