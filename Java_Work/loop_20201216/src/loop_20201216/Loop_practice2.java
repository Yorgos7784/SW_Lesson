package loop_20201216;

import java.util.Scanner;

public class Loop_practice2 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("첫번째 숫자를 입력하세요 : ");
		int num1 = s.nextInt();
		System.out.print("두번째 숫자를 입력하세요 : ");
		int num2 = s.nextInt();
		int result = 0;
		
		System.out.println("------------------------");
		if(num1 >= num2) {
			System.out.println("Error!!");
		}
		else {
			for(int i = num1; i <= num2; i++) {
				result = result + i;
			}
			System.out.println(num1 + "부터 " + num2 + "까지의 합 : " + result);
		}
		
	}

}
