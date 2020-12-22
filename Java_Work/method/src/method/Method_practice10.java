package method;

public class Method_practice10 {

	public static void main(String[] args) {

		System.out.println("3팩토리얼은 : " + factorial(3));

	}
	
	public static int factorial(int num) {
		if(num == 1) {
			return 1;
		}
		else {
			return num*factorial(num-1);
		}
	}

}
