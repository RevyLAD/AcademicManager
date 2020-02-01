namespace Academic_Manager
{
    partial class RecordByScoreForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.cmbSemester = new MetroFramework.Controls.MetroComboBox();
            this.lblSemester = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbGrade = new MetroFramework.Controls.MetroComboBox();
            this.radiobtnMock = new MetroFramework.Controls.MetroRadioButton();
            this.radiobtnSchool = new MetroFramework.Controls.MetroRadioButton();
            this.RecordGrid = new MetroFramework.Controls.MetroGrid();
            this.btnEcxel = new MetroFramework.Controls.MetroTile();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 552);
            this.panel1.TabIndex = 49;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RecordGrid);
            this.splitContainer1.Size = new System.Drawing.Size(605, 552);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.cmbSemester);
            this.panel2.Controls.Add(this.lblSemester);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.cmbGrade);
            this.panel2.Controls.Add(this.radiobtnMock);
            this.panel2.Controls.Add(this.radiobtnSchool);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 42);
            this.panel2.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.Location = new System.Drawing.Point(567, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.White;
            this.btnSearch.TabIndex = 49;
            this.btnSearch.TileImage = global::Academic_Manager.Properties.Resources.loupe;
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseStyleColors = true;
            this.btnSearch.UseTileImage = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.ItemHeight = 23;
            this.cmbSemester.Location = new System.Drawing.Point(471, 12);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(47, 29);
            this.cmbSemester.TabIndex = 3;
            this.cmbSemester.UseSelectable = true;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSemester.Location = new System.Drawing.Point(524, 16);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(37, 19);
            this.lblSemester.TabIndex = 48;
            this.lblSemester.Text = "학기";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(428, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Text = "학년";
            // 
            // cmbGrade
            // 
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.ItemHeight = 23;
            this.cmbGrade.Location = new System.Drawing.Point(375, 12);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(47, 29);
            this.cmbGrade.TabIndex = 3;
            this.cmbGrade.UseSelectable = true;
            // 
            // radiobtnMock
            // 
            this.radiobtnMock.AutoSize = true;
            this.radiobtnMock.Location = new System.Drawing.Point(66, 15);
            this.radiobtnMock.Name = "radiobtnMock";
            this.radiobtnMock.Size = new System.Drawing.Size(71, 15);
            this.radiobtnMock.TabIndex = 1;
            this.radiobtnMock.Text = "모의고사";
            this.radiobtnMock.UseSelectable = true;
            // 
            // radiobtnSchool
            // 
            this.radiobtnSchool.AutoSize = true;
            this.radiobtnSchool.Location = new System.Drawing.Point(5, 15);
            this.radiobtnSchool.Name = "radiobtnSchool";
            this.radiobtnSchool.Size = new System.Drawing.Size(47, 15);
            this.radiobtnSchool.TabIndex = 2;
            this.radiobtnSchool.Text = "내신";
            this.radiobtnSchool.UseSelectable = true;
            this.radiobtnSchool.CheckedChanged += new System.EventHandler(this.RadiobtnSchool_CheckedChanged);
            // 
            // RecordGrid
            // 
            this.RecordGrid.AllowUserToResizeRows = false;
            this.RecordGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RecordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RecordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RecordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordGrid.EnableHeadersVisualStyles = false;
            this.RecordGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RecordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordGrid.Location = new System.Drawing.Point(0, 0);
            this.RecordGrid.Name = "RecordGrid";
            this.RecordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RecordGrid.RowHeadersWidth = 51;
            this.RecordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.RecordGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RecordGrid.RowTemplate.Height = 23;
            this.RecordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecordGrid.Size = new System.Drawing.Size(605, 506);
            this.RecordGrid.Style = MetroFramework.MetroColorStyle.Silver;
            this.RecordGrid.TabIndex = 1;
            // 
            // btnEcxel
            // 
            this.btnEcxel.ActiveControl = null;
            this.btnEcxel.Location = new System.Drawing.Point(156, 20);
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
            // RecordByScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 632);
            this.Controls.Add(this.btnEcxel);
            this.Controls.Add(this.panel1);
            this.Name = "RecordByScoreForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "성적순 조회";
            this.Load += new System.EventHandler(this.RecordByScoreForm_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroRadioButton radiobtnMock;
        private MetroFramework.Controls.MetroRadioButton radiobtnSchool;
        private MetroFramework.Controls.MetroGrid RecordGrid;
        private MetroFramework.Controls.MetroComboBox cmbSemester;
        private MetroFramework.Controls.MetroLabel lblSemester;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbGrade;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroTile btnEcxel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}