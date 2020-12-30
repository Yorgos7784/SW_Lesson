package method_20201230;

public class Method_practice10 {

	public static void main(String[] args) {

		System.out.println(factorial(5));

	}
	
	public static int factorial(int a) {
		int result = 0;
		if(a == 1) {
			result = 1;
		}
		else {
			result = a * factorial(a-1);
		}
		return result;
	}

}
