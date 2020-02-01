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
    public partial class SchoolRecordInsUpForm : MetroForm
    {

        public SchoolRecordInfoVO RecordInfo
        {

            get
            {
                return new SchoolRecordInfoVO(lblStudentID.Text, cmbGrade.SelectedItem.ToString(), cmbSemester.SelectedItem.ToString(),
                    Convert.ToDouble(txtKorean.Text), Convert.ToDouble(txtEnglish.Text), Convert.ToDouble(txtMath.Text));

            }

            set
            {
                lblStudentID.Text = value.std_Id; 
                cmbGrade.SelectedItem = value.grade;
                cmbSemester.SelectedItem = value.semester;
                txtKorean.Text = value.sch_korean.ToString();
                txtMath.Text = value.sch_math.ToString();
                txtEnglish.Text = value.sch_english.ToString();
            }

        }
        public SchoolRecordInsUpForm(string std_id, string std_name)
        {
            InitializeComponent();


            this.lblStudentID.Text = std_id;
            this.lblStudentName.Text = std_name;
        }

        private void SchoolRecordInsUpForm_Load(object sender, EventArgs e)
        {
            string[] grade = new string[] { "1", "2", "3" };
            string[] semester = new string[] { "1", "2" };

            cmbGrade.Items.AddRange(grade);
            cmbSemester.Items.AddRange(semester);

            cmbGrade.SelectedIndex = 0;
            cmbSemester.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtKorean.Text.Length < 1 || txtMath.Text.Length < 1 || txtKorean.Text.Length < 1)
            {
                MaterialMessageBox.Show("점수를 입력해주세요.", "경고", MessageBoxButtons.OK);
                return;
            }
            else if (Convert.ToDouble(txtKorean.Text)>100 || Convert.ToDouble(txtEnglish.Text) > 100 || Convert.ToDouble(txtMath.Text) > 100)
            {
                MaterialMessageBox.Show("점수는 100점을 넘을수 없습니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void TxtKorean_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool bCheck = Char.IsDigit(e.KeyChar) || (e.KeyChar == '.') || (e.KeyChar == Convert.ToChar(Keys.Back));
            if (!bCheck)
            {
                string val = "true";
                if (val.ToLower() == "true")
                {
                    MaterialMessageBox.Show("숫자를 입력하세요.","경고",MessageBoxButtons.OK);
                }
                e.Handled = true;
            }
        }
    }
}
