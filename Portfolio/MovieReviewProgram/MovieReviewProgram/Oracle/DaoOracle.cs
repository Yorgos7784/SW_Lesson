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
        OracleCommand cmd2;

        public DaoOracle()
        {
            conn = new OracleConnection(ORADB);
            cmd2 = new OracleCommand();
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
                    MessageBox.Show("테이블이 이미 존재합니다.", "테이블 에러");
                    break;
            }
        }

        public void makeUserTable()
        {
            try
            {
                string query = "CREATE TABLE LOGIN_T(" +
                "id INT NOT NULL, " +
                "name VARCHAR2(20) NOT NULL, " +
                "pw VARCHAR2(20) NOT NULL, " +
                "CONSTRAINT CUSTOMER_PK PRIMARY KEY(u_id))";
                cmd2.Connection = conn;
                cmd2.CommandText = query;
                cmd2.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE LOGIN_T_SEQ START WITH 1 INCREMENT BY 1";
                cmd2.CommandText = querySeq;
                cmd2.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
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
                cmd2.Connection = conn;
                cmd2.CommandText = query;
                cmd2.ExecuteNonQuery();

                string querySeq = string.Format("DROP SEQUENCE {0}", sequenceName);
                cmd2.CommandText = querySeq;
                cmd2.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, "dropTables()");
            }
            
        }
    }
}
