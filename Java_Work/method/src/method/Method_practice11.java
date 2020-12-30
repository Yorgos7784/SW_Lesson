package method;

import java.util.Random;
import java.util.Scanner;

public class Method_practice11 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int arr[][];
		arr = score();
		scoretable(arr);
		System.out.print("몇 번 학생의 성적이 궁금하신가요? : ");
		int num = s.nextInt();
		System.out.println("총점 : " + sum(arr, num));
		System.out.println("평균 : " + ave(arr, num));
		hakjeom(ave(arr, num));
		

	}
	
	public static int[][] score(){
		Random rand = new Random();
		int[][] arr = new int[5][3];
		for(int i = 0; i < arr.length; i++) {
			for(int j = 0; j < arr[i].length; j++) {
				arr[i][j] = rand.nextInt(100)+1;
			}
		}
		return arr;
	}
	
	public static void hakjeom(double num) {
		
		if(100>=num && num >=90) {
			System.out.println("A학점");
		}
		else if(89>=num && num >=80) {
			System.out.println("B학점");
		}
		else if(79>=num && num >=70) {
			System.out.println("C학점");
		}
		else if(69>=num && num >=60) {
			System.out.println("D학점");
		}
		else {
			System.out.println("F학점");
		}
		
	}
	
	public static void scoretable(int arr[][]) {
		for(int i = 0; i < arr.length; i++) {
			System.out.print((i+1) + "번 학생 : ");
			for(int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j] + "	");
			}
			System.out.println();
		}
	}
	public static int sum(int arr[][], int num) {
		return arr[num-1][0] + arr[num-1][1] + arr[num-1][2];
	}
	public static double ave(int arr[][], int num) {
		return sum(arr, num)/3.0;
	}
	

}
