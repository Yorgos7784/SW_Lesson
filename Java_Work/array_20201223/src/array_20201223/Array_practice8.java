package array_20201223;

import java.util.Random;

public class Array_practice8 {

	public static void main(String[] args) {
		Random r = new Random();
		int lotto[] = new int[6];
		for(int i = 0; i < lotto.length; i++) {
			lotto[i] = r.nextInt(45)+1;
			for(int j = 0; j < i; j++) {
				if(lotto[i] == lotto[j]) {
					i--;
				}
			}
		}
		for(int i = 0; i < lotto.length; i++) {
			System.out.println(lotto[i]);
		}

	}

}
