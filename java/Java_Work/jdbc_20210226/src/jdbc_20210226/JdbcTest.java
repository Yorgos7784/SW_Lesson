package jdbc_20210226;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class JdbcTest {
	// Connection(java.sql) import
	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "mydb";

	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";

	public static void main(String[] args) {
		connectDB();
		inserdDB();
		showDB();
		closeDB();
	}

	public static void connectDB() {
		try {
			Class.forName(jdbcDriver);
			con = DriverManager.getConnection(dbUrl, USER_ID, USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB 접속 성공!");
			}
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void closeDB() {
		try {
			state.close();
			con.close();
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void inserdDB() {
//		String query = "insert into t_user values (0, '홍길동', 100, 'hong@naver.com', '010-1234-1234', '조선 한양 홍대감댁', now())";

		String name = "김길동";
		int age = 220;
		String email = "kim@gmail.com";
		String tel = "010-9874-6521";
		String addr = "지리산 인근";

		String query2 = String.format(
				"insert into userinfo (name, age, tel, address, email, date) values ('%s', %d, '%s', '%s', '%s', now())",
				name, age, tel, addr, email);

		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public static void showDB() {
		String query = "select * from userinfo";
		try {
			ResultSet rs = state.executeQuery(query);
			if (rs != null) {
				rs = state.getResultSet();
				int count = 0;
				while (rs.next()) {
					System.out.print((count + 1) + "\t");
					System.out.print(rs.getString("name") + "\t");
					System.out.print(rs.getString("age") + "\t");
					System.out.print(rs.getString("tel") + "\t");
					System.out.print(rs.getString("address") + "\t");
					System.out.print(rs.getString("email") + "\t");
					System.out.println(rs.getString("date"));
					count++;
				}
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public static void createTable() {
		String query2 = "create table test2(id int not null auto_increment primary key, name varchar(20))";

		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
}