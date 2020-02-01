using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academic_Manager
{
    public partial class AddressUserControl : UserControl
    {
        string zip = string.Empty;
        string addr1 = string.Empty;
        string addr2 = string.Empty;

        [Description("우편번호 조회")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Zipcode
        {
            get { return textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        [Description("주소1 조회")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Address1 { get { return textBox2.Text; } set { this.textBox2.Text = value; } }

        [Description("주소2 조회")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public string Address2 { get { return textBox3.Text; } set { this.textBox3.Text = value; } }
        public AddressUserControl()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RoadSearchForm frm = new RoadSearchForm();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = frm.Zipcode;
                this.textBox2.Text = frm.Address1;
                this.textBox3.Text = frm.Address2;

            }

        }

        public void LoadData(string zip, string address1, string address2)
        {
            this.textBox1.Text = zip;
            this.textBox2.Text = address1;
            this.textBox3.Text = address2;
        }
    }
}
