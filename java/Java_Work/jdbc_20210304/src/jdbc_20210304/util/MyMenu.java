package jdbc_20210304.util;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.sql.Statement;
import java.util.Scanner;

public class MyMenu {
	Scanner s;
	Statement state;
	
	
	
	BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	
	public MyMenu(Scanner s, Statement state) {
		this.s = s;
		this.state = state;
	}

	public int menu() {
		System.out.println("\n---------------------");
		System.out.println("MySQL 관리 프로그램 v1.0");
		System.out.println("---------------------");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 데이터 추가");
		System.out.println("4. 랜덤 데이터 추가");
		System.out.println("5. 데이터 보기");
		System.out.println("6. 데이터 수정");
		System.out.println("7. 데이터 삭제");
		System.out.println("8. 종료");
		System.out.println("---------------------");
		System.out.print("메뉴 선택 : ");
		return s.nextInt();
	}

	/*
	 * public String createTableMenu() {
	 * System.out.println("\n---------------------");
	 * System.out.println("     테이블 생성 메뉴");
	 * System.out.println("---------------------"); System.out.print("쿼리 입력: "); try
	 * { return br.readLine(); } catch (IOException e) { return null; } }
	 * 
	 * public String deleteTableMenu() {
	 * System.out.println("\n---------------------");
	 * System.out.println("     테이블 생성 메뉴");
	 * System.out.println("---------------------");
	 * System.out.print("삭제할 테이블 이름을 입력해주세요 : ");
	 * 
	 * try { return br.readLine(); } catch (IOException e) { return null; } }
	 */
	
	public String[] insertDataMenu() {
		System.out.println("\n---------------------");
		System.out.println("       데이터 추가 ");
		System.out.println("---------------------");
		System.out.print("이름 입력 : ");
		String name = "";
		try {
			name = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
		System.out.print("나이 입력 : ");
		String age = "";
		try {
			age = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
		System.out.print("전화 입력 : ");
		String tel = "";
		try {
			tel = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print("주소 입력 : ");
		String addr = "";
		try {
			addr = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		System.out.print("메일 입력 : ");
		String email = "";
		try {
			email = br.readLine();
		} catch (IOException e) {
			e.printStackTrace();
		}
		String[] info = {name, age, tel, addr, email}; 
		return info;
	}
	
	public int randDateMenu() {
		System.out.println("\n---------------------");
		System.out.println("     랜덤 데이터 추가 ");
		System.out.println("---------------------");
		System.out.print("수량 입력 : ");
		return s.nextInt();
	}

	public int selectMenu() {
		System.out.println("\n---------------------");
		System.out.println("     데이터 탐색 메뉴");
		System.out.println("---------------------");
		System.out.println("1. 전체 보기");
		System.out.println("2. 번호로 검색");
		System.out.println("3. 이름으로 검색");
		System.out.println("4. 나이로 검색");
		System.out.println("5. 전화번호로 검색");
		System.out.println("6. 주소로 검색");
		System.out.println("7. 이메일로 검색");
		System.out.println("8. 돌아가기");
		System.out.println("---------------------");
		System.out.print("메뉴 선택 : ");
		return s.nextInt();
	}
}