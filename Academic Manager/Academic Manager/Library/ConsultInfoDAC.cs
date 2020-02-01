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
    public struct ConsultInfoVO
    {
        public int consult_id;
        public DateTime date;
        public string details;
        public string others;

        public ConsultInfoVO(int consult_id, DateTime date, string details, string others)
        {
            this.consult_id = consult_id;
            this.date = date;
            this.details = details;
            this.others = others;
        }
    }
    public class ConsultInfoDAC : IDisposable
    {
        MySqlConnection conn;

        public ConsultInfoDAC(MySqlConnection sqlConn)
        {
            conn = sqlConn;

        }
        #region FillParameters
        private void FillParameters(MySqlCommand cmd, ConsultInfoVO item, string std_id)
        {
            MySqlParameter param1 = new MySqlParameter("consult_date", MySqlDbType.DateTime);
            param1.Value = item.date;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("consult_details", MySqlDbType.VarChar, 1000);
            param2.Value = item.details;
            cmd.Parameters.Add(param2);

            MySqlParameter param3 = new MySqlParameter("others", MySqlDbType.VarChar,500);
            param3.Value = item.others;
            cmd.Parameters.Add(param3);


            MySqlParameter param4 = new MySqlParameter("std_id", MySqlDbType.VarChar, 10);
            param4.Value = std_id;
            cmd.Parameters.Add(param4);

            MySqlParameter param5 = new MySqlParameter("consult_id", MySqlDbType.Int32, 11);
            param5.Value = item.consult_id;
            cmd.Parameters.Add(param5);

        }
        #endregion

        #region Insert, Update, Delete 
        public void Insert(ConsultInfoVO item,string std_id)
        {
            string sql = "INSERT INTO Consult(std_id, consult_date, consult_details, others) VALUES(@std_id, @consult_date, @consult_details, @others) ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, item, std_id);
            cmd.ExecuteNonQuery();
        }

        public void Update(ConsultInfoVO item, string std_id)
        {
            string sql = "UPDATE Consult Set consult_date=@consult_date, consult_details=@consult_details, others=@others WHERE consult_id=@consult_id AND std_id=@std_id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, item, std_id);
            cmd.ExecuteNonQuery();
        }

        public void Delete(ConsultInfoVO item,string std_id)
        {
            string sql = "DELETE FROM Consult WHERE consult_id=@consult_id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, item, std_id);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region Get Data
        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            string sql = "select s.std_name std_name, consult_date, consult_details, others from Consult c INNER JOIN Students s ON s.std_id = c.std_id ";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "Consult");
            return ds;
        }

        public DataTable GetStudentConsult(string std_id)
        {

            DataTable dt = new DataTable();
            string sql = string.Format("select consult_id,consult_date, consult_details, others from Consult where std_id = '{0}' ",std_id) ;
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(dt);
            return dt;
        }
        #endregion
        public void Dispose()
        {
            conn.Close();
        }
    }
}
