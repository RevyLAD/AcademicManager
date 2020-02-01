namespace Academic_Manager
{
    partial class UniversityHomepageForm
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(18, 30);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(891, 598);
            this.webBrowser1.TabIndex = 0;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel27.Location = new System.Drawing.Point(0, 5);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(111, 19);
            this.metroLabel27.TabIndex = 59;
            this.metroLabel27.Text = "대학교 홈페이지";
            // 
            // UniversityHomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 644);
            this.Controls.Add(this.metroLabel27);
            this.Controls.Add(this.webBrowser1);
            this.DisplayHeader = false;
            this.Name = "UniversityHomepageForm";
            this.Padding = new System.Windows.Forms.Padding(18, 30, 18, 16);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroLabel metroLabel27;
    }
}