package star_creater;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int n = s.nextInt();
		
	}

	public static String[][] star() {
		String arr[][] = new String[3][3];
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				if (i > 0 && i < arr.length - 1 && j > 0 && j < arr.length - 1) {
					if (i == j) {
						arr[i][j] = " ";
					} else {
						arr[i][j] = "*";
					}
				} else {
					arr[i][j] = "*";
				}
			}
		}
		return arr;
	}
	
	public static void bigstar(String arr[][]) {
				
	}

//	public static String[][]bigstar(String samsam[][]) {
//		String arr[][] = new String[3][3];
//		for (int i = 0; i < arr.length; i++) {
//			for (int j = 0; j < arr[i].length; j++) {
//				if(i > 0 && i < arr.length-1 && j > 0 && j < arr.length-1) {
//					if(i == j) {
//						arr[i][j] = " ";
//					}
//					else {
//						arr[i][j] = "*";
//					}
//				}
//				else {
//					arr[i][j] = "*";
//				}
//			}
//		}
//		return arr;
//	}

}
