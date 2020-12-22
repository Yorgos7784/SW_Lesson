package method;

import java.util.Random;
import java.util.Scanner;

public class Method_practice6 {

	public static void main(String[] args) {

		int arr[];
		arr = lotto();
		for(int i = 0; i < arr.length; i++) {
			System.out.println(arr[i]);
		}

	}

	public static int[] lotto() {
		Random rand = new Random();
		int arr[] = new int[6];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = rand.nextInt(45) + 1;
			
		}
		return arr;
	}

}
