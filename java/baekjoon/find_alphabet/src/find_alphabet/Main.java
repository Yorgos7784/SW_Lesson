package find_alphabet;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner scan = new Scanner(System.in);
		String s = scan.next();
		char[] spell = s.toCharArray();
		char[] alpha = new char[26];
		for (int i = 0; i < alpha.length; i++) {
			alpha[i] = (char)(97 + i);
		}
		int result[] = new int[alpha.length]; 
		for (int i = 0; i < alpha.length; i++) {
			int count = 0;
			for (int j = 0; j < spell.length; j++) {
				if((int)alpha[i] == (int)spell[j]) {
					result[i] = j;
					break;
				}
				else {
					result[i] = -1;
				}
				
			}
		}
		for (int i = 0; i < result.length; i++) {
			System.out.print(result[i] + " ");
		}
	}

}
