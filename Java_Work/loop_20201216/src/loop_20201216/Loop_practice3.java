package loop_20201216;

import java.util.Random;

public class Loop_practice3 {

	public static void main(String[] args) {

		Random rand = new Random();
		
		System.out.println("---------------------");
		System.out.println("간단한 로또 프로그램 v1.0");
		System.out.println("---------------------");
		for(int i=0; i<5; i++) {
			int num1 = rand.nextInt(45) + 1;
			System.out.print(num1 + " ");
		}
		
		
		

	}

}
