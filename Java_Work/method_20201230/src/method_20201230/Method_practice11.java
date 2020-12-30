package method_20201230;

import java.util.Scanner;

public class Method_practice11 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int students[][] = studentscore();
		scoretable(students);
		System.out.print("몇 번 학생이 궁금하세요? : ");
		int stunum = s.nextInt();
		int sum = scoresum(students, stunum);
		double ave = scoreave(sum);
		String hakjeom = hakjeom(ave);
		System.out.println("-------------------");
		System.out.println(stunum + "번 학생 결과");
		System.out.println("총점 : " + sum);
		System.out.println("평균 : " + ave);
		System.out.println("학점 : " + hakjeom);
		
		
		
	}
	
	public static int[][] studentscore() {
		int score[][] = new int[5][3];
		for (int i = 0; i < score.length; i++) {
			for (int j = 0; j < score[i].length; j++) {
				score[i][j] = (int)(Math.random()*100)+1;
			}
		}
		return score;
	}
	
	public static void scoretable(int arr [][]) {
		for (int i = 0; i < arr.length; i++) {
			System.out.print((i+1) + "번째 학생 점수 : ");
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j] + "\t");
			}
			System.out.println();
		}
	}
	
	public static int scoresum(int arr[][], int num) {
		int sum = 0;
		for (int i = 0; i < arr[num-1].length; i++) {
			sum += arr[num-1][i];
		}
		return sum;
	}
	
	public static double scoreave(int num) {
		double ave = num/3.0;
		return ave;
	}
	
	public static String hakjeom(double num) {
		String hakjeom = "";
		if(100 >= num && num >= 90) {
			hakjeom = "A";
		}
		else if(89 >= num && num >= 80) {
			hakjeom = "B";
		}
		else if(79 >= num && num >= 70) {
			hakjeom = "C";
		}
		else if(69 >= num && num >= 60) {
			hakjeom = "D";
		}
		else {
			hakjeom = "f";
		}
		return hakjeom;
	}
	

}
