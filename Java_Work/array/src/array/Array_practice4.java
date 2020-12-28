package array;

import java.util.Scanner;

public class Array_practice4 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String que[] = {"1 + 2 = ", "2 + 3 = ", "3 + 5 = ", "5 + 8 = ", "8 + 13 = "};
		int ans[] = {3, 5, 8, 13, 21};
		String score[] = new String[que.length];
		for(int i = 0; i < que.length; i++) {
			System.out.print(que[i]);
			int input = s.nextInt();
			if(input == ans[i]) {
				score[i] = "O";
			}
			else {
				score[i] = "X";
			}
		}
		

	}

}
