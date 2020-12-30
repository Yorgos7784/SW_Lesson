package array_20201223;

import java.io.BufferedOutputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Array_practice7 {

	public static void main(String[] args) throws IOException {
		Scanner s = new Scanner(System.in);
		Random rand = new Random();
		BufferedOutputStream bs = null;
		BufferedReader br;
		
		/*String last[] = {"김", "박", "이", "최", "장"};
		String first[] = {"바", "사", "아", "자", "차"};
		String mid[] = {"가", "나", "다", "라", "마"};
		String fullname[] = new String[50];
		for(int i = 0; i < fullname.length; i++) {
			int num1 = rand.nextInt(5);
			int num2 = rand.nextInt(5);
			int num3 = rand.nextInt(5);
			
			fullname[i] = last[num1] + first[num2] + mid[num3];
			//System.out.println(fullname[i]);
		}
		while(true) {
			System.out.println("-----------------------");
			System.out.println("  파일 제어 프로그램 v1.1");
			System.out.println("-----------------------");
			System.out.println("1. 이름 생성하여 파일에 저장");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println("-----------------------");
			System.out.print("메뉴 선택 : ");
			int menu = s.nextInt();
			if(menu == 1) {
				System.out.println("-----------------------");
				System.out.println("1. 이름 생성하여 파일에 저장");
				
				try {
					bs = new BufferedOutputStream(
							new FileOutputStream("d:/names.txt"));
					String name = null;
					for(int i = 0; i< fullname.length; i++) {
						name = fullname[i];
						bs.write(name.getBytes());
						bs.write("#".getBytes());
					}
					bs.close();
				}
				catch(FileNotFoundException e) {
					e.printStackTrace();
				}
				catch(IOException e) {
					e.printStackTrace();
				}

			}
			else if(menu == 2) {
				System.out.println("-----------------------");
				System.out.println("2. 파일에서 이름 읽어오기");
				
				try {
					br = new BufferedReader(new FileReader(new File("d:/names.txt")));
					String str = br.readLine();
					StringTokenizer stk = new StringTokenizer(str,"#");
					while(stk.hasMoreTokens()) {
						System.out.println(stk.nextToken());
					}
					br.close();
				}
				catch (FileNotFoundException e) {
					e.printStackTrace();
				}
				catch (IOException e) {
					e.printStackTrace();
				}
			}
			else if(menu == 3) {
				System.out.println("프로그램을 종료합니다.");
				s.close();
				System.exit(0);
			}
			else {
				System.out.println("잘못 입력하였습니다. 다시 선택해 주세요");
				continue;
			}
	
		}*/
		final String last[] = {"김", "박", "이", "최", "장"};
		final String first[] = {"바", "사", "아", "자", "차"};
		final String mid[] = {"가", "나", "다", "라", "마"};
		String fullname[] = new String[50];
		
		while(true) {
			System.out.println("-----------------------");
			System.out.println("  파일 제어 프로그램 v1.1");
			System.out.println("-----------------------");
			System.out.println("1. 이름 생성하여 파일에 저장");
			System.out.println("2. 파일에서 이름 읽어오기");
			System.out.println("3. 프로그램 종료");
			System.out.println("-----------------------");
			System.out.print("메뉴 선택 : ");
			int menu = s.nextInt();
			System.out.println("-----------------------");
			switch(menu) {
			case 1:
				System.out.println("1. 이름 생성하여 파일에 저장");
				bs = new BufferedOutputStream(
						new FileOutputStream("d:/names.txt"));
				for (int i = 0; i < fullname.length; i++) {
					fullname[i] = last[(int)(Math.random()*5)] + first[(int)(Math.random()*5)] + mid[(int)(Math.random()*5)];
					bs.write(fullname[i].getBytes());
					bs.write("/".getBytes());
				}
				bs.close();
				System.out.println("파일 저장 완료!");
				break;
			case 2:
				br = new BufferedReader(new FileReader(new File("d:/names.txt")));
				String str = br.readLine();
				StringTokenizer stk = new StringTokenizer(str,"/");
				while(stk.hasMoreTokens()) {
					System.out.println(stk.nextToken());}
				br.close();
				System.out.println("읽어오기 완료!");
				break;
			case 3:
				// 프로세스 : 실행중인 프로그램
				// 프로세서 : CPU
				s.close();
				System.exit(0);
			default:
				System.out.println("잘못된 메뉴 선택!");
				break;
			}
		}
	}

}
