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
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace Academic_Manager
{
    public partial class JobListForm : MetroForm
    {
        string name = string.Empty;


        public string jobName { get { return this.name; } }

        public JobListForm()
        {
            InitializeComponent();

            //그리드속성
            JobGrid.AutoGenerateColumns = false;
            JobGrid.AllowUserToAddRows = false;
            JobGrid.MultiSelect = true;
            JobGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            JobGrid.RowHeadersWidth = 15;
            JobGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            JobGrid.ColumnHeadersHeight = 30;
            JobGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            JobGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(JobGrid, "직업코드", "job_id", true, 80);
            UtilityClass.AddNewColumnToDataGridView(JobGrid, "국문명", "job_Kname", true, 200);
            UtilityClass.AddNewColumnToDataGridView(JobGrid, "영문명", "job_Ename", true, 250);

            LoadJabData();
        }

        #region 직업목록 로드
        private void LoadJabData()
        {
            JobInfoDAC jobDB = new JobInfoDAC();
            DataSet ds = jobDB.GetAll();
            JobGrid.DataSource = ds.Tables[0];
            jobDB.Dispose();
        }
        #endregion

        #region 더블클릭 이벤트 -> 학생상세정보 등록
        private void JobGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)JobGrid.DataSource;
            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                this.name = dt.Rows[e.RowIndex]["job_Kname"].ToString();
                this.DialogResult = DialogResult.OK;
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

                for (i = 0; i <= JobGrid.RowCount-1 ; i++)
                {
                    for (j = 0; j <= JobGrid.ColumnCount-1 ; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = JobGrid[j, i].Value.ToString();
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

        #endregion
    }

}
