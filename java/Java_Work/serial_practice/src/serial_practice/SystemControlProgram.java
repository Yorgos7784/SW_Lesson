package serial_practice;


import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SystemControlProgram {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int BOILER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;
	
	public static void main(String[] args) {
		runMenu();
		
		
	}
	
	public static void runMenu() {
		Scanner s = new Scanner(System.in);
		
		while(true) {
			System.out.println("-------------------------");
			System.out.println("   스마트 홈 프로그램 v1.0");
			System.out.println("-------------------------");
			System.out.println("   1. TV 켜기");
			System.out.println("   2. TV 끄기");
			System.out.println("   3. 보일러 동작");
			System.out.println("   4. 세틱기 동작");
			System.out.println("   5. 프로그램 종료");
			System.out.println("-------------------------");
			System.out.print("   메뉴 선택 : ");
			int menu = s.nextInt();
			switch(menu) {
			case TV_ON :
				System.out.println("TV ON!");
				break;
			case TV_OFF :
				System.out.println("TV OFF!");
				break;
			case BOILER_ON :
				System.out.println("BOILER ON!");
				break;
			case CLEANER_ON :
				System.out.println("CLEANER ON!");
				break;
			case PROGRAM_EXIT :
				System.out.println("BYE!");
				s.close();
				System.exit(0);
				break;
			}
		}
	}
}
