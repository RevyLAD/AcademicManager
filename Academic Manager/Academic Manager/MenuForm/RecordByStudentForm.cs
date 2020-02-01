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
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace Academic_Manager
{
    public partial class RecordByStudentForm : MetroForm
    {
        public RecordByStudentForm()
        {
            InitializeComponent();
        }

        private void RecordByStudentForm_Load(object sender, EventArgs e)
        {
            //학생목록
            StudentGrid.AutoGenerateColumns = false;
            StudentGrid.AllowUserToAddRows = false;
            StudentGrid.MultiSelect = true;
            StudentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentGrid.RowHeadersWidth = 15;
            StudentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            StudentGrid.ColumnHeadersHeight = 30;
            StudentGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            StudentGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            UtilityClass.AddNewColumnToDataGridView(StudentGrid, "학생ID", "std_id", true, 90);
            UtilityClass.AddNewColumnToDataGridView(StudentGrid, "이름", "std_name", true, 80);
            StudentGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            StudentGrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;


            //내신성적
            SchoolRecordGrid.AutoGenerateColumns = false;
            SchoolRecordGrid.AllowUserToAddRows = false;
            SchoolRecordGrid.MultiSelect = true;
            SchoolRecordGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolRecordGrid.RowHeadersWidth = 15;
            SchoolRecordGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SchoolRecordGrid.ColumnHeadersHeight = 30;
            SchoolRecordGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            StudentGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10.5F);

            UtilityClass.AddNewColumnToDataGridView(SchoolRecordGrid, "학년", "grade", true, 60);
            UtilityClass.AddNewColumnToDataGridView(SchoolRecordGrid, "학기", "semester", true, 60);
            UtilityClass.AddNewColumnToDataGridView(SchoolRecordGrid, "국어", "sch_korean", true, 100);
            UtilityClass.AddNewColumnToDataGridView(SchoolRecordGrid, "영어", "sch_english", true, 100);
            UtilityClass.AddNewColumnToDataGridView(SchoolRecordGrid, "수학", "sch_math", true, 100);
            UtilityClass.AddNewColumnToDataGridView(SchoolRecordGrid, "성적코드", "sch_recordID", false, 60);

            //모의고사 성적
            MockRecordGrid.AutoGenerateColumns = false;
            MockRecordGrid.AllowUserToAddRows = false;
            MockRecordGrid.MultiSelect = true;
            MockRecordGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MockRecordGrid.RowHeadersWidth = 15;
            MockRecordGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MockRecordGrid.ColumnHeadersHeight = 30;
            MockRecordGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            StudentGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10.5F);

            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "학년", "grade", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "월", "semester", true, 40);
            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "국어", "korean", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "영어", "english", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "수학", "math", true, 60);
            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "사회/과학1", "side_choice1", true, 90);
            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "사회/과학2", "side_choice2", true, 90);
            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "제2외국어", "more_foreign", true, 80);
            UtilityClass.AddNewColumnToDataGridView(MockRecordGrid, "모의고사코드", "mock_recordID", false, 30);


            LoadStudentGridData(); //학생정보 로드

            cmbFind.SelectedIndex = 0;

        }

        #region 학생목록 불러오기
        private void LoadStudentGridData()
        {
            StudentInfoDAC DAC = new StudentInfoDAC();
            DataSet ds = DAC.GetIDName();
            StudentGrid.DataSource = ds.Tables[0];
            DAC.Dispose();
        }
        #endregion

        #region 더블클릭 이벤트 (더블클릭시 성적데이터 로드)
        private void StudentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)StudentGrid.DataSource;

            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                lblStudentID.Text = dt.Rows[e.RowIndex]["std_id"].ToString();
                lblStudentName.Text = dt.Rows[e.RowIndex]["std_name"].ToString();


                LoadSchoolData();
                LoadMockData();
            }
        }
        #endregion

        #region 내신, 모의고사 성적 불러오오기
        private void LoadSchoolData() //내신
        {
            SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
            DataSet ds = dac.GetAllSchool(lblStudentID.Text);
            SchoolRecordGrid.DataSource = ds.Tables[0];

            dac.Dispose();
        }

        private void LoadMockData() //모의고사
        {
            SchoolRecordInfoDAC dac = new SchoolRecordInfoDAC();
            DataSet ds = dac.GetAllMock(lblStudentID.Text);
            MockRecordGrid.DataSource = ds.Tables[0];

            dac.Dispose();
        }
        #endregion

        #region 학생검색기능
        private void BtnSearch_Click(object sender, EventArgs e)
        {

            bool bCheck = false;
            for (int i = 0; i < StudentGrid.RowCount; i++)
            {
                if (StudentGrid.Rows[i].Cells[1].Value.ToString() == txtFindName.Text.Trim())
                {
                    StudentGrid.ClearSelection();
                    StudentGrid.Rows[i].Selected = true;
                    bCheck = true;

                    lblStudentID.Text = StudentGrid.Rows[i].Cells[0].Value.ToString();
                    lblStudentName.Text = StudentGrid.Rows[i].Cells[1].Value.ToString();

                    LoadSchoolData();
                    LoadMockData();
                }
            }

            if (!bCheck)
            {
                MaterialMessageBox.Show("존재하지 않는 학생입니다.", "삭제확인", MessageBoxButtons.OK);
            }

            txtFindName.Text = "";
        }

        private void TxtFindName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtFindName.Text))
                {
                }
                else
                {
                    btnSearch.PerformClick();
                }
            }
        }
        #endregion

        #region 엑셀저장
        private void BtnEcxel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Worksheet xlWorkSheet2;

            int i, j;

            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet2 = xlWorkBook.Worksheets.Add();
                //xlWorkSheet2 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);

                for (i = 0; i < SchoolRecordGrid.RowCount; i++)
                {
                    for (j = 0; j < SchoolRecordGrid.ColumnCount-2; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = SchoolRecordGrid[j, i].Value.ToString();
                    }
                }

                for (i = 0; i < MockRecordGrid.RowCount; i++)
                {
                    for (j = 0; j < MockRecordGrid.ColumnCount-2; j++)
                    {
                        xlWorkSheet2.Cells[i + 1, j + 1] = MockRecordGrid[j, i].Value.ToString();
                    }
                }

                xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkSheet2);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }


        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        #endregion
    }

}
