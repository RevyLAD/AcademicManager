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
    public partial class ConsultDetailsForm : MetroForm
    {
        public string Std_Name { get { return lblStudentName.Text; } set { lblStudentName.Text = value; } }
        public string Date { get { return lblConsultDate.Text; } set { lblConsultDate.Text = value.Substring(0,10); } }
        public string Detail { get { return txtConsultDetail.Text; } set { txtConsultDetail.Text = value; } }
        public string FeedBack { get { return txtConsultFeedBack.Text; } set { txtConsultFeedBack.Text = value; } }

        public ConsultDetailsForm()
        {
            InitializeComponent();
        }
    }
}
