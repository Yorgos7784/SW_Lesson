package array;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		
		int arr[] = new int[s.nextInt()];
				
		for(int i = 0; i < arr.length; i++) {
			arr[i] = s.nextInt();
						
		}
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
			
		System.out.println(max + " " + min);
		s.close();

	}

}
