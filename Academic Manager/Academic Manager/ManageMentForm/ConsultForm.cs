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

namespace Academic_Manager
{
    public partial class ConsultForm : MetroForm
    {
        DataTable dt;
        public ConsultForm(string std_id, string std_name)
        {
            InitializeComponent();


            this.lblStudentID.Text = std_id;
            this.lblStudentName.Text = std_name;
        }

        private void ConsultForm_Load(object sender, EventArgs e)
        {
            dtpConsult.Value = DateTime.Now;
            dtpConsult.Text = DateTime.Now.ToString();

            ConsultGrid.AutoGenerateColumns = false;
            ConsultGrid.AllowUserToAddRows = true;
            ConsultGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ConsultGrid.RowHeadersWidth = 15;
            ConsultGrid.ColumnHeadersHeight = 30;
            ConsultGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            ConsultGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "상담번호", "consult_id", false, 10);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "상담날짜", "consult_date", true, 120);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "상담내용", "consult_details", true, 300);
            UtilityClass.AddNewColumnToDataGridView(ConsultGrid, "조치사항", "others", true, 270);

            LoadData();


            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.ConsultGrid.DataSource = this.bindingSource1;
            this.dtpConsult.DataBindings.Add("Text", this.bindingSource1, "consult_date");
            this.txtConsultContent.DataBindings.Add("Text", this.bindingSource1, "consult_details");
            this.txtConsultFeedBack.DataBindings.Add("Text", this.bindingSource1, "others");
        }


        #region 상담내역 로드
        private void LoadData()
        {
            ConsultInfoService service = new ConsultInfoService();
            dt = service.GetStudentConsult(lblStudentID.Text);
            ConsultGrid.DataSource = service.GetStudentConsult(lblStudentID.Text);
            service.Dispose();
            //dt = new DataTable();

            this.bindingSource1.DataSource = dt;
        }
        #endregion

        #region BindingNavigator  Set, Save 
        private ConsultInfoVO SetConsultInfoVo1(DataRow dr)
        {
            ConsultInfoVO item = new ConsultInfoVO();
            item.date = Convert.ToDateTime(dr["consult_date"]);
            item.details = dr["consult_details"].ToString();
            item.others = dr["others"].ToString();
            return item;
        }

        private ConsultInfoVO SetConsultInfoVo(DataRow dr)
        {
            ConsultInfoVO item = new ConsultInfoVO();
            item.consult_id = Convert.ToInt32(dr["consult_id"]);
            item.date = Convert.ToDateTime(dr["consult_date"]);
            item.details = dr["consult_details"].ToString();
            item.others = dr["others"].ToString();
            return item;
        }

        private ConsultInfoVO SetDelConsultInfoVo(DataRow dr)
        {
            ConsultInfoVO item = new ConsultInfoVO();
            item.consult_id = Convert.ToInt32(dr["consult_id", DataRowVersion.Original]);
            item.date = Convert.ToDateTime(dr["consult_date",DataRowVersion.Original]);
            item.details = dr["consult_details", DataRowVersion.Original].ToString();
            item.others = dr["others", DataRowVersion.Original].ToString();
            return item;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ConsultInfoService service = new ConsultInfoService();

            try
            {
                DataRow[] insRows = dt.Select(null, null, DataViewRowState.Added);
                foreach (DataRow dr in insRows)
                {
                    ConsultInfoVO item = SetConsultInfoVo1(dr);
                    service.Insert(item, lblStudentID.Text);

                }
                DataRow[] upsRows = dt.Select(null, null, DataViewRowState.ModifiedCurrent);

                foreach (DataRow dr in upsRows)
                {
                    ConsultInfoVO item = SetConsultInfoVo(dr);
                    service.Update(item, lblStudentID.Text);
                }

                DataRow[] delRows = dt.Select(null, null, DataViewRowState.Deleted);

                foreach (DataRow dr in delRows)
                {
                    ConsultInfoVO item = SetDelConsultInfoVo(dr);
                    service.Delete(item, lblStudentID.Text);
                }

                MaterialMessageBox.Show("저장완료", "확인", MessageBoxButtons.OK);
            }
            catch(InvalidCastException)
            {

                MaterialMessageBox.Show("항목을 입력해주세요", "경고", MessageBoxButtons.OK);
            }
            catch(Exception err2)
            {
                MaterialMessageBox.Show(err2.Message, "경고", MessageBoxButtons.OK);
            }
            finally
            {
                service.Dispose();
            }



        }
        #endregion

    }
}
