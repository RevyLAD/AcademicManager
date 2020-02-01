using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework.Forms;
using System.Drawing.Printing;
namespace Academic_Manager
{
    public partial class AllInfoForm : MetroForm
    {

        int schrowIndex = 0;
        int schcellIndex = 0;
        int mockrowIndex = 0;
        int mockcellIndex = 0;
        
        public AllInfoForm(string std_id, string std_name)
        {
            InitializeComponent();

            lblStudentID.Text = std_id;
            lblStudentName.Text = std_name;
        }

        private void AllInfoForm_Load(object sender, EventArgs e)
        {
            LoadSchoolChart();
            LoadCMockhart();
            LoadConsultList();
            LoadAwardList();
            LoadSchoolRecord();
            LoadMockRecord();
            LoadPossibleSchoolUniv();
        }

        #region 내신성적 로드
        private void LoadSchoolRecord()
        {
            //그리드속성
            SchoolGrid.AutoGenerateColumns = false;
            SchoolGrid.AllowUserToAddRows = false;
            SchoolGrid.MultiSelect = true;
            SchoolGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolGrid.RowHeadersWidth = 15;
            SchoolGrid.ColumnHeadersHeight = 20;
            SchoolGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            SchoolGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(SchoolGrid, "학년", "grade", true, 60);
            UtilityClass.AddNewColumnToDataGridView(SchoolGrid, "국어", "sch_korean", true, 60);
            UtilityClass.AddNewColumnToDataGridView(SchoolGrid, "영어", "sch_english", true, 60);
            UtilityClass.AddNewColumnToDataGridView(SchoolGrid, "수학", "sch_math", true, 60);
            UtilityClass.AddNewColumnToDataGridView(SchoolGrid, "평균", "total_avg", true, 60);
            UtilityClass.AddNewColumnToDataGridView(SchoolGrid, "등급컷", "cut", true, 70);

            SchoolRecordInfoDAC DAC = new SchoolRecordInfoDAC();
            DataSet ds = DAC.GetSchoolRecordAvg(lblStudentID.Text);
            SchoolGrid.DataSource = ds.Tables[0];

            SchoolGrid.ClearSelection();
            DAC.Dispose();
        }
        #endregion

        #region 모의고사 성적 로드
        private void LoadMockRecord()
        {
            //그리드속성
            MockGrid.AutoGenerateColumns = false;
            MockGrid.AllowUserToAddRows = false;
            MockGrid.MultiSelect = true;
            MockGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MockGrid.RowHeadersWidth = 15;
            MockGrid.ColumnHeadersHeight = 20;
            MockGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            MockGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "학년", "grade", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "국어", "korean", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "영어", "english", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "수학", "math", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "사회/과학1", "side_choice1", true, 100);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "사회/과학2", "side_choice2", true, 100);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "제2외국어", "more_foreign", true, 90);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "평균", "total_avg", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockGrid, "등급컷", "cut", true, 70);

            SchoolRecordInfoDAC DAC = new SchoolRecordInfoDAC();
            DataSet ds = DAC.GetMockRecordAvg(lblStudentID.Text);
            MockGrid.DataSource = ds.Tables[0];
            MockGrid.ClearSelection();
            DAC.Dispose();
        }
        #endregion

        #region 내신성적 차트 && 모의고사성적 차트
        private void LoadSchoolChart()
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
            chartSchool.Series[2].Points.DataBind(dv, "grade", "math", "Tooltip=math");

            chartSchool.Series[0].LegendText = "국어";
            chartSchool.Series[1].LegendText = "영어";
            chartSchool.Series[2].LegendText = "수학";

        }

        private void LoadCMockhart()
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

        #region 상담리스트 불러오기
        private void LoadConsultList()
        {
            ConsultGrid.AutoGenerateColumns = false;
            ConsultGrid.AllowUserToAddRows = false;
            ConsultGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ConsultGrid.RowHeadersWidth = 15;
            ConsultGrid.ColumnHeadersHeight = 30;
            ConsultGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            ConsultGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            ConsultGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ConsultGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ConsultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "상담번호", "consult_id", false, 10);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "상담날짜", "consult_date", true, 100);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "상담내용", "consult_details", true, 150);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "조치사항", "others", true, 150);
            ConsultInfoService service = new ConsultInfoService();
            ConsultGrid.DataSource = service.GetStudentConsult(lblStudentID.Text);
            ConsultGrid.ClearSelection();
            service.Dispose();
        }
        #endregion

        #region 수상내역 불러오기
        private void LoadAwardList()
        {
            AwardGrid.AutoGenerateColumns = false;
            AwardGrid.AllowUserToAddRows = false;
            AwardGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AwardGrid.RowHeadersWidth = 15;
            AwardGrid.ColumnHeadersHeight = 30;
            AwardGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            AwardGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "수상코드", "award_id", false, 30);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "대회코드", "competition_id", false, 30);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "대회이름", "comp_name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "대회설명", "comp_details", true, 180);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "수상내역", "award_details", true, 110);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "날짜", "comp_date", true, 90);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "주최", "comp_host", true, 110);
            CompetitionInfoService dac = new CompetitionInfoService();
            DataTable dt = dac.GetAwardByStudent(lblStudentID.Text);
            AwardGrid.DataSource = dt;
            AwardGrid.ClearSelection();
            dac.Dispose();
        }
        #endregion

        #region 지원가능 대학정보 로드 (내신, 모의고사)
        private void LoadPossibleSchoolUniv()
        {
            //그리드속성
            SchoolUnivCutGrid.AutoGenerateColumns = false;
            SchoolUnivCutGrid.AllowUserToAddRows = false;
            SchoolUnivCutGrid.MultiSelect = true;
            SchoolUnivCutGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolUnivCutGrid.RowHeadersWidth = 15;
            SchoolUnivCutGrid.ColumnHeadersHeight = 20;
            SchoolUnivCutGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            SchoolUnivCutGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(SchoolUnivCutGrid, "대학", "univ_name", true, 130);
            UtilityClass.AddNewColumnToDataGridView(SchoolUnivCutGrid, "학과", "major_name", true, 143);
            UtilityClass.AddNewColumnToDataGridView(SchoolUnivCutGrid, "등급컷", "cut", true, 80);

            SchoolRecordInfoDAC DAC = new SchoolRecordInfoDAC();
            if (schrowIndex == 0 && schcellIndex == 0)
            {
                return;
            }
            DataSet ds = DAC.GetPossibleUnivCutLine(Convert.ToInt32(SchoolGrid.Rows[schrowIndex].Cells[schcellIndex].Value));
            SchoolUnivCutGrid.DataSource = ds.Tables[0];

            SchoolUnivCutGrid.ClearSelection();
            DAC.Dispose();
        }

        private void LoadPossibleMockUniv()
        {
            //그리드속성
            SchoolUnivCutGrid.AutoGenerateColumns = false;
            SchoolUnivCutGrid.AllowUserToAddRows = false;
            SchoolUnivCutGrid.MultiSelect = true;
            SchoolUnivCutGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolUnivCutGrid.RowHeadersWidth = 15;
            SchoolUnivCutGrid.ColumnHeadersHeight = 20;
            SchoolUnivCutGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            SchoolUnivCutGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(SchoolUnivCutGrid, "대학", "univ_name", true, 130);
            UtilityClass.AddNewColumnToDataGridView(SchoolUnivCutGrid, "학과", "major_name", true, 143);
            UtilityClass.AddNewColumnToDataGridView(SchoolUnivCutGrid, "등급컷", "cut", true, 80);

            SchoolRecordInfoDAC DAC = new SchoolRecordInfoDAC();
            if (mockrowIndex == 0 && mockcellIndex == 0)
            {
                return;
            }
            DataSet ds = DAC.GetPossibleUnivCutLine(Convert.ToInt32(MockGrid.Rows[mockrowIndex].Cells[mockcellIndex].Value));
            SchoolUnivCutGrid.DataSource = ds.Tables[0];

            SchoolUnivCutGrid.ClearSelection();
            DAC.Dispose();
        }
        #endregion

        #region DataBindingComplete (로드된 데이터의 평균, 등급컷 등 색깔표시)
        private void SchoolGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < SchoolGrid.Rows.Count; i++)
            {
                if (SchoolGrid.Rows[i].Cells[0].Value.ToString() == "평균")
                {
                    for (int j = 0; j < SchoolGrid.Columns.Count; j++)
                    {
                        if (j == SchoolGrid.Columns.Count - 1)
                        {
                            SchoolGrid.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                            SchoolGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            schrowIndex = i;
                            schcellIndex = j;
                        }
                        else
                        {
                            SchoolGrid.Rows[i].Cells[j].Style.ForeColor = Color.Coral;
                            SchoolGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

                        }
                    }
                }
            }

            for (int i = 0; i < MockGrid.Rows.Count; i++)
            {
                if (MockGrid.Rows[i].Cells[0].Value.ToString() == "평균")
                {
                    for (int j = 0; j < MockGrid.Columns.Count; j++)
                    {
                        if (j == MockGrid.Columns.Count - 1)
                        {
                            MockGrid.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                            MockGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            mockrowIndex = i;
                            mockcellIndex = j;
                        }
                        else
                        {
                            MockGrid.Rows[i].Cells[j].Style.ForeColor = Color.Coral;
                            MockGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                }
            }

            
        }

        private void SchoolUnivCutGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < SchoolUnivCutGrid.Rows.Count; i++)
            {

                for (int j = 0; j < SchoolUnivCutGrid.Columns.Count; j++)
                {
                    if (j == SchoolUnivCutGrid.Columns.Count - 1)
                    {
                        SchoolUnivCutGrid.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                        SchoolUnivCutGrid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }

                }

            }
        }

        #endregion

        #region RadioBtn CheckedChanged
        private void RadiobtnSchool_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobtnSchool.Checked ==true)
            {
                SchoolUnivCutGrid.Refresh();
                SchoolUnivCutGrid.Columns.Clear();
                LoadPossibleSchoolUniv();
                groupBox5.Text = "지원가능대학(내신)";

            }
            else if(radiobtnMock.Checked == true)
            {
                SchoolUnivCutGrid.Refresh();
                SchoolUnivCutGrid.Columns.Clear();
                LoadPossibleMockUniv();
                groupBox5.Text = "지원가능대학(모의고사)";
            }
        }

        #endregion

        #region 프린트 버튼
        private void Button1_Click(object sender, EventArgs e)
        {
            Bitmap screenshot = new Bitmap(this.Bounds.Width,
                               this.Bounds.Height,
                               PixelFormat.Format32bppArgb);
            Graphics screenGraph = Graphics.FromImage(screenshot);
            screenGraph.CopyFromScreen(this.Bounds.X,
                                       this.Bounds.Y,
                                       0,
                                       0,
                                       this.Bounds.Size,
                                       CopyPixelOperation.SourceCopy);

            screenshot.Save(Environment.CurrentDirectory.Replace("\\", "/")+"/Screenshot.png", ImageFormat.Png);

            printDocument1.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.Document = printDocument1;

            //printPreviewDialog1.ShowDialog();
            printDocument1.Print();
        }
        

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image memoryImage = Image.FromFile(Environment.CurrentDirectory.Replace("\\", "/") +"/Screenshot.png");
            e.Graphics.DrawImage(memoryImage,0,-50);

        }
    }

    #endregion
}
