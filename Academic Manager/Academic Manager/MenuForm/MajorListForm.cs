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
    public partial class MajorListForm : MetroForm
    {
        string name = string.Empty;


        public string MajorName { get { return this.name; } }

        public MajorListForm()
        {
            InitializeComponent();

            //그리드속성
            MajorGrid.AutoGenerateColumns = false;
            MajorGrid.AllowUserToAddRows = false;
            MajorGrid.MultiSelect = true;
            MajorGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MajorGrid.RowHeadersWidth = 15;
            MajorGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MajorGrid.ColumnHeadersHeight = 30;
            MajorGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            MajorGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(MajorGrid, "대분류", "high_name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(MajorGrid, "중분류", "mid_name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(MajorGrid, "학과이름", "major_name", true, 200);

            LoadMajorData();
        }

        #region 학과목록 로드
        private void LoadMajorData()
        {
            MajorInfoDAC dac = new MajorInfoDAC();
            DataSet ds = dac.GetAll();
            MajorGrid.DataSource = ds.Tables[0];
            dac.Dispose();
        }
        #endregion

        #region 더블클릭 -> 상세정보등록
        private void MajorGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)MajorGrid.DataSource;
            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                this.name = dt.Rows[e.RowIndex]["major_name"].ToString();
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

                for (i = 0; i <= MajorGrid.RowCount-1; i++)
                {
                    for (j = 0; j <= MajorGrid.ColumnCount-1 ; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = MajorGrid[j, i].Value.ToString();
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
