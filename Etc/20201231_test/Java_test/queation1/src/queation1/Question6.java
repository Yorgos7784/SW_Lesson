package queation1;

import java.util.Scanner;

public class Question6 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("�ִ밪�� �Է��ϼ��� : ");
		int max = s.nextInt();
		System.out.print("������ ����� �Է��ϼ��� : ");
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