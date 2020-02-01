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
    public partial class SchoolOrMockForm : MaterialSkin.Controls.MaterialForm
    {


        public SchoolOrMockForm()
        {
            InitializeComponent();
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked == true)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        public string ReturnData()
        {
            if (metroRadioButton1.Checked == true)
            {
                return metroRadioButton1.Text;
            }
            else
            {
                return metroRadioButton2.Text;
            }
        }

        private void SchoolOrMockForm_Load(object sender, EventArgs e)
        {
            this.metroRadioButton1.Checked = true;
        }
    }
}
