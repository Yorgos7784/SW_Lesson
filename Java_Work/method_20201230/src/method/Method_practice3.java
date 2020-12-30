package method;

import java.util.Random;

public class Method_practice3 {

	public static void main(String[] args) {

		Random rand = new Random();
		int arr[] = new int[10];
		for(int i = 0; i < arr.length; i++) {
			arr[i] = rand.nextInt(100)+1;
			holjjack(arr[i]);
		}

	}
	
	public static void holjjack(int num) {
		if(num%2 == 0)
			System.out.println(num + "은 짝수입니다.");
		else
			System.out.println(num + "은 홀수입니다.");
	}

}
