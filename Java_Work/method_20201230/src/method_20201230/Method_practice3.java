package method_20201230;

import java.util.Scanner;

public class Method_practice3 {

	public static void main(String[] args) {
		for (int i = 0; i < 10; i++) {
			holjjack((int)(Math.random()*100)+1);
		}

	}
	
	public static void holjjack(int a) {
		if(a % 2 == 0) {
			System.out.println(a + "는 짝수입니다.");
		}
		else if(a % 2 == 1) {
			System.out.println(a + "는 홀수입니다.");
		}
		else {
			System.out.println("판단불가");
		}
	}

}
