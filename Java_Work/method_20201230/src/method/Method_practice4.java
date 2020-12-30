package method;

import java.util.Scanner;

public class Method_practice4 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		while(true) {
			System.out.print("국어점수를 입력하세요 : ");
			int kor = s.nextInt();
			System.out.print("영어점수를 입력하세요 : ");
			int eng = s.nextInt();
			System.out.print("수학점수를 입력하세요 : ");
			int math = s.nextInt();
			if(kor > 100 || eng > 100 || math > 100) {
				System.out.println("잘못 입력하셨습니다. 다시 입력해주세요");
				continue;
			}
			else {
				sumave(kor, eng, math);
				s.close();
				System.exit(0);
			}
			
			
		}
		

	}
	public static void sumave(int kor, int eng, int math) {
		int sum = kor + eng + math;
		int ave = sum / 3;
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + ave);
	}

}
