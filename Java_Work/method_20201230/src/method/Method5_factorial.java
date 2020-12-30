package method;

public class Method5_factorial {

	public static void main(String[] args) {

		System.out.println("3 factorial : " + factorial(3));
		System.out.println("12 factorial : " + factorial(12));
	}

	public static int factorial(int n) {
		// 5 factorial = 5 * 4 * 3 * 2 * 1
		// = 5 * 4 factorial
		if (n == 1) 
			return 1;
		else
			return n * factorial(n - 1);
	}

}
