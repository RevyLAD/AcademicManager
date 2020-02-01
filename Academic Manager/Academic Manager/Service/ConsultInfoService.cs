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
    class ConsultInfoService:IDisposable
    {
        MySqlConnection conn;

        public ConsultInfoService()
        {

            string strConn = ConfigurationManager.ConnectionStrings["AcademicProject"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();
        }

        public void Insert(ConsultInfoVO item,string std_id)
        {
            ConsultInfoDAC DAC = new ConsultInfoDAC(conn);
            DAC.Insert(item,std_id);
        }

        public void Update(ConsultInfoVO item, string std_id)
        {
            ConsultInfoDAC DAC = new ConsultInfoDAC(conn);
            DAC.Update(item, std_id);
        }

        public void Delete(ConsultInfoVO item, string std_id)
        {
            ConsultInfoDAC DAC = new ConsultInfoDAC(conn);
            DAC.Delete(item, std_id);
        }
        public DataSet GetAll()
        {
            ConsultInfoDAC DAC = new ConsultInfoDAC(conn);
            return DAC.GetAll();

        }
        public DataTable GetStudentConsult(string std_id)
        {
            ConsultInfoDAC DAC = new ConsultInfoDAC(conn);
            return DAC.GetStudentConsult(std_id);

        }

        public void Dispose()
        {
            conn.Close();
        }
    }
}
