package array;

import java.util.Scanner;

public class Array_practice2 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("숫자를 입력하세요(배열 크기) : ");
		int arr[] = new int[s.nextInt()];
		System.out.print("수를 입력하세요 : ");
		
		for(int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
						
		}
		int max = arr[0];
		int min = arr[0];
		int maxnum = 0;
		int minnum = 0;
		for(int i = 0; i < arr.length; i++) {
			if(max < arr[i]) {
				max = arr[i];
				maxnum = i+1;
			}
			else if(max == arr[0]) {
				maxnum = 1;
			}
			if(min > arr[i]) {
				min = arr[i];
				minnum = i+1;
			}
			else if(min == arr[0]) {
				minnum = 1;
			}
			
		}
			
		System.out.println("최댓값 : " + max + "(" + maxnum + "번째)");
		System.out.println("최솟값 : " + min + "(" + minnum + "번째)");
		
		s.close();
		
		
		
		
		
		

	}

}
