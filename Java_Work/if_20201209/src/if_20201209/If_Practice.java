package if_20201209;

import java.util.Scanner;

public class If_Practice {

	public static void main(String[] args) {
	
		Scanner s = new Scanner(System.in);
		// 1. 홀짝 판단 프로그램
		
		/*System.out.println("------------------");
		System.out.println("홀짝 판단 프로그램 v1.0");
		System.out.println("------------------");
		System.out.print("숫자를 입력하세요 : ");
		int num1 = s.nextInt();
		
		if(num1 % 2 == 1) {
			System.out.println("------------------");
			System.out.println("입력한 숫자는 홀수입니다.");
		}
		else if(num1 % 2 == 0) {
			System.out.println("------------------");
			System.out.println("입력한 숫자는 짝수입니다.");
		}*/
		
		
		// 2. 대소 비교 프로그램
		/*System.out.println("------------------");
		System.out.println("대소 비교 프로그램 v1.0");
		System.out.println("------------------");
		System.out.print("첫번째 숫자를 입력하세요 : ");
		int num2 = s.nextInt();
		System.out.print("두번째 숫자를 입력하세요 : ");
		int num3 = s.nextInt();
		
		if(num2 > num3) {
			System.out.println("------------------");
			System.out.println(num2 + "이 " + num3 + "보다 크다");
		}
		else if(num3 > num2) {
			System.out.println("------------------");
			System.out.println(num3 + "이 " + num2 + "보다 크다");
		}
		else if(num2 == num3) {
			System.out.println("------------------");
			System.out.println(num2 + "과(와) " + num3 + "은 같다");
		}*/
		
		
		// 3. 간단 계산기 프로그램
		/*System.out.println("------------------");
		System.out.println("간단 계산기 프로그램 v1.0");
		System.out.println("------------------");
		System.out.print("첫번째 숫자를 입력하세요 : ");
		int num4 = s.nextInt();
		System.out.print("두번째 숫자를 입력하세요 : ");
		int num5 = s.nextInt();
		System.out.print("연산자를 입력하세요(+, -, x, /) : ");
		String str = s.next();
		
		if(str.equals("+")) {
			System.out.println("------------------");
			System.out.println(num4 + " + " + num5 + " = " + (num4 + num5));
		}
		else if(str.equals("-")) {
			System.out.println("------------------");
			System.out.println(num4 + " - " + num5 + " = " + (num4 - num5));
		}
		else if(str.equals("x")) {
			System.out.println("------------------");
			System.out.println(num4 + " x " + num5 + " = " + (num4 * num5));
		}
		else if(str.equals("/")) {
			System.out.println("------------------");
			System.out.println(num4 + " / " + num5 + " = " + (num4 / num5));
		}
		else {
			System.out.println("------------------");
			System.out.println("잘못 입력하였습니다.");
			
		}*/
				
		
		// 4. 년도별 윤년 구분 프로그램
		/*System.out.println("-----------------------");
		System.out.println("년도별 윤년 구분 프로그램 v1.0");
		System.out.println("-----------------------");
		System.out.print("년도를 입력하세요 : ");
		int year = s.nextInt();
		
		if(((year % 4) == 0 && (year % 100) != 0) || (year % 400) == 0) {
			System.out.println(year + "은(는) 윤년입니다");
		}
		else {
			System.out.println(year + "은(는) 윤년이 아닙니다");
		}*/
		
		
		// 5. 학점 관리 프로그램
		/*System.out.println("-------------------");
		System.out.println("학점 관리 프로그램 v1.0");
		System.out.println("-------------------");
		System.out.print("국어 점수를 입력하세요 : ");
		int kor = s.nextInt();
		System.out.println("-------------------");
		System.out.print("영어 점수를 입력하세요 : ");
		int eng = s.nextInt();
		System.out.println("-------------------");
		System.out.print("수학 점수를 입력하세요 : ");
		int math = s.nextInt();
		
		int sum = kor + eng + math;
		int ave = sum / 3;
		System.out.println("-------------------");
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + ave);
		
		if(100 >= ave &&  ave >= 90) {
			System.out.println("학점은 A입니다.");
		}
		else if(90 > ave && ave >= 80) {
			System.out.println("학점은 B입니다.");
		}
		else if(80 > ave && ave >= 70) {
			System.out.println("학점은 C입니다.");
		}
		else if(70 > ave && ave >= 60) {
			System.out.println("학점은 D입니다.");
		}
		else if(60 > ave && ave >= 50) {
			System.out.println("학점은 E입니다.");
		}
		else {
			System.out.println("학점은 F입니다.");
		}
		s.close();*/

	}

}
