namespace Academic_Manager
{
    partial class UniversityListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbFind = new MetroFramework.Controls.MetroComboBox();
            this.txtFindName = new MetroFramework.Controls.MetroTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UniversityGrid = new MetroFramework.Controls.MetroGrid();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnEcxel = new MetroFramework.Controls.MetroTile();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversityGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(541, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(169, 15);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "※더블클릭시 홈페이지로 이동";
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.ItemHeight = 23;
            this.cmbFind.Items.AddRange(new object[] {
            "이름"});
            this.cmbFind.Location = new System.Drawing.Point(3, 10);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(60, 29);
            this.cmbFind.TabIndex = 51;
            this.cmbFind.UseSelectable = true;
            // 
            // txtFindName
            // 
            // 
            // 
            // 
            this.txtFindName.CustomButton.Image = null;
            this.txtFindName.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txtFindName.CustomButton.Name = "";
            this.txtFindName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFindName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFindName.CustomButton.TabIndex = 1;
            this.txtFindName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFindName.CustomButton.UseSelectable = true;
            this.txtFindName.CustomButton.Visible = false;
            this.txtFindName.Lines = new string[0];
            this.txtFindName.Location = new System.Drawing.Point(69, 10);
            this.txtFindName.MaxLength = 32767;
            this.txtFindName.Multiline = true;
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.PasswordChar = '\0';
            this.txtFindName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFindName.SelectedText = "";
            this.txtFindName.SelectionLength = 0;
            this.txtFindName.SelectionStart = 0;
            this.txtFindName.ShortcutsEnabled = true;
            this.txtFindName.Size = new System.Drawing.Size(154, 29);
            this.txtFindName.TabIndex = 49;
            this.txtFindName.UseSelectable = true;
            this.txtFindName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFindName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFindName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFindName_KeyPress);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmbFind);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFindName);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.UniversityGrid);
            this.splitContainer1.Size = new System.Drawing.Size(716, 633);
            this.splitContainer1.SplitterDistance = 42;
            this.splitContainer1.TabIndex = 52;
            // 
            // UniversityGrid
            // 
            this.UniversityGrid.AllowUserToResizeRows = false;
            this.UniversityGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UniversityGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UniversityGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UniversityGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UniversityGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.UniversityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UniversityGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.UniversityGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UniversityGrid.EnableHeadersVisualStyles = false;
            this.UniversityGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UniversityGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UniversityGrid.Location = new System.Drawing.Point(0, 0);
            this.UniversityGrid.Name = "UniversityGrid";
            this.UniversityGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UniversityGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.UniversityGrid.RowHeadersWidth = 51;
            this.UniversityGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.UniversityGrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.UniversityGrid.RowTemplate.Height = 23;
            this.UniversityGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UniversityGrid.Size = new System.Drawing.Size(716, 587);
            this.UniversityGrid.Style = MetroFramework.MetroColorStyle.Silver;
            this.UniversityGrid.TabIndex = 2;
            this.UniversityGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UniversityGrid_CellDoubleClick);
            // 
            // btnEcxel
            // 
            this.btnEcxel.ActiveControl = null;
            this.btnEcxel.Location = new System.Drawing.Point(125, 19);
            this.btnEcxel.Name = "btnEcxel";
            this.btnEcxel.Size = new System.Drawing.Size(32, 32);
            this.btnEcxel.Style = MetroFramework.MetroColorStyle.White;
            this.btnEcxel.TabIndex = 50;
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
            this.btnSearch.Location = new System.Drawing.Point(229, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.White;
            this.btnSearch.TabIndex = 50;
            this.btnSearch.TileImage = global::Academic_Manager.Properties.Resources.loupe;
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseStyleColors = true;
            this.btnSearch.UseTileImage = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // UniversityListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 713);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnEcxel);
            this.MaximizeBox = false;
            this.Name = "UniversityListForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "대학정보";
            this.Load += new System.EventHandler(this.UniversityListForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UniversityGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbFind;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroTextBox txtFindName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroGrid UniversityGrid;
        private MetroFramework.Controls.MetroTile btnEcxel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}