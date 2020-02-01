using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Configuration;

namespace Academic_Manager
{
    
    public partial class RoadSearchForm : MaterialSkin.Controls.MaterialForm
    {
        string zip = string.Empty;
        string addr1 = string.Empty;
        string addr2 = string.Empty;

        public string Zipcode { get { return this.zip; } }
        public string Address1 { get { return this.addr1; } }
        public string Address2 { get { return this.addr2; } }

        public RoadSearchForm()
        {
            InitializeComponent();
        }

        private void RoadSearchForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "우편번호", "zipNo", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주소1", "roadAddr", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주소2", "jibunAddr", true, 200);
        }



        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;

            if (e.RowIndex > -1 && e.RowIndex < dt.Rows.Count)
            {
                txtRoadZipCode.Text = txtJibunZipCode.Text = dt.Rows[e.RowIndex]["zipNo"].ToString();
                txtRoadAddr1.Text = dt.Rows[e.RowIndex]["roadAddrPart1"].ToString();
                txtRoadAddr2.Text = dt.Rows[e.RowIndex]["roadAddrPart2"].ToString();

                txtJibunAddr1.Text = dt.Rows[e.RowIndex]["jibunAddr"].ToString();
                txtJibunAddr2.Text = "";

                txtRoadAddr2.Enabled = txtJibunAddr2.Enabled = true;
            }
        }

        private void BtnRoad_Click(object sender, EventArgs e)
        {
            if (txtRoadAddr2.Text.Length > 0)
            {
                this.zip = txtRoadZipCode.Text;
                this.addr1 = txtRoadAddr1.Text;
                this.addr2 = txtRoadAddr2.Text;

                this.DialogResult = DialogResult.OK;
            }

            else
                MessageBox.Show("상세주소를 입력하여 주세요.");
        }

        private void BtnJibun_Click(object sender, EventArgs e)
        {
            if (txtJibunAddr2.Text.Length > 0)
            {
                this.zip = txtJibunZipCode.Text;
                this.addr1 = txtJibunAddr1.Text;
                this.addr2 = txtJibunAddr2.Text;

                this.DialogResult = DialogResult.OK;
            }

            else
                MessageBox.Show("상세주소를 입력하여 주세요.");
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    btnSearch.PerformClick();
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string currentPage = "1";
                string countPerPage = "1000";
                string confmKey = ConfigurationManager.AppSettings["LoadAPIKey"];
                string keyword = txtSearch.Text.Trim();
                string apiurl = string.Empty;

                apiurl = string.Format("http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage={0}&countPerPage={1}&keyword={2}&confmKey={3}"
                    , currentPage, countPerPage, keyword, confmKey);

                System.Diagnostics.Debug.WriteLine(apiurl + "\r\n");
                //string sss = apiurl;
                WebClient wc = new WebClient();
                XmlReader read = new XmlTextReader(wc.OpenRead(apiurl));

                DataSet ds = new DataSet();
                ds.ReadXml(read);

                if (ds.Tables[0].Rows[0]["totalCount"].ToString() != "0")
                {
                    dataGridView1.DataSource = ds.Tables[1];
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
