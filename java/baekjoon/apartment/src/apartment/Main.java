package apartment;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
//		int t = s.nextInt();
		int k = s.nextInt();
		int n = s.nextInt();
		int sum = 0;
		for (int i = 1; i < k; i++) {
			sum+=i;
			for (int j = 1; j < n; j++) {
				sum += j;
			}
		}
		System.out.println(sum);

	}

}
