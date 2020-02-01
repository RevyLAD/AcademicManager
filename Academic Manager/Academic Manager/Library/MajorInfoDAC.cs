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
    public struct MajorInfo
    {
        public string highName;
        public string midName;
        public string majorName;

        public MajorInfo(string highName, string midName, string majorName)
        {
            this.highName = highName;
            this.midName = midName;
            this.majorName = majorName;
        }
    }
    public class MajorInfoDAC
    {
        MySqlConnection conn;

        public MajorInfoDAC()
        {
            string strConn = ConfigurationManager.ConnectionStrings["AcademicProject"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();

        }

        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT high_name, mid_name,major_name FROM Major_high h, Major_middle m, Major major " +
                "WHERE h.high_id = m.high_id " +
                "AND m.mid_id = major.mid_id ";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "Major");
            return ds;
        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
