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

    #region SchoolRecordInfoVO , MockRecordInfoVO
    public struct SchoolRecordInfoVO
    {
        public string std_Id;
        public string grade;
        public string semester;
        public double sch_korean;
        public double sch_english;
        public double sch_math;

        public SchoolRecordInfoVO(string std_Id, string grade, string semester, double sch_korean, double sch_english, double sch_math)
        {
            this.std_Id = std_Id;
            this.grade = grade;
            this.semester = semester;
            this.sch_korean = sch_korean;
            this.sch_english = sch_english;
            this.sch_math = sch_math;
        }
    }
    public struct MockRecordInfoVO
    {
        public string std_Id;
        public string grade;
        public string semester;
        public double korean;
        public double english;
        public double math;
        public double side_choice1;
        public double side_choice2;
        public double more_foreign;

        public MockRecordInfoVO(string std_Id, string grade, string semester, double korean, double english, double math
            , double side_choice1, double side_choice2, double more_foreign)
        {
            this.std_Id = std_Id;
            this.grade = grade;
            this.semester = semester;
            this.korean = korean;
            this.english = english;
            this.math = math;
            this.side_choice1 = side_choice1;
            this.side_choice2 = side_choice2;
            this.more_foreign = more_foreign;
        }
    }
    #endregion 구조체

    public class SchoolRecordInfoDAC : IDisposable
    {
        MySqlConnection conn;
        public SchoolRecordInfoDAC()
        {
            string strConn = ConfigurationManager.ConnectionStrings["AcademicProject"].ConnectionString;
            conn = new MySqlConnection(strConn);
            conn.Open();

        }

        #region FillParameters
        private void FillParameters(MySqlCommand cmd, string record_id, string std_id = "")
        {
            MySqlParameter param1 = new MySqlParameter("std_id", MySqlDbType.VarChar, 10);
            param1.Value = std_id;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("sch_recordID", MySqlDbType.Int32, 11);
            param2.Value = record_id;
            cmd.Parameters.Add(param2);

        }


        private void FillParameters2(MySqlCommand cmd, string mock_recordID, string std_id = "")
        {
            MySqlParameter param1 = new MySqlParameter("std_id", MySqlDbType.VarChar, 10);
            param1.Value = std_id;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("mock_recordID", MySqlDbType.Int32, 11);
            param2.Value = mock_recordID;
            cmd.Parameters.Add(param2);

        }

        private void FillParameters_SchoolRecord(MySqlCommand cmd, SchoolRecordInfoVO RecordInfo)
        {
            MySqlParameter param1 = new MySqlParameter("grade", MySqlDbType.VarChar, 1);
            param1.Value = RecordInfo.grade;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("semester", MySqlDbType.VarChar, 1);
            param2.Value = RecordInfo.semester;
            cmd.Parameters.Add(param2);

            MySqlParameter param3 = new MySqlParameter("sch_korean", MySqlDbType.Double);
            param3.Value = RecordInfo.sch_korean;
            cmd.Parameters.Add(param3);

            MySqlParameter param4 = new MySqlParameter("sch_english", MySqlDbType.Double);
            param4.Value = RecordInfo.sch_english;
            cmd.Parameters.Add(param4);

            MySqlParameter param5 = new MySqlParameter("sch_math", MySqlDbType.Double);
            param5.Value = RecordInfo.sch_math;
            cmd.Parameters.Add(param5);

            MySqlParameter param6 = new MySqlParameter("std_id", MySqlDbType.Double);
            param6.Value = RecordInfo.std_Id;
            cmd.Parameters.Add(param6);

        }

        private void FillParameters_MockRecord(MySqlCommand cmd, MockRecordInfoVO MockRecordInfo)
        {
            MySqlParameter param1 = new MySqlParameter("grade", MySqlDbType.VarChar, 1);
            param1.Value = MockRecordInfo.grade;
            cmd.Parameters.Add(param1);

            MySqlParameter param2 = new MySqlParameter("semester", MySqlDbType.VarChar, 1);
            param2.Value = MockRecordInfo.semester;
            cmd.Parameters.Add(param2);

            MySqlParameter param3 = new MySqlParameter("korean", MySqlDbType.Double);
            param3.Value = MockRecordInfo.korean;
            cmd.Parameters.Add(param3);

            MySqlParameter param4 = new MySqlParameter("english", MySqlDbType.Double);
            param4.Value = MockRecordInfo.english;
            cmd.Parameters.Add(param4);

            MySqlParameter param5 = new MySqlParameter("math", MySqlDbType.Double);
            param5.Value = MockRecordInfo.math;
            cmd.Parameters.Add(param5);

            MySqlParameter param6 = new MySqlParameter("side_choice1", MySqlDbType.Double);
            param6.Value = MockRecordInfo.side_choice1;
            cmd.Parameters.Add(param6);

            MySqlParameter param7 = new MySqlParameter("side_choice2", MySqlDbType.Double);
            param7.Value = MockRecordInfo.side_choice2;
            cmd.Parameters.Add(param7);

            MySqlParameter param8 = new MySqlParameter("more_foreign", MySqlDbType.Double);
            param8.Value = MockRecordInfo.more_foreign;
            cmd.Parameters.Add(param8);

            MySqlParameter param9 = new MySqlParameter("std_id", MySqlDbType.VarChar, 10);
            param9.Value = MockRecordInfo.std_Id;
            cmd.Parameters.Add(param9);

        }
        #endregion

        #region InsertSchoolRecord
        public void InsertSchool(SchoolRecordInfoVO RecordInfo)
        {
            bool bCheck;
            bCheck = InsertSchoolGradeCheck(RecordInfo);
            if (!bCheck)
            {
                throw new Exception("해당 학년의 데이터는 이미 있습니다.");
            }
            bCheck = InsertSchoolSemesterCheck(RecordInfo);
            if (!bCheck)
            {
                throw new Exception("해당 학기의 데이터는 이미 있습니다.");
            }

            string sql = "INSERT INTO SchoolRecords(std_id, grade, semester, sch_korean, sch_english, sch_math) " +
                "VALUES(@std_id, @grade, @semester, @sch_korean, @sch_english, @sch_math) ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters_SchoolRecord(cmd, RecordInfo);
            cmd.ExecuteNonQuery();


        }

        public bool InsertSchoolGradeCheck(SchoolRecordInfoVO RecordInfo) //학년이 두개씩있는지 체크
        {
            string sql = "SELECT COUNT(*) FROM SchoolRecords WHERE grade=@grade AND std_id=@std_id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters_SchoolRecord(cmd, RecordInfo);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 2)
                return false;
            else
                return true;
        }

        public bool InsertSchoolSemesterCheck(SchoolRecordInfoVO RecordInfo)
        {
            string sql = "SELECT COUNT(*) FROM SchoolRecords WHERE grade=@grade AND semester=@semester AND std_id=@std_id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters_SchoolRecord(cmd, RecordInfo);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                return false;
            else
                return true;
        }

        #endregion 

        #region InsertMockRecord
        public void InsertMock(MockRecordInfoVO MockRecordInfo)
        {
            bool bCheck;
            bCheck = InsertMockGradeCheck(MockRecordInfo);
            if (!bCheck)
            {
                throw new Exception("해당 학년의 데이터는 이미 있습니다.");
            }
            bCheck = InsertMockSemesterCheck(MockRecordInfo);
            if (!bCheck)
            {
                throw new Exception("해당 학기의 데이터는 이미 있습니다.");
            }
            
            string sql = "INSERT INTO MockRecords(std_id, grade, semester, korean, english, math, side_choice1, side_choice2, more_foreign) " +
                "VALUES(@std_id, @grade, @semester, @korean, @english, @math, @side_choice1, @side_choice2, @more_foreign) ";
             
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters_MockRecord(cmd, MockRecordInfo);
            cmd.ExecuteNonQuery();


        }

        public bool InsertMockGradeCheck(MockRecordInfoVO MockRecordInfo) //학년이 세개씩있는지 체크
        {
            string sql = "SELECT COUNT(*) FROM MockRecords WHERE grade=@grade AND std_id=@std_id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters_MockRecord(cmd, MockRecordInfo);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 3)
                return false;
            else
                return true;
        }

        public bool InsertMockSemesterCheck(MockRecordInfoVO MockRecordInfo) //학년에 학기가 있는지 체크
        {
            string sql = "SELECT COUNT(*) FROM MockRecords WHERE grade=@grade AND semester=@semester AND std_id=@std_id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters_MockRecord(cmd, MockRecordInfo);
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                return false;
            else
                return true;
        }
        #endregion

        #region DeleteSchoolRecord
        public void DeleteSchool(string sch_recordID)
        {
            string sql = "DELETE FROM SchoolRecords WHERE sch_recordID=@sch_recordID ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters(cmd, sch_recordID);
            cmd.ExecuteNonQuery();

        }
        #endregion

        #region DeleteMockRecord
        public void DeleteMock(string mock_recordID)
        {
            string sql = "DELETE FROM MockRecords WHERE mock_recordID=@mock_recordID ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            FillParameters2(cmd, mock_recordID);
            cmd.ExecuteNonQuery();

        }
        #endregion

        #region GetAllSchoolRecord
        public DataSet GetAllSchool(string std_id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT grade, semester, sch_korean, sch_english, sch_math, sch_recordID  FROM SchoolRecords WHERE std_id ='{0}' ORDER BY 1,2", std_id);
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "SchoolRecords");
            return ds;
        }
        #endregion

        #region GetAllMockRecord
        public DataSet GetAllMock(string std_id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT grade, semester, korean, english, math, side_choice1, side_choice2, more_foreign, mock_recordID FROM MockRecords WHERE std_id ='{0}' ORDER BY 1,2 ", std_id);
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "MockRecords");
            return ds;
        }
        #endregion

        #region GetSchoolRecordByScore, GetMockRecordByScore
        // 성적순 데이터 로드 (내신)
        public DataSet GetSchoolRecordByScore(string grade, string semester)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT s.std_name, ROUND(AVG(sch_korean), 2) sch_korean, ROUND(AVG(sch_english), 2) sch_english, ROUND(AVG(sch_math), 2) sch_math, ROUND((sch_korean + sch_english + sch_math) / 3,2) avg " +
                "FROM Students s INNER JOIN SchoolRecords sr ON sr.std_id = s.std_id " +
                "WHERE s.deleted = 0 AND sr.grade = '{0}' AND sr.semester = '{1}' " +
                "GROUP BY std_name ORDER BY avg DESC ",grade, semester) ;
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "SchoolRecordByStudent");
            return ds;
        }

        //성적순 데이터 로드 (모의고사)
        public DataSet GetMockRecordByScore(string grade, string semester)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT s.std_name, ROUND(AVG(korean), 2) sch_korean, ROUND(AVG(english), 2) sch_english, ROUND(AVG(math), 2) sch_math, " +
                "ROUND(AVG(side_choice1), 2) side_choice1, ROUND(AVG(side_choice2), 2) side_choice2, ROUND(AVG(more_foreign), 2) more_foreign, " +
                "ROUND((korean + english + math + side_choice1 + side_choice2 + more_foreign) / 6, 2) avg " +
                "FROM Students s INNER JOIN MockRecords mr ON mr.std_id = s.std_id " +
                "WHERE s.deleted = 0 AND mr.grade = '{0}' " +
                "AND mr.semester = '{1}' " +
                "GROUP BY std_name ORDER BY avg DESC ", grade, semester);
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "MockRecordByStudent");
            return ds;
        }
        #endregion

        #region GetSchoolChart, GetMockChart
        public DataSet GetSchoolChart(string std_id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT std_id, concat(grade,'학년') grade, avg(sch_korean) korean, avg(sch_english) english, avg(sch_math) math from SchoolRecords " +
                "WHERE std_id = '{0}' GROUP BY std_id, grade ORDER BY 2, 3 ASC ",std_id);
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "SchoolChart");
            return ds;
        }

        public DataSet GetMockChart(string std_id)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT std_id, concat(grade,'학년') grade, ROUND(AVG(korean), 2) korean, ROUND(AVG(english), 2) english, ROUND(AVG(math), 2) math , " +
                "ROUND(AVG(side_choice1), 2) side_choice1, ROUND(AVG(side_choice2), 2) side_choice2, ROUND(AVG(more_foreign), 2) more_foreign " +
                "from MockRecords where std_id = '{0}' GROUP BY std_id, grade " +
                "ORDER BY 2, 3 ASC ", std_id);
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "MockChart");
            return ds;
            
        }
        #endregion

        #region GetSchoolRecordAvg, GetMockRecordAvg
        public DataSet GetSchoolRecordAvg(string std_id)
        {
           
            DataSet ds = new DataSet();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CASE WHEN ifnull(grade,'') = '' then '평균' else concat(grade, '학년') end as grade, ");
            sb.Append(" ROUND(avg(sch_korean), 2) sch_korean, ROUND(avg(sch_english), 2) sch_english, ROUND(avg(sch_math), 2) sch_math, ");
            sb.Append(" ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) as total_avg, ");
            sb.Append(" CASE");
            sb.Append(" WHEN ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) >= 90 THEN '1' ");
            sb.Append(" WHEN ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) >= 80 THEN '2' ");
            sb.Append(" WHEN ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) >= 70 THEN '3' ");
            sb.Append(" WHEN ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) >= 60 THEN '4' ");
            sb.Append(" WHEN ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) >= 50 THEN '5' ");
            sb.Append(" WHEN ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) >= 40 THEN '6' ");
            sb.Append(" WHEN ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) >= 30 THEN '7' ");
            sb.Append(" WHEN ROUND((avg(sch_korean) + avg(sch_english) + avg(sch_math)) / 3, 2) >= 20 THEN '8' ");
            sb.Append(" ELSE '9'");
            sb.Append(" END  cut");
            sb.Append(" FROM SchoolRecords");
            sb.AppendFormat(" WHERE std_id = '{0}' ", std_id);
            sb.Append(" GROUP BY grade");
            sb.Append(" WITH ROLLUP");

            MySqlDataAdapter adpt = new MySqlDataAdapter(sb.ToString(), conn);
            adpt.Fill(ds, "SchoolRecordAvg");
            return ds;
        }

        public DataSet GetMockRecordAvg(string std_id)
        {
            DataSet ds = new DataSet();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT CASE WHEN ifnull(grade,'') = '' then '평균' else concat(grade,'학년')end as grade ,");
            sb.Append(" ROUND(avg(korean), 2) korean, ROUND(avg(english), 2) english, ROUND(avg(math), 2) math, ");
            sb.Append(" ROUND(avg(side_choice1), 2) side_choice1, ROUND(avg(side_choice2), 2) side_choice2, ROUND(avg(more_foreign), 2) more_foreign,");
            sb.Append(" ROUND((avg(korean) + avg(english) + avg(math) + avg(side_choice1) + avg(side_choice2) + avg(more_foreign)) / 6, 2) as total_avg,");
            sb.Append(" CASE");
            sb.Append(" WHEN ROUND((avg(korean) + avg(english) + avg(math) + avg(side_choice1) + avg(side_choice2) + avg(more_foreign)) / 6, 2) >= 90 THEN '1'");
            sb.Append(" WHEN ROUND((avg(korean) + avg(english) + avg(math) + avg(side_choice1) + avg(side_choice2) + avg(more_foreign)) / 6, 2) >= 80 THEN '2'");
            sb.Append(" WHEN ROUND((avg(korean) + avg(english) + avg(math) + avg(side_choice1) + avg(side_choice2) + avg(more_foreign)) / 6, 2) >= 70 THEN '3'");
            sb.Append(" WHEN ROUND((avg(korean) + avg(english) + avg(math) + avg(side_choice1) + avg(side_choice2) + avg(more_foreign)) / 6, 2) >= 60 THEN '4'");
            sb.Append(" WHEN ROUND((avg(korean) + avg(english) + avg(math) + avg(side_choice1) + avg(side_choice2) + avg(more_foreign)) / 6, 2) >= 50 THEN '5'");
            sb.Append(" WHEN ROUND((avg(korean) + avg(english) + avg(math) + avg(side_choice1) + avg(side_choice2) + avg(more_foreign)) / 6, 2) >= 40 THEN '6'");
            sb.Append(" WHEN ROUND((avg(korean) + avg(english) + avg(math) + avg(side_choice1) + avg(side_choice2) + avg(more_foreign)) / 6, 2) >= 20 THEN '8'");
            sb.Append(" ELSE '9'");
            sb.Append(" END  cut");
            sb.Append(" FROM MockRecords");
            sb.AppendFormat(" WHERE std_id = '{0}' ",std_id);
            sb.Append(" GROUP BY grade");
            sb.Append(" WITH ROLLUP");

            MySqlDataAdapter adpt = new MySqlDataAdapter(sb.ToString(), conn);
            adpt.Fill(ds, "MockRecordAvg");
            return ds;
        }
        #endregion

        #region GetUnivCutLine, GetPossibleUnivCutLine
        public DataSet GetUnivCutLine(string univ_name, string major_name)
        {
            DataSet ds = new DataSet();
            StringBuilder sb = new StringBuilder();
            sb.Append(" SELECT univ_name, major_name, standard, percent, cut");
            sb.Append(" FROM UniversityCutLine");
            sb.AppendFormat(" WHERE univ_name = '{0}' ",univ_name);
            sb.AppendFormat(" AND major_name = '{0}' ", major_name);

            MySqlDataAdapter adpt = new MySqlDataAdapter(sb.ToString(), conn);
            adpt.Fill(ds, "UnivCutLine");
            return ds;

        }
        public DataSet GetPossibleUnivCutLine(int cut)
        {
            
            DataSet ds = new DataSet();
            string sql = string.Format("SELECT univ_name, major_name, cut " +
                "FROM UniversityCutLine WHERE cut > 0 AND cut >= {0} GROUP BY univ_name ", cut);

            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "PossibleUnivCutLine");
            return ds;

        }

        #endregion
        public void Dispose()
        {
            conn.Close();
        }
    }

}
