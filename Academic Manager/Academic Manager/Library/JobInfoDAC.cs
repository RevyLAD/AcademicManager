using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Academic_Manager
{
    public struct Job
    {
        public string Code;
        public string Kname;
        public string Ename;

        public Job(string Code, string Kname, string Ename)
        {
            this.Code = Code;
            this.Kname = Kname;
            this.Ename = Ename;
        }
    }
    public class JobInfoDAC : IDisposable
    {
        MySqlConnection conn;

        public JobInfoDAC()
        {
            string strConn = ConfigurationManager.ConnectionStrings["AcademicProject"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();

        }

        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            string sql = "select job_id, job_Kname, job_Ename from Job ";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "Job");
            return ds;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
