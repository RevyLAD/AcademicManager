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
    public partial class ConsultListForm : MetroForm
    {

        public ConsultListForm()
        {
            InitializeComponent();

            //그리드속성
            ConsultGrid.AutoGenerateColumns = false;
            ConsultGrid.AllowUserToAddRows = false;
            ConsultGrid.MultiSelect = true;
            ConsultGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ConsultGrid.RowHeadersWidth = 15;
            ConsultGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ConsultGrid.ColumnHeadersHeight = 30;
            ConsultGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            ConsultGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "이름", "std_name", true, 80);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "상담날짜", "consult_date", true, 100);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "상담내용", "consult_details", true, 250);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "피드백", "others", true, 250);

            LoadConsultData();
        }

        #region 상담목록 로드
        private void LoadConsultData()
        {
            ConsultInfoService dac = new ConsultInfoService();
            DataSet ds = dac.GetAll();
            ConsultGrid.DataSource = ds.Tables[0];
            dac.Dispose();
        }
        #endregion

        #region 더블클릭 이벤트 -> 상담 상세정보 확인
        private void ConsultGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)ConsultGrid.DataSource;
            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                ConsultDetailsForm frm = new ConsultDetailsForm();
                frm.Std_Name = ConsultGrid.SelectedRows[0].Cells[0].Value.ToString();
                frm.Date = ConsultGrid.SelectedRows[0].Cells[1].Value.ToString();
                frm.Detail = ConsultGrid.SelectedRows[0].Cells[2].Value.ToString();
                frm.FeedBack = ConsultGrid.SelectedRows[0].Cells[3].Value.ToString();
                frm.ShowDialog();
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

                for (i = 0; i <= ConsultGrid.RowCount-1 ; i++)
                {
                    for (j = 0; j <= ConsultGrid.ColumnCount-1 ; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = ConsultGrid[j, i].Value.ToString();
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


