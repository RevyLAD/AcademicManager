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
    public partial class MockRecords : MetroForm
    {
        public MockRecords(string std_id, string std_name)
        {
            InitializeComponent();



            this.lblStudentID.Text = std_id;
            this.lblStudentName.Text = std_name;
        }
        private void MockRecords_Load(object sender, EventArgs e)
        {
            //그리드속성
            MockGrid.AutoGenerateColumns = false;
            MockGrid.AllowUserToAddRows = false;
            MockGrid.MultiSelect = true;
            MockGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MockGrid.RowHeadersWidth = 15;
            MockGrid.ColumnHeadersHeight = 20;
            MockGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            MockGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 8.5F);

            UtilityClass.AddNewColumnToDataGridView(MockGrid, "학년", "grade", true, 50);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "월", "semester", true, 50);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "국어", "korean", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "영어", "english", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "수학", "math", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "사회/과학1", "side_choice1", true, 70);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "사회/과학2", "side_choice2", true, 70);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "제2외국어", "more_foreign", true, 90);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "모의고사코드", "mock_recordID", false, 30);



            LoadData();
            LoadChart();
        }


        #region 모의고사성적, 차트 로드
        private void LoadData()
        {
            SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
            DataSet ds = dac.GetAllMock(lblStudentID.Text);
            MockGrid.DataSource = ds.Tables[0];

            dac.Dispose();
        }
        private void LoadChart()
        {
            chartMock.Series.Clear();

            chartMock.Series.Add(new Series("Series1"));
            chartMock.Series.Add(new Series("Series2"));
            chartMock.Series.Add(new Series("Series3"));
            chartMock.Series.Add(new Series("Series4"));
            chartMock.Series.Add(new Series("Series5"));
            chartMock.Series.Add(new Series("Series6"));

            SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
            DataSet ds = dac.GetMockChart(lblStudentID.Text);

            DataView dv = new DataView(ds.Tables[0]);

            //DataTable 객체를 DataSource에 지정하고
            //x,y축 컬럼을 xValueMember와 YValueMember에 지정
            chartMock.Series[0].Points.DataBind(dv, "grade", "korean", "Tooltip=korean");
            chartMock.Series[1].Points.DataBind(dv, "grade", "english", "Tooltip=english");
            chartMock.Series[2].Points.DataBind(dv, "grade", "math", "Tooltip=math");
            chartMock.Series[3].Points.DataBind(dv, "grade", "side_choice1", "Tooltip=side_choice1");
            chartMock.Series[4].Points.DataBind(dv, "grade", "side_choice2", "Tooltip=side_choice2");
            chartMock.Series[5].Points.DataBind(dv, "grade", "more_foreign", "Tooltip=more_foreign");

            chartMock.Series[0].LegendText = "국어";
            chartMock.Series[1].LegendText = "영어";
            chartMock.Series[2].LegendText = "수학";
            chartMock.Series[3].LegendText = "사회/과학1";
            chartMock.Series[4].LegendText = "사회/과학2";
            chartMock.Series[5].LegendText = "제2외국어";

        }
        #endregion

        #region 신규등록, 삭제
        private void BtnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (MaterialMessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
                    dac.DeleteMock(MockGrid[8, MockGrid.CurrentRow.Index].Value.ToString());
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
            MockRecordInsUpForm frm = new MockRecordInsUpForm(lblStudentID.Text, lblStudentName.Text);

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    SchoolRecordInfoDAC DAC = new SchoolRecordInfoDAC();
                    DAC.InsertMock(frm.MockRecordInfo);
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

