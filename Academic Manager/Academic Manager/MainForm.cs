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
using System.IO;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
namespace Academic_Manager
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //그리드속성
            StudentGrid.AutoGenerateColumns = false;
            StudentGrid.AllowUserToAddRows = false;
            StudentGrid.MultiSelect = true;
            StudentGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentGrid.RowHeadersWidth = 15;
            StudentGrid.ColumnHeadersHeight = 30;
            StudentGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StudentGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            StudentGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);


            UtilityClass.AddNewColumnToDataGridView(StudentGrid, "학생ID", "std_id", true, 100);
            UtilityClass.AddNewColumnToDataGridView(StudentGrid, "이름", "std_name", true, 100);
            UtilityClass.AddNewColumnToDataGridView(StudentGrid, "핸드폰번호", "std_phone", true, 150);
            UtilityClass.AddNewColumnToDataGridView(StudentGrid, "이메일", "std_mail", true, 150);

            StudentGrid.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            StudentGrid.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            StudentGrid.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            StudentGrid.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;

            LoadStudentGridData();
            LoadStudentInfoData();
            LoadStudentImage();
            LoadStudentDetailInfoData();

            cmbFind.SelectedIndex = 0;
            cmbMain1.SelectedIndex = 1;
            cmbMain2.SelectedIndex = 1;
            cmbMain3.SelectedIndex = 1;
            cmbMain1.SelectedValue = 'N';
            cmbMain2.SelectedValue = 'N';
            cmbMain3.SelectedValue = 'N';
        }

        #region 중복로드 방지
        private bool FormOverFlowCheck(string frmName)
        {
            foreach (Form form in Application.OpenForms) //중복로드 방지
            {
                if (form.Name == frmName)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region 학생목록 불러오기
        private void LoadStudentGridData()
        {
            StudentInfoDAC stdDB = new StudentInfoDAC();
            DataSet ds = stdDB.GetAll();
            StudentGrid.DataSource = ds.Tables[0];
            stdDB.Dispose();
        }
        #endregion

        #region 학생기본정보 불러오기
        private void LoadStudentInfoData()
        {
            txtStudentID.Text = StudentGrid.SelectedRows[0].Cells[0].Value.ToString();
            txtStudentName.Text = StudentGrid.SelectedRows[0].Cells[1].Value.ToString();
            if (StudentGrid.SelectedRows[0].Cells[2].Value.ToString().Length > 12)
            {
                txtPhone1.Text = StudentGrid.SelectedRows[0].Cells[2].Value.ToString().Substring(0, 3);
                txtPhone2.Text = StudentGrid.SelectedRows[0].Cells[2].Value.ToString().Substring(4, 4);
                txtPhone3.Text = StudentGrid.SelectedRows[0].Cells[2].Value.ToString().Substring(9, 4);
            }
            else
            {
                txtPhone1.Text = "";
                txtPhone2.Text = "";
                txtPhone3.Text = "";
            }
            txtEmail.Text = StudentGrid.SelectedRows[0].Cells[3].Value.ToString();
        }
        #endregion

        #region 학생상세정보 불러오기
        private void LoadStudentDetailInfoData() // 학생 상세정보 로드 (기본정보X)
        {
            StudentDetailInfoDAC dac = new StudentDetailInfoDAC();
            DataTable dt = dac.GetAll(txtStudentID.Text);
            object[] Info = dt.Rows[0].ItemArray;

            this.addressUserControl2.Zipcode = Info[0].ToString();
            this.addressUserControl2.Address1 = Info[1].ToString();
            this.addressUserControl2.Address2 = Info[2].ToString();

            this.cmbMain1.DisplayMember = Info[3].ToString();
            this.cmbMain2.DisplayMember = Info[4].ToString();
            this.cmbMain3.DisplayMember = Info[5].ToString();

            this.txtMajor.Text = Info[6].ToString();
            this.txtJob.Text = Info[7].ToString();
            this.txtHobby.Text = Info[8].ToString();
            this.txtCircle.Text = Info[9].ToString();
            this.txtNote.Text = Info[10].ToString();
            dac.Dispose();
        }
        #endregion

        #region 이미지 저장, 불러오기, 파일열기
        private void LoadStudentImage()
        {
            try
            {

                StudentInfoDAC stdDB = new StudentInfoDAC();

                string image = stdDB.GetImage(txtStudentID.Text);
                if (image == "" || image == null)
                {
                    pictureBox1.Image = null;
                    return;
                }
                Image img;

                img = Image.FromFile(Application.StartupPath.Replace("\\", "/") + "/" + image);

                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                stdDB.Dispose();
            }
            catch
            {
                return;
            }

        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MaterialMessageBox.Show("저장하실 이미지 정보를 입력하여 주십시오", "오류", MessageBoxButtons.OK);
                return;
            }
            //Cursor currentCursor = this.Cursor;
            string destFile = string.Empty;
            string sPath = string.Empty;
            string sFileName = string.Empty;
            string sExt = string.Empty;

            try
            {
                //this.Cursor = Cursors.WaitCursor;
                StudentInfoDAC stdDB = new StudentInfoDAC();
                string localFile = pictureBox1.Tag.ToString().Replace("\\", "/");
                sPath = string.Format("studentImage/{0}/", txtStudentID.Text);
                sExt = localFile.Substring(localFile.LastIndexOf("."));
                sFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + txtStudentID.Text + sExt;

                DirectoryInfo di = new DirectoryInfo(sPath);
                if (di.Exists == false)
                {
                    di.Create();
                }
                // 현재 exe가 실행중인 경로에 생성
                destFile = Path.Combine(Environment.CurrentDirectory.Replace("\\", "/"), sPath, sFileName);
                File.Copy(pictureBox1.Tag.ToString(), destFile, true);

                stdDB.SaveImageFile(sPath, sFileName, txtStudentID.Text);
                stdDB.Dispose();
                MaterialMessageBox.Show("사진저장 완료", "확인", MessageBoxButtons.OK);


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                //this.Cursor = currentCursor;
            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            // Cursor currentCursor = this.Cursor;

            try
            {
                //this.Cursor = Cursors.WaitCursor;
                openFileDialog1.Title = "Select a Image File";
                openFileDialog1.InitialDirectory = "C:";
                openFileDialog1.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg;*.jpeg;*.gif;*.png;*.bmp";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Tag = openFileDialog1.FileName;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //this.Cursor = currentCursor;
            }
        }
        #endregion

        #region 클릭이벤트
        private void StudentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)StudentGrid.DataSource;

            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                txtStudentID.Text = dt.Rows[e.RowIndex]["std_id"].ToString();
                txtStudentName.Text = dt.Rows[e.RowIndex]["std_name"].ToString();
                if (dt.Rows[e.RowIndex]["std_phone"].ToString().Length > 12)
                {
                    txtPhone1.Text = StudentGrid.SelectedRows[0].Cells[2].Value.ToString().Substring(0, 3);
                    txtPhone2.Text = StudentGrid.SelectedRows[0].Cells[2].Value.ToString().Substring(4, 4);
                    txtPhone3.Text = StudentGrid.SelectedRows[0].Cells[2].Value.ToString().Substring(9, 4);
                }
                else
                {
                    txtPhone1.Text = "";
                    txtPhone2.Text = "";
                    txtPhone3.Text = "";
                }
                txtEmail.Text = dt.Rows[e.RowIndex]["std_mail"].ToString();

            }

            LoadStudentImage();
            LoadStudentDetailInfoData();
        }

        private void StudentGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                StudentGrid.Rows[e.RowIndex].Selected = true;
                StudentGrid.CurrentCell = StudentGrid.Rows[e.RowIndex].Cells[1];
                metroContextMenu1.Show(StudentGrid, e.Location);
                metroContextMenu1.Show(Cursor.Position);
            }
        }

        #endregion

        #region 학생 신규등록, 수정, 삭제, 검색
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            StudentInfoInsUpForm frm = new StudentInfoInsUpForm(StudentInfoInsUpForm.EditMode.Input);

            try
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    StudentInfoDAC stdDB = new StudentInfoDAC();
                    stdDB.Insert(frm.StudentInfo);
                    stdDB.Dispose();
                    MaterialMessageBox.Show("신규등록이 완료되었습니다.", "확인", MessageBoxButtons.OK);
                    LoadStudentGridData();
                    LoadStudentInfoData();
                    LoadStudentImage();
                    LoadStudentDetailInfoData();
                }
            }
            catch (Exception err)
            {
                MetroFramework.MetroMessageBox.Show(this, err.Message, "경고");
            }

        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfoInsUpForm frm = new StudentInfoInsUpForm(StudentInfoInsUpForm.EditMode.Update);

            try
            {
                Student stu;
                stu.ID = StudentGrid[0, StudentGrid.CurrentRow.Index].Value.ToString();
                stu.Name = StudentGrid[1, StudentGrid.CurrentRow.Index].Value.ToString();
                stu.Phone = StudentGrid[2, StudentGrid.CurrentRow.Index].Value.ToString();
                stu.Email = StudentGrid[3, StudentGrid.CurrentRow.Index].Value.ToString();
                frm.StudentInfo = stu;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    StudentInfoDAC stdDB = new StudentInfoDAC();
                    stdDB.Update(frm.StudentInfo);
                    stdDB.Dispose();
                    LoadStudentGridData();
                    LoadStudentInfoData();
                    LoadStudentImage();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = string.Format("{0} 학생을 삭제하시겠습니까?",
                   StudentGrid[1, StudentGrid.CurrentRow.Index].Value.ToString());

            try
            {
                if (MaterialMessageBox.Show(msg, "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string stuID = StudentGrid[0, StudentGrid.CurrentRow.Index].Value.ToString();
                    StudentInfoDAC stdDB = new StudentInfoDAC();
                    stdDB.Delete(stuID);
                    stdDB.Dispose();
                    LoadStudentGridData();
                    LoadStudentInfoData();
                    LoadStudentImage();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

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
                    LoadStudentInfoData();
                    LoadStudentDetailInfoData();
                    LoadStudentImage();
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

        #region 상단메뉴관리
        private void 대학리스트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("UniversityListForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }

            UniversityListForm frm = new UniversityListForm();
            frm.Show();
        }

        private void 상담현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("ConsultListForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            ConsultListForm frm = new ConsultListForm();
            frm.Show();
        }

        private void 학생별성적조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("RecordByStudentForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            RecordByStudentForm frm = new RecordByStudentForm();
            frm.Show();
        }

        private void 성적순조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("RecordByScoreForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            RecordByScoreForm frm = new RecordByScoreForm();
            frm.Show();
        }

        private void 학과리스트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("MajorListForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            MajorListForm frm = new MajorListForm();
            frm.Show();
        }

        private void 직업리스트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("JobListForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            JobListForm frm = new JobListForm();
            frm.Show();
        }
        #endregion

        #region 타일버튼클릭 (성적관리, 상담관리, 수상내역관리, 대입분석, 종합데이터)
        private void TileScore_Click(object sender, EventArgs e)
        {

            string school = "내신";

            SchoolOrMockForm frm = new SchoolOrMockForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.ReturnData().CompareTo(school) == 0)
                {
                    SchoolRecord schoolFrm = new SchoolRecord(txtStudentID.Text, txtStudentName.Text);
                    schoolFrm.Show();
                }
                else
                {
                    MockRecords mockFrm = new MockRecords(txtStudentID.Text, txtStudentName.Text);
                    mockFrm.Show();
                }

            }
        }

        private void TileConsult_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("ConsultForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            ConsultForm frm = new ConsultForm(txtStudentID.Text, txtStudentName.Text);
            frm.Show();
        }

        private void TileAward_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("AwardForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            AwardForm frm = new AwardForm(txtStudentID.Text, txtStudentName.Text);
            frm.Show();
        }

        private void TileAllData_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("AllInfoForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            AllInfoForm frm = new AllInfoForm(txtStudentID.Text, txtStudentName.Text);
            frm.Show();
        }

        private void TileUniversity_Click(object sender, EventArgs e)
        {
            bool bCheck = FormOverFlowCheck("UniversityForm");
            if (!bCheck)
            {

                MaterialMessageBox.Show("이미열려있는 화면입니다.", "경고", MessageBoxButtons.OK);
                return;
            }
            UniversityForm frm = new UniversityForm(txtStudentID.Text, txtStudentName.Text);
            frm.Show();
        }

        #endregion

        #region 버튼클릭리스너
        private void BtnJobSearch_Click(object sender, EventArgs e)
        {

            JobListForm frm = new JobListForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtJob.Text = frm.jobName;
            }
        }

        private void BtnMajorSearch_Click(object sender, EventArgs e)
        {

            MajorListForm frm = new MajorListForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtMajor.Text = frm.MajorName;
            }
        }

        private void TileUpdate_Click(object sender, EventArgs e) //Enabled True 변경
        {
            bool bCheck = true;
            EnabledControl(bCheck);
        }

        private void EnabledControl(bool bCheck) //수정 삭제시 Enabled 조정하는 함수
        {
            btnOpenFile.Enabled = bCheck;
            btnSaveFile.Enabled = bCheck;
            addressUserControl2.Enabled = bCheck;

            foreach (var control in this.panel1.Controls)
            {
                if (control is TextBox)
                {
                    TextBox temp = (TextBox)control;
                    if (temp.Enabled == !bCheck)
                    {
                        temp.Enabled = bCheck;
                    }
                }

                if (control is ComboBox)
                {
                    ComboBox temp = (ComboBox)control;
                    if (temp.Enabled == !bCheck)
                    {
                        temp.Enabled = bCheck;
                    }
                }

                if (control is Button)
                {
                    Button temp = (Button)control;
                    if (temp.Enabled == !bCheck)
                    {
                        temp.Enabled = bCheck;
                    }
                }
            }
        }

        private void TileSave_Click(object sender, EventArgs e)
        {

            StudentDetailInfoVO stdDetail;

            StudentDetailInfoDAC dac = new StudentDetailInfoDAC();

            stdDetail.Id = txtStudentID.Text;
            stdDetail.Zipcode = addressUserControl2.Zipcode.Trim();
            stdDetail.Address1 = addressUserControl2.Address1.Trim();
            stdDetail.Address2 = addressUserControl2.Address2.Trim();
            stdDetail.FreeStudy = cmbMain1.SelectedItem.ToString();
            stdDetail.MoreStudy = cmbMain2.SelectedItem.ToString();
            stdDetail.Academy = cmbMain3.SelectedItem.ToString();
            stdDetail.Major = txtMajor.Text.Trim();
            stdDetail.Job = txtJob.Text.Trim();
            stdDetail.Hobby = txtHobby.Text.Trim();
            stdDetail.Circle = txtCircle.Text.Trim();
            stdDetail.Note = txtNote.Text.Trim();

            dac.SaveToDB(stdDetail);
            dac.Dispose();

            MaterialMessageBox.Show("저장되었습니다.", "저장", MessageBoxButtons.OK);
            LoadStudentDetailInfoData();

            bool bCheck = false;
            EnabledControl(bCheck);

        }
        #endregion

        #region 엑셀저장
        //엑셀로 저장
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

                for (i = 0; i <= StudentGrid.RowCount - 1; i++)
                {
                    for (j = 0; j <= StudentGrid.ColumnCount - 1; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = StudentGrid[j, i].Value.ToString();
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
