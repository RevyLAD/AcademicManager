using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework.Forms;
namespace Academic_Manager
{
    public partial class SchoolRecord : MetroForm
    {
        public SchoolRecord(string std_id, string std_name)
        {
            InitializeComponent();



            this.lblStudentID.Text = std_id;
            this.lblStudentName.Text = std_name;
        }

        private void SchoolRecord_Load(object sender, EventArgs e)
        {
            //그리드속성
            RecordGrid.AutoGenerateColumns = false;
            RecordGrid.AllowUserToAddRows = false;
            RecordGrid.MultiSelect = true;
            RecordGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecordGrid.RowHeadersWidth = 15;
            RecordGrid.ColumnHeadersHeight = 20;
            RecordGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            RecordGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 8.5F);

            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "학년", "grade", true, 60);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "학기", "semester", true, 60);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "국어", "sch_korean", true, 100);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "영어", "sch_english", true, 100);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "수학", "sch_math", true, 100);
            UtilityClass.AddNewColumnToDataGridView(RecordGrid, "성적코드", "sch_recordID", false,20);


            LoadData();
            LoadChart();
        }

        #region 내신성적 , 차트 로드
        private void LoadData()
        {
            SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
            DataSet ds = dac.GetAllSchool(lblStudentID.Text);
            RecordGrid.DataSource = ds.Tables[0];

            
            dac.Dispose();
        }

        private void LoadChart()
        {
            chartSchool.Series.Clear();

            chartSchool.Series.Add(new Series("Series1"));
            chartSchool.Series.Add(new Series("Series2"));
            chartSchool.Series.Add(new Series("Series3"));

            SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
            DataSet ds = dac.GetSchoolChart(lblStudentID.Text);

            DataView dv = new DataView(ds.Tables[0]);


            //DataTable 객체를 DataSource에 지정하고
            //x,y축 컬럼을 xValueMember와 YValueMember에 지정
            chartSchool.Series[0].Points.DataBind(dv, "grade", "korean", "Tooltip=korean");
            chartSchool.Series[1].Points.DataBind(dv, "grade", "english", "Tooltip=english");
            chartSchool.Series[2].Points.DataBind(dv, "grade" , "math", "Tooltip=math");

            chartSchool.Series[0].LegendText = "국어";
            chartSchool.Series[1].LegendText = "영어";
            chartSchool.Series[2].LegendText = "수학";

        }
        #endregion

        #region 등록 , 삭제
        private void BtnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaterialMessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
                    dac.DeleteSchool(RecordGrid[5, RecordGrid.CurrentRow.Index].Value.ToString());
                    dac.Dispose();
                    LoadData();
                    LoadChart();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnCreateRecord_Click(object sender, EventArgs e)
        {
            SchoolRecordInsUpForm frm = new SchoolRecordInsUpForm(lblStudentID.Text, lblStudentName.Text);


            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SchoolRecordInfoDAC DAC = new SchoolRecordInfoDAC();
                    DAC.InsertSchool(frm.RecordInfo);
                    DAC.Dispose();
                    MaterialMessageBox.Show("신규등록이 완료되었습니다.", "확인", MessageBoxButtons.OK);
                    LoadData();
                    LoadChart();
                }
            }
            catch (Exception err)
            {
                MetroFramework.MetroMessageBox.Show(this, err.Message, "경고");
            }

        }

        #endregion
    }
}
