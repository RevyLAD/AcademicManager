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
    public struct CompetitionInfoVO
    {
        public int award_id;
        public string competition_id;
        public string comp_name;
        public string comp_details;
        public string award_details;
        public DateTime comp_date;
        public string comp_host;


        public CompetitionInfoVO(int award_id, string competition_id, string comp_name, string comp_details, string award_details, DateTime comp_date, string comp_host)
        {
            this.award_id = award_id;
            this.competition_id = competition_id;
            this.comp_name = comp_name;
            this.comp_details = comp_details;
            this.award_details = award_details;
            this.comp_date = comp_date;
            this.comp_host = comp_host;
        }
    }
    public class CompetitionInfoDAC :IDisposable
    {
        MySqlConnection conn;

        public CompetitionInfoDAC(MySqlConnection strConn)
        {
            conn = strConn;
        }

        #region FillParameters
        private void FillParameters(MySqlCommand cmd, CompetitionInfoVO item, string std_id)
        {
            MySqlParameter param1 = new MySqlParameter("std_id", MySqlDbType.VarChar,10);
            param1.Value = std_id;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("competition_id", MySqlDbType.VarChar, 10);
            param2.Value = item.competition_id;
            cmd.Parameters.Add(param2);

            MySqlParameter param3 = new MySqlParameter("award_details", MySqlDbType.VarChar, 10);
            param3.Value = item.award_details;
            cmd.Parameters.Add(param3);


            MySqlParameter param4 = new MySqlParameter("award_id", MySqlDbType.Int32);
            param4.Value = item.award_id;
            cmd.Parameters.Add(param4);


        }
        #endregion

        #region Insert, Update, Delete
        public void Insert(CompetitionInfoVO item, string std_id)
        {
            string sql = "INSERT INTO Awards(std_id, competition_id, award_details) VALUES(@std_id, @competition_id, @award_details) ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, item, std_id);
            cmd.ExecuteNonQuery();
        }

        public void Update(CompetitionInfoVO item, string std_id)
        {
            string sql = "UPDATE Awards Set competition_id=@competition_id, award_details=@award_details WHERE award_id=@award_id AND std_id=@std_id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, item, std_id);
            cmd.ExecuteNonQuery();
        }
        public void Delete(CompetitionInfoVO item, string std_id)
        {
            string sql = "DELETE FROM Awards WHERE award_id=@award_id";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, item, std_id);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region Get Data
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            string sql = "select competition_id, comp_name, comp_details, comp_date, comp_host from Competition ";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(dt);
            return dt;
        }

        public DataTable GetAwardByStudent(string std_id)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("SELECT award_id, a.competition_id, comp_name, comp_details, award_details, comp_date, comp_host from Awards a INNER JOIN Competition c ON a.competition_id = c.competition_id " +
                "WHERE a.std_id ='{0}' ",std_id);
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
