package queation1;

import java.util.Scanner;

public class Question6 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("최대값을 입력하세요 : ");
		int max = s.nextInt();
		System.out.print("제외할 배수를 입력하세요 : ");
		int exception = s.nextInt();
		int sum = 0;
		for (int i = 1; i <= max; i++) {
			if(i%exception != 0) {
				sum += i;
			}
		}
		System.out.println(sum);
		
		s.close();

	}

}
