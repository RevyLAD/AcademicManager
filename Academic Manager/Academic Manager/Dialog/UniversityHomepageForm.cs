using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Academic_Manager
{
    public partial class UniversityHomepageForm : MetroForm
    {
        string url = string.Empty;
        public UniversityHomepageForm(string url)
        {
            InitializeComponent();

            this.url = url;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url);
        }
    }
}
