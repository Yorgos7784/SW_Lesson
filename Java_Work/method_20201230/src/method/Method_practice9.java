package method;

import java.util.Scanner;

public class Method_practice9 {

	public static void main(String[] args) {
		
		Scanner s = new Scanner(System.in);
		System.out.print("수를 3개 입력하세요 : ");
		int num1 = s.nextInt();
		int num2 = s.nextInt();
		int num3 = s.nextInt();
		int arr[];
		arr = numcomp(num1, num2, num3);
		System.out.println("최대값 : " + arr[0]);
		System.out.println("최소값 : " + arr[1]);
	}
	
	public static int[] numcomp(int num1, int num2, int num3) {
		int arr[] = new int[] {num1, num2, num3};
		int arr2[] = new int [2];
		int max = arr[0];
		int min = arr[0];
		for(int i = 0; i < arr.length; i++) {
			if(max < arr[i]) {
				max = arr[i];
			}
			if(min > arr[i]) {
				min = arr[i];
			}
		}
		arr2[0] = max;
		arr2[1] = min;
		return arr2;
	}

}
