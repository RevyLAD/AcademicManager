using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;


namespace Academic_Manager
{
    class UniversityInfoService:IDisposable
    {
        MySqlConnection conn;

        public UniversityInfoService()
        {

            string strConn = ConfigurationManager.ConnectionStrings["AcademicProject"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        //public void Insert(MemberInfoVO item)
        //{
        //    MemberInfoDAC DAC = new MemberInfoDAC(conn);
        //    DAC.Insert(item);
        //}

        public DataSet GetAllUniversity()
        {
            UniversityInfoDAC DAC = new UniversityInfoDAC(conn);
            return DAC.GetAllUniversity();

        }

        public DataSet GetSearchUniv(string univ_name)
        {
            UniversityInfoDAC DAC = new UniversityInfoDAC(conn);
            return DAC.GetSearchUniv(univ_name);
        }

        public DataSet GetSearchUnivList(string univ_name)
        {
            UniversityInfoDAC DAC = new UniversityInfoDAC(conn);
            return DAC.GetSearchUnivList(univ_name);
        }


        public DataSet GetSearchMajor(string major_name)
        {
            UniversityInfoDAC DAC = new UniversityInfoDAC(conn);
            return DAC.GetSearchMajor(major_name);
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
