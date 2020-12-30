package method;

import java.util.Scanner;

public class Method_practice1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("숫자 3개를 입력하세요 : ");
		int num1 = s.nextInt();
		int num2 = s.nextInt();
		int num3 = s.nextInt();
		numcomp(num1, num2, num3);
		

	}
	
	public static void numcomp(int num1, int num2, int num3) {
		if(num1 > num2) {
			if(num2 > num3) {
				System.out.println(num1 + " - " + num2 + " - " + num3);
			}
			else if(num2 < num3) {
				if(num1 > num3) {
					System.out.println(num1 + " - " + num3 + " - " + num2);
				}
				else if(num1 < num3) {
					System.out.println(num3 + " - " + num1 + " - " + num2);
				}
			}
		}
		else if(num1 < num2) {
			if(num1 > num3) {
				System.out.println(num2 + " - " + num1 + " - " + num3);
			}
			else if(num1 < num3) {
				if(num2 < num3) {
					System.out.println(num3 + " - " + num2 + " - " + num1);
				}
				else if(num2 > num3) {
					System.out.println(num2 + " - " + num3 + " - " + num1);
				}
			}
		}
	}

}
