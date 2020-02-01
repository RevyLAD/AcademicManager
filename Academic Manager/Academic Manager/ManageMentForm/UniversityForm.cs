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
    public partial class UniversityForm : MetroForm
    {
        public UniversityForm(string std_id, string std_name)
        {
            InitializeComponent();


            this.lblStudentID.Text = std_id;
            this.lblStudentName.Text = std_name;
        }

        private void AwardForm_Load(object sender, EventArgs e)
        {
            //대학, 학과 그리드뷰 속성
            UnivMajorGrid.AutoGenerateColumns = false;
            UnivMajorGrid.AllowUserToAddRows = false;
            UnivMajorGrid.MultiSelect = true;
            UnivMajorGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UnivMajorGrid.RowHeadersWidth = 10;
            UnivMajorGrid.ColumnHeadersHeight = 30;
            UnivMajorGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            UnivMajorGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(UnivMajorGrid, "대학이름", "univ_name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(UnivMajorGrid, "학과이름", "major_name", true, 200);


            txtMajorSearch.ImeMode = ImeMode.Hangul;
            txtUnivSearch.ImeMode = ImeMode.Hangul;

            bool bCheck = false;
            VisibleControl(bCheck);
        }

        #region Panel VisibleControl 
        private void VisibleControl(bool bCheck)
        {
            foreach (var control in this.panel1.Controls)
            {
                if (control is TextBox)
                {
                    TextBox temp = (TextBox)control;
                    if (temp.Visible == !bCheck)
                    {
                        temp.Visible = bCheck;
                    }
                }
                if (control is Label)
                {
                    Label temp = (Label)control;
                    if (temp.Visible == !bCheck)
                    {
                        temp.Visible = bCheck;
                    }
                }
            }
        }
        #endregion

        #region 로드데이터
        private void LoadUnivData()
        {
            UnivMajorGrid.Refresh();
            UniversityInfoService service = new UniversityInfoService();
            DataSet ds = service.GetSearchUniv(txtUnivSearch.Text);
            UnivMajorGrid.DataSource = ds.Tables[0];
            service.Dispose();
        }

        private void LoadMajorData()
        {
            UnivMajorGrid.Refresh();
            UniversityInfoService service = new UniversityInfoService();
            DataSet ds = service.GetSearchMajor(txtMajorSearch.Text);
            UnivMajorGrid.DataSource = ds.Tables[0];
            service.Dispose();
        }
        #endregion

        #region 검색, 더블클릭, 분석 

        private void BtnUnivSearch_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUnivSearch.Text))
            {
                LoadUnivData();
                txtUnivSearch.Text = "";
            }
            else
            {
                MaterialMessageBox.Show("학교를 입력해주세요.", "경고", MessageBoxButtons.OK);
            }
        }

        private void BtnMajorSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMajorSearch.Text))
            {
                LoadMajorData();
                txtMajorSearch.Text = "";
            }
            else
            {
                MaterialMessageBox.Show("학과를 입력해주세요.", "경고", MessageBoxButtons.OK);
            }
        }


        private void TxtUnivSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtUnivSearch.Text))
                {
                }
                else
                {
                    btnUnivSearch.PerformClick();
                }
            }
        }

        private void TxtMajorSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtMajorSearch.Text))
                {
                }
                else
                {
                    btnMajorSearch.PerformClick();
                }
            }
        }

        private void UnivMajorGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)UnivMajorGrid.DataSource;

            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                bool bCheck = true;
                VisibleControl(bCheck);

                txtSelectUniv.Text = dt.Rows[e.RowIndex]["univ_name"].ToString();
                txtSelectMajor.Text = dt.Rows[e.RowIndex]["major_name"].ToString();
            }
        }

        private void MetroLabel5_Click_1(object sender, EventArgs e)
        {

            if(!string.IsNullOrEmpty(txtSelectMajor.Text) || !string.IsNullOrEmpty(txtSelectUniv.Text))
            {

                UniversityResultForm frm = new UniversityResultForm(lblStudentID.Text, lblStudentName.Text, txtSelectUniv.Text, txtSelectMajor.Text);

                frm.Show();
            }
        }

        #endregion
    }
}
