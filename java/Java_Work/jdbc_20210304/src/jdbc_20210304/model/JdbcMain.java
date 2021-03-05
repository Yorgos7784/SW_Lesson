package jdbc_20210304.model;

import java.sql.Statement;
import java.util.Scanner;

import jdbc_20210304.dao.MyJdbc;
import jdbc_20210304.util.MyMenu;

public class JdbcMain {
	static final int CREATE_TABLE = 1;
	static final int DELETE_TABLE = 2;
	static final int CREATE_DATA = 3;
	static final int CREATE_RAND_DATA = 4;
	static final int VIEW_DATA = 5;
	static final int UPDATE_DATA = 6;
	static final int DELETE_DATA = 7;
	static final int PROGRAM_EXIT = 8;

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		MyJdbc db1 = new MyJdbc(s);
		db1.connectDB();
		Statement s1 = db1.getState();
		MyMenu m1 = new MyMenu(s, s1);
		
		while (true) {
			switch (m1.menu()) {
			case CREATE_TABLE:
				//System.out.println("테이블 추가 메뉴");
				db1.createTable();
				break;
			case DELETE_TABLE:
				//System.out.println("테이블 삭제 메뉴");
				db1.deleteTable();
				break;
			case CREATE_DATA:
				//System.out.println("데이터 추가 메뉴");
				db1.insertData(m1.insertDataMenu());
				break;
			case CREATE_RAND_DATA:
				//System.out.println("랜덤 데이터 추가 메뉴");
				db1.insertRandData(m1.randDateMenu());
				break;
			case VIEW_DATA:
				//System.out.println("데이터 보기 메뉴");
				break;
			case UPDATE_DATA:
				System.out.println("데이터 수정 메뉴");
				break;
			case DELETE_DATA:
				System.out.println("데이터 삭제 메뉴");
				break;
			case PROGRAM_EXIT:
				System.out.println("\nThanks for Using!");
				db1.closeDB();
				s.close();
				System.exit(0);
				break;
			default:
				System.out.println("\n잘못 입력하셨습니다.");
				break;
			}
		}
	}
}
