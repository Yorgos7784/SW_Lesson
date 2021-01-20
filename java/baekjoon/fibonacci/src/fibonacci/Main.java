package fibonacci;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int arr[] = new int[s.nextInt()];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
		}
		
		for (int i = 0; i < arr.length; i++) {
			if(arr[i] == 0) {
				System.out.println(1 + " " + 0);
			}
			else {
				int count0 = fibonacci(arr[i]-1);
				int count1 = fibonacci(arr[i]);
				System.out.println(count0 + " " + count1);
			}
		}
		
		
//		int n = s.nextInt();
//		System.out.println(fibonacci(n));
//		if(n == 0) {
//			System.out.println(1 + " " + 0);
//		}
//		else {
//			int count0 = fibonacci(n-1);
//			int count1 = fibonacci(n);
//			System.out.println(count0 + " " + count1);
//		}
		
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
