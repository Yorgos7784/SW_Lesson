package array_20201223;

import java.util.Scanner;

public class Array1 {

	public static void main(String[] args) {

		Scanner s= new Scanner(System.in);
		int arr[] = new int [3];
		int hap = 0;
		System.out.print("1번째 숫자 입력 : ");
		arr[0] = s.nextInt();
		System.out.print("2번째 숫자 입력 : ");
		arr[1] = s.nextInt();
		System.out.print("3번째 숫자 입력 : ");
		arr[2] = s.nextInt();
		
		for(int i = 0; i < 3; i++) {
			hap += arr[i];
		}
		System.out.println("arr 배열의 합 : " + hap);
		s.close();
	}

}
