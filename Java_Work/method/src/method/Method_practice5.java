package method;

import java.util.Scanner;

public class Method_practice5 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("몇단이 궁금하느냐? : ");
		int num = s.nextInt();
		gugudan(num);

	}
	
	public static void gugudan(int num) {
		for(int i = 1; i <= 9; i++) {
			System.out.println(num + " x " + i + " = " + (num*i));
		}
	}

}
