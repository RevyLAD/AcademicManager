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
    class CompetitionInfoService
    {
        MySqlConnection conn;

        public CompetitionInfoService()
        {

            string strConn = ConfigurationManager.ConnectionStrings["AcademicProject"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public void Insert(CompetitionInfoVO item, string std_id)
        {
            CompetitionInfoDAC DAC = new CompetitionInfoDAC(conn);
            DAC.Insert(item, std_id);
        }

        public void Update(CompetitionInfoVO item, string std_id)
        {
            CompetitionInfoDAC DAC = new CompetitionInfoDAC(conn);
            DAC.Update(item, std_id);
        }

        public void Delete(CompetitionInfoVO item, string std_id)
        {
            CompetitionInfoDAC DAC = new CompetitionInfoDAC(conn);
            DAC.Delete(item, std_id);
        }

        public DataTable GetAll()
        {
            CompetitionInfoDAC DAC = new CompetitionInfoDAC(conn);
            return DAC.GetAll();

        }

        public DataTable GetAwardByStudent(string std_id)
        {
            CompetitionInfoDAC DAC = new CompetitionInfoDAC(conn);
            return DAC.GetAwardByStudent(std_id);

        }
        //public DataTable GetStudentConsult(string std_id)
        //{
        //    ConsultInfoDAC DAC = new ConsultInfoDAC(conn);
        //    return DAC.GetStudentConsult(std_id);

        //}

        public void Dispose()
        {
            conn.Close();
        }
    }
}
