namespace Academic_Manager
{
    partial class Form1
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.ques1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ans2 = new System.Windows.Forms.Label();
            this.ans1 = new System.Windows.Forms.Label();
            this.ans3 = new System.Windows.Forms.Label();
            this.ans4 = new System.Windows.Forms.Label();
            this.ques2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // ques1
            // 
            this.ques1.AutoSize = true;
            this.ques1.Location = new System.Drawing.Point(125, 162);
            this.ques1.Name = "ques1";
            this.ques1.Size = new System.Drawing.Size(22, 15);
            this.ques1.TabIndex = 4;
            this.ques1.Text = "밥";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 6;
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(213, 217);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(67, 15);
            this.ans2.TabIndex = 8;
            this.ans2.Text = "안먹는다";
            this.ans2.Click += new System.EventHandler(this.Ans2_Click);
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(213, 121);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(82, 15);
            this.ans1.TabIndex = 9;
            this.ans1.Text = "같이먹는다";
            this.ans1.Click += new System.EventHandler(this.Ans1_Click);
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(412, 121);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(92, 15);
            this.ans3.TabIndex = 13;
            this.ans3.Text = "같이 코 잔다";
            this.ans3.Click += new System.EventHandler(this.Ans3_Click);
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Location = new System.Drawing.Point(412, 217);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(52, 15);
            this.ans4.TabIndex = 12;
            this.ans4.Text = "안잔다";
            this.ans4.Click += new System.EventHandler(this.Ans4_Click);
            // 
            // ques2
            // 
            this.ques2.AutoSize = true;
            this.ques2.Location = new System.Drawing.Point(324, 162);
            this.ques2.Name = "ques2";
            this.ques2.Size = new System.Drawing.Size(22, 15);
            this.ques2.TabIndex = 10;
            this.ques2.Text = "잠";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 533);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ques2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ques1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label ques1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ans2;
        private System.Windows.Forms.Label ans1;
        private System.Windows.Forms.Label ans3;
        private System.Windows.Forms.Label ans4;
        private System.Windows.Forms.Label ques2;
    }
}