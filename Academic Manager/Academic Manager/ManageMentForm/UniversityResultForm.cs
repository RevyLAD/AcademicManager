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
    public partial class UniversityResultForm : MaterialSkin.Controls.MaterialForm
    {
        string std_id;
        string std_name;
        string university;
        string major;
        public UniversityResultForm(string std_id, string std_name, string university, string major)
        {
            InitializeComponent();

            this.std_id = std_id;
            this.std_name = std_name;
            this.university = university;
            this.major = major;

            lblStudentID.Text = std_id;
            lblStudentName.Text = std_name;
            lblUniversityName.Text = university;
            lblMajorName.Text = major;
        }

        private void UniversityResultForm_Load(object sender, EventArgs e)
        {
            //모의고사 성적 그리드뷰
            RecordGrid.AutoGenerateColumns = false;
            RecordGrid.AllowUserToAddRows = false;
            RecordGrid.MultiSelect = true;
            RecordGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecordGrid.RowHeadersWidth = 15;
            RecordGrid.ColumnHeadersHeight = 20;
            RecordGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            RecordGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "학년", "grade", true, 60);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "국어", "korean", true, 60);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "영어", "english", true, 60);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "수학", "math", true, 60);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "사회/과학1", "side_choice1", true, 70);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "사회/과학2", "side_choice2", true, 70);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "제2외국어", "more_foreign", true, 70);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "평균", "total_avg", true, 60);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "등급컷", "cut", true, 70);



            //대학 등급컷 그리드뷰 
            UnivCutGrid.AutoGenerateColumns = false;
            UnivCutGrid.AllowUserToAddRows = false;
            UnivCutGrid.MultiSelect = true;
            UnivCutGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UnivCutGrid.RowHeadersWidth = 15;
            UnivCutGrid.ColumnHeadersHeight = 20;
            UnivCutGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UnivCutGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            UtilityClass.AddNewColumnToDataGridView(UnivCutGrid, "대학", "univ_name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(UnivCutGrid, "학과", "major_name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(UnivCutGrid, "표준", "standard", true, 60);
            UtilityClass.AddNewColumnToDataGridView(UnivCutGrid, "백분위", "percent", true, 70);
            UtilityClass.AddNewColumnToDataGridView(UnivCutGrid, "등급컷", "cut", true, 70);
            


            LoadRecordAvgData(); 
            LoadUnivCutLine();
        }

        #region 성적평균, 대학등급컷 데이터 로드
        private void LoadRecordAvgData()
        {
            SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
            DataSet ds = dac.GetMockRecordAvg(lblStudentID.Text);
            RecordGrid.DataSource = ds.Tables[0];
            RecordGrid.ClearSelection();
            dac.Dispose();
        }

        private void LoadUnivCutLine()
        {
            SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
            DataSet ds = dac.GetUnivCutLine(lblUniversityName.Text.Trim(), lblMajorName.Text.Trim());
            UnivCutGrid.DataSource = ds.Tables[0];
            UnivCutGrid.ClearSelection();
            dac.Dispose();
        }
        #endregion

        #region DataBindingComplete -> 평균, 등급컷 컬럼색 변경 , 합격여부 확인
        private void RecordGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int record = 0;
            int cut = 0;
            for (int i = 0; i < RecordGrid.Rows.Count; i++)
            {
                if (RecordGrid.Rows[i].Cells[0].Value.ToString() == "평균")
                {
                    for (int j = 0; j < RecordGrid.Columns.Count; j++)
                    {
                        if (j == RecordGrid.Columns.Count-1)
                        {
                            RecordGrid.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                            RecordGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            record = Convert.ToInt32(RecordGrid.Rows[i].Cells[j].Value);
                        }
                        else
                        {
                            RecordGrid.Rows[i].Cells[j].Style.ForeColor = Color.Coral;
                            RecordGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                        }
                    }
                }
            }

            for (int i = 0; i < UnivCutGrid.Rows.Count; i++)
            {
                if (UnivCutGrid.Rows[i].Cells[0].Value.ToString() == lblUniversityName.Text)
                {
                    for (int j = 0; j < UnivCutGrid.Columns.Count; j++)
                    {
                        if (j == UnivCutGrid.Columns.Count - 1)
                        {
                            UnivCutGrid.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                            UnivCutGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            cut = Convert.ToInt32(UnivCutGrid.Rows[i].Cells[j].Value);
                        }

                    }
                }
            }
            if(record ==0)
            {
                lblResult.Text = "모의고사 성적을 먼저 입력해주세요.";
            }

            else if(cut ==0 || cut<0)
            {
                lblResult.Text = "해당학교의 등급컷이 존재하지 않습니다.";
            }
            else if(cut == record)
            {
                lblResult.Text = "합격입니다.";
            }
            else if (cut < record)
            {
                lblResult.Text = "불합격입니다. 상향지원 가능합니다.";
            }
            else if (cut > record)
            {
                lblResult.Text = "합격입니다. 하향지원입니다. ";
            }
        }
        #endregion
    }
}
