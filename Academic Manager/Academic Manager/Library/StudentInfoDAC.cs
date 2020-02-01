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
    public struct Student
    {
        public string ID;
        public string Name;
        public string Phone;
        public string Email;

        public Student(string ID, string Name, string Phone, string Email)
        {
            this.ID = ID;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
        }
    }
    public class StudentInfoDAC : IDisposable
    {
        MySqlConnection conn;

        public StudentInfoDAC()
        {
            string strConn = ConfigurationManager.ConnectionStrings["AcademicProject"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();

        }

        #region FillParameters
        private void FillParameters(MySqlCommand cmd, Student std)
        {
            MySqlParameter param1 = new MySqlParameter("std_id", MySqlDbType.VarChar, 10);
            param1.Value = std.ID;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("std_name", MySqlDbType.VarChar, 10);
            param2.Value = std.Name;
            cmd.Parameters.Add(param2);

            MySqlParameter param3 = new MySqlParameter("std_phone", MySqlDbType.VarChar, 20);
            param3.Value = std.Phone;
            cmd.Parameters.Add(param3);

            MySqlParameter param4 = new MySqlParameter("std_mail", MySqlDbType.VarChar, 50);
            param4.Value = std.Email;
            cmd.Parameters.Add(param4);
        }
        #endregion

        #region Insert, Update, Delete, SaveImage
        public void Insert(Student std)
        {
            if(InsertKeyCheck(std.ID))
            {
                throw new Exception("이미 존재하는 ID입니다.");
            }
         
            string sql = "INSERT INTO Students(std_id, std_name, std_phone, std_mail) values(@std_id, @std_name, @std_phone, @std_mail) ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, std);
            cmd.ExecuteNonQuery();


        }
        public bool InsertKeyCheck(string stdID)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = string.Format("SELECT COUNT(*) FROM Students WHERE std_id='{0}' ", stdID);
            cmd.Connection = conn;
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            else
                return true;
        }


        public void Update(Student std)
        {
            string sql = "UPDATE Students SET std_name=@std_name, std_phone=@std_phone, std_mail=@std_mail where std_id=@std_id ";
                                      
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, std);
            cmd.ExecuteNonQuery();
        }

        public void Delete(string stdID)
        {
            MySqlCommand cmd = new MySqlCommand();

            //이미 삭제된 학생인지 체크
            if (IsDeleted(stdID))
            {
                throw new Exception("이미 삭제된 학생입니다");
            }
            cmd.CommandText = string.Format("Update Students SET deleted=1 where std_id='{0}' ", stdID);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }
        public bool IsDeleted(string stdID)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = string.Format("SELECt COUNT(*) FROM Students WHERE deleted = 1 AND std_id='{0}' ", stdID);
            cmd.Connection = conn;
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                return false;
            else
                return true;
        }

        public void SaveImageFile(string sPath, string sFileName, string std_id)
        {
            try
            {
                string sql = string.Format("Update Students SET std_picture = '{0}' WHERE std_id = '{1}'; ", sPath + sFileName, std_id);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception();
            }


        }

        #endregion

        #region GetData
        public DataSet GetAll()
        {
            DataSet ds = new DataSet();
            string sql = "select std_id, std_name, std_phone, std_mail from Students where deleted = 0 ";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "Student");
            return ds;
        }

        public DataSet GetIDName()
        {
            DataSet ds = new DataSet();
            string sql = "select std_id, std_name from Students where deleted = 0 ";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "StudentIdName");
            return ds;
        }

        public string GetImage(string std_id)
        {
            string sql = string.Format("select std_picture from Students where std_id ='{0}' ", std_id);

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            string image = cmd.ExecuteScalar().ToString();


            return image;


        }
        #endregion
        public void Dispose()
        {
            conn.Close();
        }
    }
}
