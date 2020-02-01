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
    public partial class RecordByScoreForm : MetroForm
    {

        string[] grade = new string[] { "1", "2", "3" }; //학년
        string[] semester = new string[] { "1", "2" }; //학기
        string[] month = new string[] { "3", "6", "9" }; //모의고사 월
        public RecordByScoreForm()
        {
            InitializeComponent();
        }

        private void RecordByScoreForm_Load(object sender, EventArgs e)
        {
            //그리드속성
            RecordGrid.AutoGenerateColumns = false;
            RecordGrid.AllowUserToAddRows = false;
            RecordGrid.MultiSelect = true;
            RecordGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RecordGrid.RowHeadersWidth = 15;
            RecordGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            RecordGrid.ColumnHeadersHeight = 30;
            RecordGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            RecordGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 8.5F);

            radiobtnSchool.Checked = true;
        }

        #region 라디오버튼 CheckedChange 이벤트
        private void RadiobtnSchool_CheckedChanged(object sender, EventArgs e)
        {
            //콤보박스 
            if (radiobtnSchool.Checked == true) //내신
            {

                lblSemester.Text = "학기";
                cmbGrade.Items.Clear();
                cmbGrade.Items.AddRange(grade);
                cmbSemester.Items.Clear();
                cmbSemester.Items.AddRange(semester);
                
            }
            else if(radiobtnMock.Checked==true) //모의고사
            {
                lblSemester.Text = "월";
                cmbGrade.Items.Clear();
                cmbGrade.Items.AddRange(grade);
                cmbSemester.Items.Clear();
                cmbSemester.Items.AddRange(month);

            }
        }
        #endregion

        #region 검색 & 로드 (학년, 학기 선택해서 데이터로드)
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (radiobtnSchool.Checked == true) //내신성적
            {
                if(cmbGrade.SelectedItem is null)
                {
                    MaterialMessageBox.Show("학년을 선택해주세요.", "경고", MessageBoxButtons.OK);
                    return;
                }

                if (cmbSemester.SelectedItem is null)
                {
                    MaterialMessageBox.Show("학기 선택해주세요.", "경고", MessageBoxButtons.OK);
                    return;
                }

                //성적 데이터그리드뷰
                RecordGrid.Columns.Clear();
                RecordGrid.ClearSelection();
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "이름", "std_name", true, 80);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "국어", "sch_korean", true, 100);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "영어", "sch_english", true, 100);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "수학", "sch_math", true, 100);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "평균", "avg", true, 100);
                RecordGrid.Columns[4].DefaultCellStyle.BackColor = Color.Yellow; //평균 컬럼은 노란색으로

                SchoolRecordInfoDAC DAC = new SchoolRecordInfoDAC();
                DataSet ds = DAC.GetSchoolRecordByScore(cmbGrade.SelectedItem.ToString(), cmbSemester.SelectedItem.ToString());
                RecordGrid.DataSource = ds.Tables[0];

                DAC.Dispose();
            }
            else if (radiobtnMock.Checked == true) //모의고사성적
            {
                if (cmbGrade.SelectedItem is null)
                {
                    MaterialMessageBox.Show("학년을 선택해주세요.", "경고", MessageBoxButtons.OK);
                    return;
                }

                if (cmbSemester.SelectedItem is null)
                {
                    MaterialMessageBox.Show("월을 선택해주세요.", "경고", MessageBoxButtons.OK);
                    return;
                }
                RecordGrid.Columns.Clear();
                RecordGrid.ClearSelection();
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "이름", "std_name", true, 70);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "국어", "sch_korean", true, 60);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "영어", "sch_english", true, 60);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "수학", "sch_math", true, 60);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "사회/과학1", "side_choice1", true, 85);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "사회/과학2", "side_choice2", true, 85);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "제2외국어", "more_foreign", true, 80);
                UtilityClass.AddNewColumnToDataGridView(RecordGrid, "평균", "avg", true, 80);
                RecordGrid.Columns[7].DefaultCellStyle.BackColor = Color.Yellow;


                SchoolRecordInfoDAC DAC = new SchoolRecordInfoDAC();
                DataSet ds = DAC.GetMockRecordByScore(cmbGrade.SelectedItem.ToString(), cmbSemester.SelectedItem.ToString());
                RecordGrid.DataSource = ds.Tables[0];

                DAC.Dispose();
            }
        }

        #endregion

        #region 엑셀저장
        private void BtnEcxel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            int i, j;

            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                for (i = 0; i <= RecordGrid.RowCount-1; i++)
                {
                    for (j = 0; j <= RecordGrid.ColumnCount-1; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = RecordGrid[j, i].Value.ToString();
                    }
                }

                xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
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
    }
    #endregion

}
