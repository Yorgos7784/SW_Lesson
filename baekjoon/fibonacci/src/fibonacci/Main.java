package fibonacci;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println(fibonacci(s.nextInt()));
		
	}
	
	public static int fibonacci(int num) {
		if(num == 0) {
//			System.out.println("0");
			return 0;
		}
		else if(num == 1) {
//			System.out.println("1");
			return 1;
		}
		else {
			return fibonacci(num - 1) + fibonacci(num - 2);
		}
	}

}
