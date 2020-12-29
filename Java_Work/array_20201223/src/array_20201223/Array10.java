package array_20201223;

import java.util.Scanner;

public class Array10 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("행의 개수 입력 : ");
		int row = s.nextInt();
		System.out.print("열의 개수 입력 : ");
		int col = s.nextInt();
		
		
		int arr[][] = new int[row][col];
		int value = 1;
		for (int i = 0; i < row; i++) {
			for (int j = 0; j < col; j++) {
				arr[i][j] = value++;
				System.out.printf("arr[%d][%d] : %d\t", i, j, arr[i][j]);
			}
			System.out.println();
		}
		
	}

}
