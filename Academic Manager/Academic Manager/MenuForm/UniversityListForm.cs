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
    public partial class UniversityListForm : MetroForm
    {
        public UniversityListForm()
        {
            InitializeComponent();


        }

        private void UniversityListForm_Load(object sender, EventArgs e)
        {
            cmbFind.SelectedIndex = 0;
            //그리드속성
            UniversityGrid.AutoGenerateColumns = false;
            UniversityGrid.AllowUserToAddRows = false;
            UniversityGrid.MultiSelect = true;
            UniversityGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UniversityGrid.RowHeadersWidth = 15;
            UniversityGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UniversityGrid.ColumnHeadersHeight = 30;
            UniversityGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            UniversityGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            UtilityClass.AddNewColumnToDataGridView(UniversityGrid, "이름", "univ_name", true, 120);
            UtilityClass.AddNewColumnToDataGridView(UniversityGrid, "주소", "univ_address", true, 300);
            UtilityClass.AddNewColumnToDataGridView(UniversityGrid, "전화번호", "univ_phone", true, 100);
            UtilityClass.AddNewColumnToDataGridView(UniversityGrid, "홈페이지", "homepage", true, 160);

            LoadUnivData();
        }

        #region 대학정보 로드
        private void LoadUnivData()
        {
            UniversityInfoService dac = new UniversityInfoService();
            DataSet ds = dac.GetAllUniversity();
            UniversityGrid.DataSource = ds.Tables[0];
            dac.Dispose();
        }
        #endregion

        #region 더블클릭 이벤트 -> 홈페이지(웹브라우저)
        private void UniversityGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)UniversityGrid.DataSource;

            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                string url = dt.Rows[e.RowIndex]["homepage"].ToString(); //홈페이지 셀을 string으로 받기
                if (!string.IsNullOrEmpty(url))
                {

                    UniversityHomepageForm frm = new UniversityHomepageForm(url);
                    frm.Show();
                }
            }
        }
        #endregion

        #region 검색기능
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            UniversityGrid.ClearSelection();
            for (int i = 0; i < UniversityGrid.RowCount; i++)
            {
                if (UniversityGrid.Rows[i].Cells[0].Value.ToString() == txtFindName.Text.Trim())
                {
                    UniversityGrid.Rows[i].Selected = true;
                    UniversityGrid.CurrentCell = UniversityGrid.Rows[i].Cells[0];
                }
                
            }
            txtFindName.Text = "";

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

                for (i = 0; i <= UniversityGrid.RowCount-1; i++)
                {
                    for (j = 0; j <= UniversityGrid.ColumnCount - 1; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = UniversityGrid[j, i].Value.ToString();
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
