using CarManager_0323.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager_0323.DB
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

       /* public void createTable()
        {
            try
            {
                string query = "create table test0323 (id number not null, name varchar(20) not null, age number not null, constraint pk_test0323_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "create sequence seq_test0323_id increment by 1 start with 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, CREATE_TB_ERROR);
            }
        }

        public void dropTable()
        {
            try
            {
                string query = "drop table test0323";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "drop sequence seq_test0323_id";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, DROP_TB_ERROR);
            }
        }*/

        public void makeTbCustomer()
        {
            try
            {
                string query = "CREATE TABLE CUSTOMER(" +
                    "cus_id INT NOT NULL, " +
                    "name VARCHAR2(20) NOT NULL, " +
                    "tel VARCHAR2(20) NOT NULL, " +
                    "addr VARCHAR2(20) NOT NULL, " +
                    "email VARCHAR2(20), " +
                    "CONSTRAINT CUSTOMER_PK PRIMARY KEY(cus_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE CUSTOMER_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, CREATE_TB_ERROR);
            }
        }

        public void makeTbCar()
        {
            try
            {
                string query = "CREATE TABLE CAR(" +
                    "car_id INT NOT NULL, " +
                    "model VARCHAR2(20) NOT NULL, " +
                    "color VARCHAR2(20) NOT NULL, " +
                    "company VARCHAR2(20) NOT NULL, " +
                    "price INT NOT NULL, " +
                    "year VARCHAR2(20) NOT NULL, " +
                    "CONSTRAINT CAR_PK PRIMARY KEY(car_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE CAR_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, CREATE_TB_ERROR);
            }
        }

        public void makeTbSeller()
        {
            try
            {
                string query = "CREATE TABLE SELLER(" +
                    "seller_id INT NOT NULL, " +
                    "name VARCHAR2(20) NOT NULL, " +
                    "tel VARCHAR2(20) NOT NULL, " +
                    "email VARCHAR2(20), " +
                    "grade VARCHAR2(20) NOT NULL, " +
                    "derijum VARCHAR2(20) NOT NULL, " +
                    "CONSTRAINT SELLER_PK PRIMARY KEY(seller_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE SELLER_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, CREATE_TB_ERROR);
            }
        }

        public void makeTbOrderTable()
        {
            try
            {
                string query = "CREATE TABLE ORDER_TABLE(" +
                    "order_num INT NOT NULL, " +
                    "order_date VARCHAR2(20) NOT NULL, " +
                    "seller_id INT NOT NULL, " +
                    "cus_id INT NOT NULL, " +
                    "car_id INT NOT NULL, " +
                    "CONSTRAINT ORDER_TABLE_PK PRIMARY KEY(order_num), " +
                    "CONSTRAINT FK_order_table_seller_id_selle FOREIGN KEY(seller_id) REFERENCES seller(seller_id), " +
                    "CONSTRAINT FK_order_table_cus_id_customer FOREIGN KEY(cus_id) REFERENCES customer(cus_id), " +
                    "CONSTRAINT FK_order_table_car_id_car_car_ FOREIGN KEY(car_id) REFERENCES car(car_id))";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "CREATE SEQUENCE ORDER_TABLE_SEQ START WITH 1 INCREMENT BY 1";
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, CREATE_TB_ERROR);
            }
        }

        public void dropTable(string tableName, string seqName)
        {
            try
            {
                string query = "DROP TABLE " + tableName + " CASCADE CONSTRAINTS";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                string querySeq = "DROP SEQUENCE " + seqName;
                cmd.CommandText = querySeq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공!");
            }
            catch (OracleException e)
            {
                errorMsg(e, DROP_TB_ERROR);
            }
        }

        public void makeTables()
        {
            makeTbCustomer();
            makeTbCar();
            makeTbSeller();
            makeTbOrderTable();
        }

        public void dropTables()
        {
            dropTable("CUSTOMER", "CUSTOMER_SEQ");
            dropTable("CAR", "CAR_SEQ");
            dropTable("SELLER", "SELLER_SEQ");
            dropTable("ORDER_TABLE", "ORDER_TABLE_SEQ");
        }

        public void errorMsg(OracleException e, string msg)
        {
            Console.WriteLine(msg + "에러 번호 : " + e.Number);
            Console.WriteLine(msg + "에러 내용 : " + e.Message);
        }

        public void insertCarInfo(Car car)
        {

        }
    }
}
