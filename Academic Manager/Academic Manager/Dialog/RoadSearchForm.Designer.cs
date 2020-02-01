namespace Academic_Manager
{
    partial class RoadSearchForm
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
            this.txtJibunAddr2 = new System.Windows.Forms.TextBox();
            this.txtJibunZipCode = new System.Windows.Forms.TextBox();
            this.txtJibunAddr1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRoadAddr2 = new System.Windows.Forms.TextBox();
            this.txtRoadZipCode = new System.Windows.Forms.TextBox();
            this.txtRoadAddr1 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRoad = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnJibun = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJibunAddr2
            // 
            this.txtJibunAddr2.Location = new System.Drawing.Point(144, 492);
            this.txtJibunAddr2.Name = "txtJibunAddr2";
            this.txtJibunAddr2.Size = new System.Drawing.Size(308, 21);
            this.txtJibunAddr2.TabIndex = 17;
            // 
            // txtJibunZipCode
            // 
            this.txtJibunZipCode.Location = new System.Drawing.Point(26, 492);
            this.txtJibunZipCode.Name = "txtJibunZipCode";
            this.txtJibunZipCode.Size = new System.Drawing.Size(112, 21);
            this.txtJibunZipCode.TabIndex = 18;
            // 
            // txtJibunAddr1
            // 
            this.txtJibunAddr1.Location = new System.Drawing.Point(26, 463);
            this.txtJibunAddr1.Name = "txtJibunAddr1";
            this.txtJibunAddr1.Size = new System.Drawing.Size(426, 21);
            this.txtJibunAddr1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(507, 269);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // txtRoadAddr2
            // 
            this.txtRoadAddr2.Location = new System.Drawing.Point(144, 427);
            this.txtRoadAddr2.Name = "txtRoadAddr2";
            this.txtRoadAddr2.Size = new System.Drawing.Size(308, 21);
            this.txtRoadAddr2.TabIndex = 9;
            // 
            // txtRoadZipCode
            // 
            this.txtRoadZipCode.Location = new System.Drawing.Point(26, 427);
            this.txtRoadZipCode.Name = "txtRoadZipCode";
            this.txtRoadZipCode.Size = new System.Drawing.Size(112, 21);
            this.txtRoadZipCode.TabIndex = 10;
            // 
            // txtRoadAddr1
            // 
            this.txtRoadAddr1.Location = new System.Drawing.Point(26, 398);
            this.txtRoadAddr1.Name = "txtRoadAddr1";
            this.txtRoadAddr1.Size = new System.Drawing.Size(426, 21);
            this.txtRoadAddr1.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(173, 80);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "도로명(지번) 주소 검색";
            // 
            // btnSearch
            // 
            this.btnSearch.Depth = 0;
            this.btnSearch.Location = new System.Drawing.Point(445, 80);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Primary = true;
            this.btnSearch.Size = new System.Drawing.Size(88, 21);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnRoad
            // 
            this.btnRoad.Depth = 0;
            this.btnRoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoad.Location = new System.Drawing.Point(458, 397);
            this.btnRoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRoad.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Primary = true;
            this.btnRoad.Size = new System.Drawing.Size(88, 51);
            this.btnRoad.TabIndex = 20;
            this.btnRoad.Text = "도로명주소 선택";
            this.btnRoad.UseVisualStyleBackColor = true;
            this.btnRoad.Click += new System.EventHandler(this.BtnRoad_Click);
            // 
            // btnJibun
            // 
            this.btnJibun.Depth = 0;
            this.btnJibun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJibun.Location = new System.Drawing.Point(458, 463);
            this.btnJibun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJibun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnJibun.Name = "btnJibun";
            this.btnJibun.Primary = true;
            this.btnJibun.Size = new System.Drawing.Size(88, 51);
            this.btnJibun.TabIndex = 20;
            this.btnJibun.Text = "지번주소   선택";
            this.btnJibun.UseVisualStyleBackColor = true;
            this.btnJibun.Click += new System.EventHandler(this.BtnJibun_Click);
            // 
            // RoadSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 534);
            this.Controls.Add(this.btnJibun);
            this.Controls.Add(this.btnRoad);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtJibunAddr2);
            this.Controls.Add(this.txtJibunZipCode);
            this.Controls.Add(this.txtJibunAddr1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRoadAddr2);
            this.Controls.Add(this.txtRoadZipCode);
            this.Controls.Add(this.txtRoadAddr1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RoadSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소검색";
            this.Load += new System.EventHandler(this.RoadSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJibunAddr2;
        private System.Windows.Forms.TextBox txtJibunZipCode;
        private System.Windows.Forms.TextBox txtJibunAddr1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtRoadAddr2;
        private System.Windows.Forms.TextBox txtRoadZipCode;
        private System.Windows.Forms.TextBox txtRoadAddr1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSearch;
        private MaterialSkin.Controls.MaterialRaisedButton btnRoad;
        private MaterialSkin.Controls.MaterialRaisedButton btnJibun;
    }
}