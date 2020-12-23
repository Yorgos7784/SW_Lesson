package class_tutorial1;



class Calculator{
		
	int num1, num2;
	
	public void setOprands(int num1, int num2) {
		this.num1 = num1;
		this.num2 = num2;
	}
	public void sum() {
		System.out.println(this.num1 + this.num2);
	}
	public void ave() {
		System.out.println((this.num1 + this.num2) / 2);
	}
}


public class Class_tutorial {

	public static void main(String[] args) {
		
		
		Calculator c1 = new Calculator(); // Calculator() : 객체
		c1.setOprands(10, 20);
		c1.sum();
		c1.ave();
		
		Calculator c2 = new Calculator();
		c2.setOprands(20, 40);
		c2.sum();
		c2.ave();
	}

}
