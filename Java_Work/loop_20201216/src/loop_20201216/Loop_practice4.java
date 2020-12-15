package loop_20201216;

import java.util.Scanner;

public class Loop_practice4 {

	public static void main(String[] args) {
		System.out.println("------------------");
		System.out.println("구구단 프로그램 v1.0");
		System.out.println("------------------");
		Scanner s = new Scanner(System.in);
		System.out.print("숫자를 하나 입력하세요 : ");
		int num1 = s.nextInt();
		
		System.out.println(num1 + "단");
		for(int num2 = 1; num2 <= 9; num2++) {
			int result = num1 * num2;
			System.out.println(num1 + " x " + num2 + " = " + result);
		}
	}

}
