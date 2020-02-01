namespace Academic_Manager
{
    partial class SchoolRecord
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.RecordGrid = new MetroFramework.Controls.MetroGrid();
            this.lblStudentName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lblStudentID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.btnCreateRecord = new MetroFramework.Controls.MetroTile();
            this.btnDeleteRecord = new MetroFramework.Controls.MetroTile();
            this.chartSchool = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.RecordGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSchool)).BeginInit();
            this.SuspendLayout();
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
            this.RecordGrid.EnableHeadersVisualStyles = false;
            this.RecordGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RecordGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordGrid.Location = new System.Drawing.Point(26, 128);
            this.RecordGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.RecordGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RecordGrid.RowTemplate.Height = 23;
            this.RecordGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecordGrid.Size = new System.Drawing.Size(594, 229);
            this.RecordGrid.Style = MetroFramework.MetroColorStyle.Silver;
            this.RecordGrid.TabIndex = 9;
            this.RecordGrid.UseStyleColors = true;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentName.Location = new System.Drawing.Point(233, 82);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(54, 20);
            this.lblStudentName.TabIndex = 5;
            this.lblStudentName.Text = "홍길동";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(184, 82);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(47, 20);
            this.metroLabel16.TabIndex = 6;
            this.metroLabel16.Text = "이름 :";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentID.Location = new System.Drawing.Point(88, 82);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(72, 20);
            this.lblStudentID.TabIndex = 7;
            this.lblStudentID.Text = "2014001";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(25, 82);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(63, 20);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "학생ID :";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel27.Location = new System.Drawing.Point(0, 9);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(111, 20);
            this.metroLabel27.TabIndex = 47;
            this.metroLabel27.Text = "성적관리(내신)";
            // 
            // btnCreateRecord
            // 
            this.btnCreateRecord.ActiveControl = null;
            this.btnCreateRecord.Location = new System.Drawing.Point(559, 82);
            this.btnCreateRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateRecord.Name = "btnCreateRecord";
            this.btnCreateRecord.Size = new System.Drawing.Size(27, 30);
            this.btnCreateRecord.Style = MetroFramework.MetroColorStyle.White;
            this.btnCreateRecord.TabIndex = 48;
            this.btnCreateRecord.TileImage = global::Academic_Manager.Properties.Resources.plus2;
            this.btnCreateRecord.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreateRecord.UseSelectable = true;
            this.btnCreateRecord.UseStyleColors = true;
            this.btnCreateRecord.UseTileImage = true;
            this.btnCreateRecord.Click += new System.EventHandler(this.BtnCreateRecord_Click);
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.ActiveControl = null;
            this.btnDeleteRecord.Location = new System.Drawing.Point(593, 82);
            this.btnDeleteRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(27, 30);
            this.btnDeleteRecord.Style = MetroFramework.MetroColorStyle.White;
            this.btnDeleteRecord.TabIndex = 48;
            this.btnDeleteRecord.TileImage = global::Academic_Manager.Properties.Resources.delete1;
            this.btnDeleteRecord.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteRecord.UseSelectable = true;
            this.btnDeleteRecord.UseStyleColors = true;
            this.btnDeleteRecord.UseTileImage = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.BtnDeleteRecord_Click);
            // 
            // chartSchool
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSchool.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSchool.Legends.Add(legend1);
            this.chartSchool.Location = new System.Drawing.Point(5, 425);
            this.chartSchool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartSchool.Name = "chartSchool";
            this.chartSchool.Size = new System.Drawing.Size(617, 300);
            this.chartSchool.TabIndex = 49;
            this.chartSchool.Text = "chart1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(26, 398);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(171, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "학년별 평균 성적 그래프";
            this.metroLabel1.UseStyleColors = true;
            // 
            // SchoolRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 742);
            this.Controls.Add(this.chartSchool);
            this.Controls.Add(this.btnCreateRecord);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.RecordGrid);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel5);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SchoolRecord";
            this.Padding = new System.Windows.Forms.Padding(23, 38, 23, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Load += new System.EventHandler(this.SchoolRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecordGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid RecordGrid;
        private MetroFramework.Controls.MetroLabel lblStudentName;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblStudentID;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroTile btnDeleteRecord;
        private MetroFramework.Controls.MetroTile btnCreateRecord;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSchool;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}