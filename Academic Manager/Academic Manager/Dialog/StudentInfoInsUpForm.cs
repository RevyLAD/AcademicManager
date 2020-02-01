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
using MaterialSkin;
namespace Academic_Manager
{
    public partial class StudentInfoInsUpForm : MetroForm
    {
        public enum EditMode { Input, Update }

        public Student StudentInfo
        {
            get
            {
                return new Student(txtStudentID.Text, txtStudentName.Text, string.Concat(txtPhone1.Text,"-",txtPhone2.Text,"-",txtPhone3.Text),txtEmail.Text);
      
            }
            set
            {
                txtStudentID.Text = value.ID;
                txtStudentName.Text = value.Name;
                txtPhone1.Text = value.Phone.Substring(0,3);
                txtPhone2.Text = value.Phone.Substring(4, 4);
                txtPhone3.Text = value.Phone.Substring(9, 4);
                txtEmail.Text = value.Email;
            }
        }

        public StudentInfoInsUpForm(EditMode editMode)
        {
            InitializeComponent();

            if (editMode == EditMode.Update)
            {
               metroLabel1.Text = "정보수정";
               txtStudentID.Enabled = false;
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text.Length < 1 || txtStudentName.Text.Length < 1)
            {
                MaterialMessageBox.Show("아이디,이름을 확인해주세요", "경고", MessageBoxButtons.OK);
                return;
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        private void TxtPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool bCheck = Char.IsDigit(e.KeyChar) || (e.KeyChar == '.') || (e.KeyChar == Convert.ToChar(Keys.Back));
            if (!bCheck)
            {
                string val = "true";
                if (val.ToLower() == "true")
                {
                    MaterialMessageBox.Show("숫자를 입력하세요.", "경고", MessageBoxButtons.OK);
                }
                e.Handled = true;
            }
        }
    }
}
