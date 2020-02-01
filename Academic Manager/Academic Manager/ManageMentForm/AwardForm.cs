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
    public partial class AwardForm : MetroForm
    {
        DataTable dt;
        public AwardForm(string std_id, string std_name)
        {
            InitializeComponent();


            this.lblStudentID.Text = std_id;
            this.lblStudentName.Text = std_name;
        }

        private void AwardForm_Load(object sender, EventArgs e)
        {
            //대회정보 그리드뷰
            CompetitionGrid.AutoGenerateColumns = false;
            CompetitionGrid.AllowUserToAddRows = false;
            CompetitionGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            CompetitionGrid.RowHeadersWidth = 15;
            CompetitionGrid.ColumnHeadersHeight = 30;
            CompetitionGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CompetitionGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            CompetitionGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            UtilityClass.AddNewColumnToDataGridView(CompetitionGrid, "코드", "competition_id", true, 70);
            UtilityClass.AddNewColumnToDataGridView(CompetitionGrid, "이름", "comp_name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(CompetitionGrid, "설명", "comp_details", true, 200);
            UtilityClass.AddNewColumnToDataGridView(CompetitionGrid, "날짜", "comp_date", true, 100);
            UtilityClass.AddNewColumnToDataGridView(CompetitionGrid, "주최", "comp_host", true, 80);
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "선택";
            btn.Text = "선택";
            btn.Name = "btnSelect";
            btn.Width = 40;
            btn.DefaultCellStyle.Padding = new Padding(0, -10, 0, -10);
            btn.UseColumnTextForButtonValue = true;
            CompetitionGrid.Columns.Add(btn);
            LoadCompetitionData();

            // 수상내역 그리드뷰 
            AwardGrid.AutoGenerateColumns = false;
            AwardGrid.AllowUserToAddRows = true;
            AwardGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AwardGrid.RowHeadersWidth = 15;
            AwardGrid.ColumnHeadersHeight = 30;
            AwardGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            AwardGrid.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.5F);

            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "수상코드", "award_id", false, 30);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "대회코드", "competition_id", false, 30);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "대회이름", "comp_name", true, 130);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "대회설명", "comp_details", true, 200);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "수상내역", "award_details", true, 100);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "날짜", "comp_date", true, 100);
            UtilityClass.AddNewColumnToDataGridView(AwardGrid, "주최", "comp_host", true, 100);

            LoadAwardData();

            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.AwardGrid.DataSource = this.bindingSource1;
            this.txtAwardID.DataBindings.Add("Text", this.bindingSource1, "award_id");
            this.txtCompetitionID.DataBindings.Add("Text", this.bindingSource1, "competition_id");
            this.txtCompetitionName.DataBindings.Add("Text", this.bindingSource1, "comp_name");
            this.txtCompetitionDetails.DataBindings.Add("Text", this.bindingSource1, "comp_details");
            this.txtAwarddetails.DataBindings.Add("Text", this.bindingSource1, "award_details");
            this.txtCompetitionDate.DataBindings.Add("Text", this.bindingSource1, "comp_date");
            this.txtCompetitionHost.DataBindings.Add("Text", this.bindingSource1, "comp_host");


        }


        #region 수상내역, 대회정보 로드
        private void LoadCompetitionData()
        {
            CompetitionInfoService dac = new CompetitionInfoService();
            DataTable dt1 = dac.GetAll();
            CompetitionGrid.DataSource = dt1;
            dac.Dispose();

        }

        private void LoadAwardData()
        {
            CompetitionInfoService dac = new CompetitionInfoService();
            dt = dac.GetAwardByStudent(lblStudentID.Text);
            AwardGrid.DataSource = dt;
            dac.Dispose();
            this.bindingSource1.DataSource = dt;
        }
        #endregion

        #region BindingNavigator Set, Save
        private CompetitionInfoVO SetAwardInfoVo(DataRow dr)
        {
            CompetitionInfoVO item = new CompetitionInfoVO();
            item.award_id = Convert.ToInt32(dr["award_id"]);
            item.competition_id = dr["competition_id"].ToString();
            item.comp_date = Convert.ToDateTime(dr["comp_date"]);
            item.comp_name = dr["comp_name"].ToString();
            item.comp_details = dr["comp_details"].ToString();
            item.award_details = dr["award_details"].ToString();
            item.comp_host = dr["comp_host"].ToString();
            return item;
        }
        private CompetitionInfoVO SetInsertAwardInfoVo(DataRow dr)
        {
            CompetitionInfoVO item = new CompetitionInfoVO();
            item.competition_id = dr["competition_id"].ToString();
            item.comp_date = Convert.ToDateTime(dr["comp_date"]);
            item.comp_name = dr["comp_name"].ToString();
            item.comp_details = dr["comp_details"].ToString();
            item.award_details = dr["award_details"].ToString();
            item.comp_host = dr["comp_host"].ToString();
            return item;
        }


        private CompetitionInfoVO SetDelAwardInfoVo(DataRow dr)
        {
            CompetitionInfoVO item = new CompetitionInfoVO();
            item.award_id = Convert.ToInt32(dr["award_id", DataRowVersion.Original]);
            item.competition_id = dr["competition_id",DataRowVersion.Original].ToString();
            item.comp_date = Convert.ToDateTime(dr["comp_date", DataRowVersion.Original]);
            item.comp_name = dr["comp_name", DataRowVersion.Original].ToString();
            item.comp_details = dr["comp_details", DataRowVersion.Original].ToString();
            item.award_details = dr["award_details", DataRowVersion.Original].ToString();
            item.comp_host = dr["comp_host", DataRowVersion.Original].ToString();
            return item;
        }

        //네비게이터의 저장버튼
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if(AwardGrid.Rows.Count==0)
            {

                if (string.IsNullOrEmpty(txtAwarddetails.Text) && AwardGrid.Rows.Count > 0)
                {
                    MaterialMessageBox.Show("수상내역을 입력해주세요.", "경고", MessageBoxButtons.OK);
                    return;
                }
            }
            CompetitionInfoService service = new CompetitionInfoService();
            try
            {
                
                DataRow[] insRows = dt.Select(null, null, DataViewRowState.Added);
                foreach (DataRow dr in insRows)
                {
                    CompetitionInfoVO item = SetInsertAwardInfoVo(dr);
                    service.Insert(item, lblStudentID.Text);

                }
                DataRow[] upsRows = dt.Select(null, null, DataViewRowState.ModifiedCurrent);

                foreach (DataRow dr in upsRows)
                {
                    CompetitionInfoVO item = SetAwardInfoVo(dr);
                    service.Update(item,lblStudentID.Text);
                }


                DataRow[] delRows = dt.Select(null, null, DataViewRowState.Deleted);

                foreach (DataRow dr in delRows)
                {
                    CompetitionInfoVO item = SetDelAwardInfoVo(dr);
                    service.Delete(item, lblStudentID.Text);
                }
                
                MaterialMessageBox.Show("저장완료", "확인", MessageBoxButtons.OK);

            }
            catch (InvalidCastException)
            {
                MaterialMessageBox.Show("항목을 입력해주세요", "경고", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MaterialMessageBox.Show(err.Message,"경고",MessageBoxButtons.OK);
            }
            finally
            {
                service.Dispose();
            }

        }
        #endregion

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }

        //private void VisibleControl(bool bCheck)
        //{
        //    foreach (var control in this.panel1.Controls)
        //    {
        //        if (control is Label)
        //        {
        //            Label temp = (Label)control;
        //            if (temp.Visible == !bCheck)
        //            {
        //                temp.Visible = bCheck;
        //            }
        //        }

        //        if (control is TextBox)
        //        {
        //            TextBox temp = (TextBox)control;
        //            if (temp.Visible == !bCheck)
        //            {
        //                temp.Visible = bCheck;
        //            }
        //        }
        //    }
        //}

        private void CompetitionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                txtCompetitionID.Text = CompetitionGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCompetitionName.Text = CompetitionGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCompetitionDetails.Text = CompetitionGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCompetitionDate.Text = CompetitionGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCompetitionHost.Text = CompetitionGrid.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }
    }
    
}
