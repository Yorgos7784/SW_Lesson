package queation1;

public class Question4 {

	public static void main(String[] args) {

		for (int i = 0; i < 5; i++) {
			for (int j = 5; j > i; j--) {
				System.out.print(" ");
			}
			for (int j = 0; j < (i*2)+1; j++) {
				System.out.print("*");
			}
			System.out.println();
		}

	}

}
