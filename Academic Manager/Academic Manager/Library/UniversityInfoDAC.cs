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
    public struct UniversityInfoVO
    {
        public string univ_name;
        public string univ_address;
        public string univ_phone;
        public string univ_homepage;
        public UniversityInfoVO(string univ_name, string univ_address, string univ_phone, string univ_homepage)
        {
            this.univ_name = univ_name;
            this.univ_address = univ_address;
            this.univ_phone = univ_phone;
            this.univ_homepage = univ_homepage;
        }
    }

    public struct UniversityByMajorInfoVO
    {
        public int muCode;
        public string univ_name;
        public string major_name;
        public string major_high;
        public string major_mid;
        public string major_low;

        public UniversityByMajorInfoVO(int muCode, string univ_name, string major_name, 
            string major_high, string major_mid, string major_low)
        {
            this.muCode = muCode;
            this.univ_name = univ_name;
            this.major_name = major_name;
            this.major_high = major_high;
            this.major_mid = major_mid;
            this.major_low = major_low;
        }
    }
    public class UniversityInfoDAC:IDisposable
    {
        MySqlConnection conn;

        public UniversityInfoDAC(MySqlConnection sqlConn)
        {

            conn = sqlConn;
        }
        #region FillParameters
        private void FillParameters(MySqlCommand cmd, UniversityByMajorInfoVO item)
        {
            MySqlParameter param1 = new MySqlParameter("muCode", MySqlDbType.Int32, 11);
            param1.Value = item.muCode;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("univ_name", MySqlDbType.VarChar, 30);
            param2.Value = item.univ_name;
            cmd.Parameters.Add(param2);

            MySqlParameter param3 = new MySqlParameter("major_name", MySqlDbType.VarChar, 45);
            param3.Value = item.major_name;
            cmd.Parameters.Add(param3);


            MySqlParameter param4 = new MySqlParameter("major_high", MySqlDbType.VarChar, 20);
            param4.Value = item.major_high;
            cmd.Parameters.Add(param4);

            MySqlParameter param5 = new MySqlParameter("major_mid", MySqlDbType.VarChar, 20);
            param5.Value = item.major_mid;
            cmd.Parameters.Add(param5);

            MySqlParameter param6 = new MySqlParameter("major_low", MySqlDbType.VarChar, 20);
            param6.Value = item.major_low;
            cmd.Parameters.Add(param6);
        }
        #endregion

        #region GetData (GetAllUniversity, GetSearchUniv, GetSearchUnivList, GetSearchMajor)
        public DataSet GetAllUniversity()
        {
            string sql = "select univ_name, univ_address, univ_phone, homepage FROM University ";

            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            return ds;
        }

        public DataSet GetSearchUniv(string univ_name)
        {
            //검색 기능 성능향상 ( 강원대, 강원대학교 둘다나오게)
            if (univ_name.Length>=3)
            {
                string sub = univ_name.Trim().Substring((univ_name.Trim().Length - 3), 3);
                string univ = "대학교";
                if (sub.Equals(univ))
                {
                    univ_name = univ_name.Trim().Substring(0, univ_name.Trim().Length - 3);
                }
            }

            DataSet ds = new DataSet();
            string sql = string.Format("SELECT univ_name, major_name FROM UniversityCutLine " + 
                "WHERE univ_name LIKE '%"+univ_name+"%'"); 
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds,"SearchUniv");
            return ds;
        }

        public DataSet GetSearchUnivList(string univ_name)
        {

            DataSet ds = new DataSet();
            string sql = string.Format("SELECT univ_name, univ_address, univ_phone, homepage FROM University " +
                "WHERE univ_name LIKE '%" + univ_name + "%'");
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "SearchUnivList");
            return ds;
        }

        public DataSet GetSearchMajor(string major_name)
        {
            //검색 기능 성능향상 ( 컴퓨터, 컴퓨터학과 둘다나오게)
            if (major_name.Length >= 2)
            {
                string sub = major_name.Trim().Substring((major_name.Trim().Length - 2), 2);
                string univ = "학과";
                if (sub.Equals(univ))
                {
                    major_name = major_name.Trim().Substring(0, major_name.Trim().Length - 2);
                }
            }
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT univ_name, major_name FROM UniversityCutLine  " +
                "WHERE major_name LIKE '%"+ major_name + "%' ");
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "SearchMajor");
            return ds;
        }
        #endregion
        public void Dispose()
        {
            conn.Close();
        }
    }
}
