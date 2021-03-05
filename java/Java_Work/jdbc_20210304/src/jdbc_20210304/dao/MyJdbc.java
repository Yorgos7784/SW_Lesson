package jdbc_20210304.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class MyJdbc {
	private static Connection con;
	private static Statement state;
	private static final String USER_ID = "root";
	private static final String USER_PW = "1126";
	private static final String DBNAME = "mydb";

	private static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	private static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	static final int SELECT_ALL = 1;
	static final int SELECT_NUM = 2;
	static final int SELECT_NAME = 3;
	static final int SELECT_AGE = 4;
	static final int SELECT_TEL = 5;
	static final int SELECT_ADDR = 6;
	static final int SELECT_EMAIL = 7;
	static final int SELECT_EXIT = 8;

	Scanner s;

	public MyJdbc(Scanner s) {
		this.s = s;
	}

	public void connectDB() {
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

	public void closeDB() {
		try {
			state.close();
			con.close();
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	public Statement getState() {
		return state;
	}

	public void createTable() {
		String query = "create table userInfo (id INT(10) NOT NULL AUTO_INCREMENT, name VARCHAR(10) NOT NULL, age INT(3) NOT NULL, tel VARCHAR(30) NOT NULL, address VARCHAR(40) NOT NULL, email VARCHAR(30) NULL, date DATETIME NOT NULL, PRIMARY KEY(id))";
		try {
			state.executeUpdate(query);
			System.out.println("\n추가되었습니다!");
		} catch (SQLException e) {
			/*
			 * System.out.println(e.getSQLState()); System.out.println(e.getMessage());
			 * System.out.println(e.getErrorCode());
			 * System.out.println(e.getCause().toString());
			 */
			errorMessage(e);
			// e.printStackTrace();
		}
	}

	public void deleteTable() {
		String dtQuery = "drop table userInfo";
		try {
			state.executeUpdate(dtQuery);
			System.out.println("\n삭제되었습니다!");
		} catch (SQLException e) {
			errorMessage(e);
		}
	}

	public void insertData(String[] info) {
		String name = info[0];
		int age = Integer.parseInt(info[1]);
		String tel = info[2];
		String addr = info[3];
		String email = info[4];
		String query = String.format(
				"insert into userInfo (name, age, tel, address, email, date) values ('%s', %d, '%s', '%s', '%s', now())",
				name, age, tel, addr, email);
		try {
			state.executeUpdate(query);
			System.out.println("\n추가되었습니다!");
		} catch (SQLException e) {
			e.getErrorCode();
			e.printStackTrace();
		}
	}

	public void insertRandData(int num) {
		String[] lastName = { "김", "이", "박", "최", "강" };
		String[] firstName1 = { "춘", "덕", "광", "미", "용" };
		String[] firstName2 = { "삼", "배", "자", "국", "봉", "심", "숙", "식" };
		String[] address = { "대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동" };
		String[] emailId = { "hong", "kim", "park", "choi", "kang", "lee" };
		String[] emailadd = { "@naver.com", "@gmail.com", "@hanmail.net" };
		
		String query;
		for (int i = 0; i < num; i++) {
			query = String.format(
					"insert into userInfo (name, age, tel, address, email, date) values ('%s', %d, '%s', '%s', '%s', now())",
					lastName[(int) (Math.random() * lastName.length)] + firstName1[(int) (Math.random() * firstName1.length)] + firstName2[(int) (Math.random() * firstName2.length)], 
					(int) (Math.random() * 50),
					"010 - " + (int)(Math.random() * 9999) + " - " + (int)(Math.random() * 9999),
					address[(int) (Math.random() * address.length)],
					emailId[(int) (Math.random() * emailId.length)] + emailadd[(int) (Math.random() * emailadd.length)]);
			try {
				state.executeUpdate(query);
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		System.out.println("\n추가되었습니다!");
	}

	public void selectData(int menu) {
		switch(menu) {
		case SELECT_ALL:
			String query = "select * from userinfo";
			try {
				ResultSet rs = state.executeQuery(query);
				if (rs != null) {
					rs = state.getResultSet();
					int count = 0;
					System.out.print("\n번호\t");
					System.out.print("이름\t");
					System.out.print("나이\t");
					System.out.print("전화\t\t\t");
					System.out.print("주소\t\t");
					System.out.print("메일\t\t");
					System.out.println("날짜");
					System.out.println("========================================================================================================");
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
				} else {
					System.out.println("\n테이블이 비어있습니다.");
				}
			} catch (SQLException e) {
				e.printStackTrace();
			}
			break;
		case SELECT_NUM:
			System.out.print("\n찾으시는 번호를 입력하세요 : ");
			int num = s.nextInt();
			String queryNum = "select * from userinfo where id = " + num;
			try {
				ResultSet rs = state.executeQuery(queryNum);
				if (rs != null) {
					rs = state.getResultSet();
					int count = 0;
					System.out.print("\n번호\t");
					System.out.print("이름\t");
					System.out.print("나이\t");
					System.out.print("전화\t\t\t");
					System.out.print("주소\t\t");
					System.out.print("메일\t\t");
					System.out.println("날짜");
					System.out.println("========================================================================================================");
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
				} else {
					System.out.println("테이블이 비어있습니다.");
				}
			} catch (SQLException e) {
				e.printStackTrace();
			}
			break;
		case SELECT_NAME:
			System.out.print("\n찾으시는 이름을 입력하세요 : ");
			String name = s.next();
			String queryName = "select * from userinfo where name = " + name;
			try {
				ResultSet rs = state.executeQuery(queryName);
				if (rs != null) {
					rs = state.getResultSet();
					int count = 0;
					System.out.print("\n번호\t");
					System.out.print("이름\t");
					System.out.print("나이\t");
					System.out.print("전화\t\t\t");
					System.out.print("주소\t\t");
					System.out.print("메일\t\t");
					System.out.println("날짜");
					System.out.println("========================================================================================================");
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
				} else {
					System.out.println("테이블이 비어있습니다.");
				}
			} catch (SQLException e) {
				e.printStackTrace();
			}
			break;
		case SELECT_AGE:
			break;
		case SELECT_TEL:
			break;
		case SELECT_ADDR:
			break;
		case SELECT_EMAIL:
			break;
		case SELECT_EXIT:
			return;
		default:
			System.out.println("잘못 입력하셨습니다.");
			break;
		}
		
	}
	
	public void errorMessage(SQLException e) {
		switch (e.getErrorCode()) {
		case 1050:
			System.out.println("\n테이블이 이미 존재합니다.");
			break;
		case 1051:
			System.out.println("\n테이블이 존재하지 않습니다.");
			break;
		case 1064:
			System.out.println("\n쿼리를 잘못 입력하셨습니다.");
			break;
		}
	}
}
