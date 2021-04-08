using MovieReviewProgram.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewProgram.Oracle
{
    class DaoOracle
    {
        const string CONNECT_ERROR = "DB 접속";
        const string DISCONNECT_ERROR = "DB 접속 해제";
        const string CREATE_TB_ERROR = "테이블+시퀀스 생성";
        const string DROP_TB_ERROR = "테이블+시퀀스 삭제";

        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User Id=c##scott;Password=1126;";
        OracleConnection conn;
        OracleCommand cmd;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        // ~ : 소멸자 - 객체가 소멸될 때
        ~DaoOracle()
        {
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                errorMsg(e, CONNECT_ERROR);
            }
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제");
            }
            catch (OracleException e)
            {
                errorMsg(e, DISCONNECT_ERROR);
            }
        }

        public void errorMsg(OracleException e, string msg)
        {
            Console.WriteLine(msg + "에러 번호 : " + e.Number);
            Console.WriteLine(msg + "에러 내용 : " + e.Message);
            switch (e.Number)
            {
                case 984:
                    MessageBox.Show("잘못된 숫자 입력방식 입니다.", "잘못된 입력방식");
                    break;
                case 942:
                    MessageBox.Show("테이블이 존재하지 않습니다.", "테이블 에러");
                    break;
                case 936:
                case 1400:
                    MessageBox.Show("누락된 정보가 있습니다.\n값을 입력해주세요.", "누락된 정보");
                    break;
                case 955:
                    //MessageBox.Show("테이블이 이미 존재합니다.", "테이블 에러");
                    break;
                case 1:
                    //MessageBox.Show("아이디가 이미 존재합니다.", "아이디 오류");
                    break;
            }
        }

        public void makeUserTable()
        {
            try
            {
                string query = "CREATE TABLE LOGIN_T(" +
                "user_id VARCHAR2(20) NOT NULL, " +
                "user_pw VARCHAR2(50) NOT NULL, " +
                "CONSTRAINT LOGIN_PK PRIMARY KEY(user_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                Console.WriteLine("테이블 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, "makeUserTable()");
            }
        }

        public void dropTables(string tableName, string sequenceName)
        {
            try
            {
                string query = string.Format("DROP TABLE {0} CASCADE CONSTRAINTS", tableName);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = string.Format("DROP SEQUENCE {0}", sequenceName);
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, "dropTables()");
            }
        }
        
        public void dropTables(string tableName)
        {
            try
            {
                string query = string.Format("DROP TABLE {0} CASCADE CONSTRAINTS", tableName);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블 제거 성공");
            }
            catch (OracleException e)
            {
                errorMsg(e, "dropTables()");
            }
        }

        public void insertUser(User user)
        {
            try
            {
                string query = string.Format("INSERT INTO LOGIN_T VALUES ('{0}', '{1}')", user.Id, user.Pw);
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                Console.WriteLine("데이터 추가 완료");
                MessageBox.Show("가입이 완료되었습니다.", "가입 완료");
            }
            catch (OracleException e)
            {
                errorMsg(e, "insertUser()");
            }
        }

        public List<User> selectUsers()
        {
            List<User> users = new List<User>();
            try
            {
                string query = "SELECT USER_ID, USER_PW FROM LOGIN_T";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        users.Add(new User(Convert.ToString(reader["USER_ID"]),Convert.ToString(reader["USER_PW"])));
                    }
                }
                else
                {
                    Console.WriteLine("데이터가 존재하지 않습니다.");
                }
                reader.Close();
            }
            catch (OracleException e)
            {
                errorMsg(e, "selectUsers()");
            }
            return users;
        }
    }
}
