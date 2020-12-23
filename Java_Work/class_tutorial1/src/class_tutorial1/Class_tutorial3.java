package class_tutorial1;

class Calculator3{
				
	public static void sum(int num1, int num2) {
		System.out.println(num1 + num2);
	}
	public static void ave(int num1, int num2) {
		System.out.println((num1 + num2) / 2);
	}
}

public class Class_tutorial3 {

	public static void main(String[] args) {

		Calculator3.sum(10,20);
		Calculator3.ave(10,20);
		
		Calculator3.sum(20,40);
		Calculator3.ave(20,40);

	}

}
