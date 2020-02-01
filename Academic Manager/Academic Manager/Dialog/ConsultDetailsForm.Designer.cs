namespace Academic_Manager
{
    partial class ConsultDetailsForm
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
            this.lblStudentName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConsultFeedBack = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConsultDetail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblConsultDate = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStudentName.Location = new System.Drawing.Point(67, 81);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(54, 20);
            this.lblStudentName.TabIndex = 29;
            this.lblStudentName.Text = "홍길동";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(18, 81);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(47, 20);
            this.metroLabel16.TabIndex = 30;
            this.metroLabel16.Text = "이름 :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txtConsultFeedBack);
            this.groupBox1.Location = new System.Drawing.Point(18, 353);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(629, 169);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "조치사항";
            // 
            // txtConsultFeedBack
            // 
            // 
            // 
            // 
            this.txtConsultFeedBack.CustomButton.Image = null;
            this.txtConsultFeedBack.CustomButton.Location = new System.Drawing.Point(480, 1);
            this.txtConsultFeedBack.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultFeedBack.CustomButton.Name = "";
            this.txtConsultFeedBack.CustomButton.Size = new System.Drawing.Size(133, 133);
            this.txtConsultFeedBack.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultFeedBack.CustomButton.TabIndex = 1;
            this.txtConsultFeedBack.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultFeedBack.CustomButton.UseSelectable = true;
            this.txtConsultFeedBack.CustomButton.Visible = false;
            this.txtConsultFeedBack.Enabled = false;
            this.txtConsultFeedBack.Lines = new string[0];
            this.txtConsultFeedBack.Location = new System.Drawing.Point(8, 26);
            this.txtConsultFeedBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultFeedBack.MaxLength = 32767;
            this.txtConsultFeedBack.Multiline = true;
            this.txtConsultFeedBack.Name = "txtConsultFeedBack";
            this.txtConsultFeedBack.PasswordChar = '\0';
            this.txtConsultFeedBack.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultFeedBack.SelectedText = "";
            this.txtConsultFeedBack.SelectionLength = 0;
            this.txtConsultFeedBack.SelectionStart = 0;
            this.txtConsultFeedBack.ShortcutsEnabled = true;
            this.txtConsultFeedBack.Size = new System.Drawing.Size(614, 135);
            this.txtConsultFeedBack.TabIndex = 0;
            this.txtConsultFeedBack.UseSelectable = true;
            this.txtConsultFeedBack.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultFeedBack.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.txtConsultDetail);
            this.groupBox2.Location = new System.Drawing.Point(18, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(629, 201);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상담내역";
            // 
            // txtConsultDetail
            // 
            // 
            // 
            // 
            this.txtConsultDetail.CustomButton.Image = null;
            this.txtConsultDetail.CustomButton.Location = new System.Drawing.Point(448, 2);
            this.txtConsultDetail.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultDetail.CustomButton.Name = "";
            this.txtConsultDetail.CustomButton.Size = new System.Drawing.Size(163, 163);
            this.txtConsultDetail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsultDetail.CustomButton.TabIndex = 1;
            this.txtConsultDetail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsultDetail.CustomButton.UseSelectable = true;
            this.txtConsultDetail.CustomButton.Visible = false;
            this.txtConsultDetail.Enabled = false;
            this.txtConsultDetail.Lines = new string[0];
            this.txtConsultDetail.Location = new System.Drawing.Point(8, 26);
            this.txtConsultDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConsultDetail.MaxLength = 32767;
            this.txtConsultDetail.Multiline = true;
            this.txtConsultDetail.Name = "txtConsultDetail";
            this.txtConsultDetail.PasswordChar = '\0';
            this.txtConsultDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsultDetail.SelectedText = "";
            this.txtConsultDetail.SelectionLength = 0;
            this.txtConsultDetail.SelectionStart = 0;
            this.txtConsultDetail.ShortcutsEnabled = true;
            this.txtConsultDetail.Size = new System.Drawing.Size(614, 168);
            this.txtConsultDetail.TabIndex = 0;
            this.txtConsultDetail.UseSelectable = true;
            this.txtConsultDetail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsultDetail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(151, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 20);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "상담일자 :";
            // 
            // lblConsultDate
            // 
            this.lblConsultDate.AutoSize = true;
            this.lblConsultDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblConsultDate.Location = new System.Drawing.Point(232, 81);
            this.lblConsultDate.Name = "lblConsultDate";
            this.lblConsultDate.Size = new System.Drawing.Size(93, 20);
            this.lblConsultDate.TabIndex = 33;
            this.lblConsultDate.Text = "2019-11-01";
            // 
            // ConsultDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblConsultDate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.metroLabel16);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConsultDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "상세내역";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblStudentName;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtConsultFeedBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtConsultDetail;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblConsultDate;
    }
}