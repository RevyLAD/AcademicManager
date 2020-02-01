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

    public struct StudentDetailInfoVO
    {
        public string Id;
        public string Zipcode;
        public string Address1;
        public string Address2;
        public string FreeStudy;
        public string MoreStudy;
        public string Academy;
        public string Major;
        public string Job;
        public string Hobby;
        public string Circle;
        public string Note;


        public StudentDetailInfoVO(string Id, string Zipcode, string Address1, string Address2, string FreeStudy, string MoreStudy, string Academy,
            string Major, string Job, string Hobby, string Circle, string Note)
        {
            this.Id = Id;
            this.Zipcode = Zipcode;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.FreeStudy = FreeStudy;
            this.MoreStudy = MoreStudy;
            this.Academy = Academy;
            this.Major = Major;
            this.Job = Job;
            this.Hobby = Hobby;
            this.Circle = Circle;
            this.Note = Note;
        }
    }
    public class StudentDetailInfoDAC : IDisposable
    {
        MySqlConnection conn;

        public StudentDetailInfoDAC()
        {
            string strConn = ConfigurationManager.ConnectionStrings["AcademicProject"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();

        }

        #region FillParameters
        private void FillParameters(MySqlCommand cmd, StudentDetailInfoVO stdDetail)
        {
            MySqlParameter param1 = new MySqlParameter("std_zipcode", MySqlDbType.VarChar, 10);
            param1.Value = stdDetail.Zipcode;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("std_address1", MySqlDbType.VarChar, 100);
            param2.Value = stdDetail.Address1;
            cmd.Parameters.Add(param2);

            MySqlParameter param3 = new MySqlParameter("std_address2", MySqlDbType.VarChar, 100);
            param3.Value = stdDetail.Address2;
            cmd.Parameters.Add(param3);

            MySqlParameter param4 = new MySqlParameter("free_study", MySqlDbType.VarChar, 1);
            param4.Value = stdDetail.FreeStudy;
            cmd.Parameters.Add(param4);

            MySqlParameter param5 = new MySqlParameter("more_study", MySqlDbType.VarChar, 1);
            param5.Value = stdDetail.MoreStudy;
            cmd.Parameters.Add(param5);

            MySqlParameter param6 = new MySqlParameter("academy", MySqlDbType.VarChar, 1);
            param6.Value = stdDetail.Academy;
            cmd.Parameters.Add(param6);

            MySqlParameter param7 = new MySqlParameter("major", MySqlDbType.VarChar, 50);
            param7.Value = stdDetail.Major;
            cmd.Parameters.Add(param7);

            MySqlParameter param8 = new MySqlParameter("job", MySqlDbType.VarChar, 50);
            param8.Value = stdDetail.Job;
            cmd.Parameters.Add(param8);

            MySqlParameter param9 = new MySqlParameter("hobby", MySqlDbType.VarChar, 50);
            param9.Value = stdDetail.Hobby;
            cmd.Parameters.Add(param9);

            MySqlParameter param10 = new MySqlParameter("circles", MySqlDbType.VarChar, 50);
            param10.Value = stdDetail.Circle;
            cmd.Parameters.Add(param10);

            MySqlParameter param11 = new MySqlParameter("note", MySqlDbType.VarChar, 500);
            param11.Value = stdDetail.Note;
            cmd.Parameters.Add(param11);

            MySqlParameter param12 = new MySqlParameter("std_id", MySqlDbType.VarChar, 10);
            param12.Value = stdDetail.Id;
            cmd.Parameters.Add(param12);
        }
        #endregion

        #region SaveToDB
        public void SaveToDB(StudentDetailInfoVO stdDetail)
        {
            string sql = "UPDATE Students SET std_zipcode=@std_zipcode, std_address1=@std_address1, std_address2=@std_address2, free_study=@free_study, more_study=@more_study, academy=@academy, " +
                "major=@major, job=@job, hobby=@hobby, circles=@circles, note=@note WHERE std_id=@std_id AND deleted = 0 ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, stdDetail);
            cmd.ExecuteNonQuery();
        }

        #endregion

        #region GetData
        public DataTable GetAll(string std_id)
        {
            DataTable dt = new DataTable();
            string sql = string.Format("select std_zipcode, std_address1, std_address2, free_study, more_study, academy, major, job, hobby, circles, note from Students where std_id='{0}' AND deleted = 0 ",std_id);
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
