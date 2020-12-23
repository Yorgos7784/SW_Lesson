package class_tutorial1;

class Calculator2{
	// 클래스 변수
	static double PI = 3.14; // static : 클래스에 소속된 변수 => 모든 인스턴스에서 동일한 값을 갖는다.
	static int base = 0;
	int num1, num2;
	
	public void setOprands(int num1, int num2) {
		this.num1 = num1;
		this.num2 = num2;
	}
	public void sum() {
		System.out.println(this.num1 + this.num2 + base);
	}
	public void ave() {
		System.out.println((this.num1 + this.num2 + base) / 2);
	}
	// sum과 ave는 객체마다 다른 값을 갖는다.
	
	
	
}


public class Class_tutorial2 {

	public static void main(String[] args) {
		
		Calculator2 c1 = new Calculator2();
		c1.setOprands(10, 20);
		c1.sum();
		
		
		Calculator2 c2 = new Calculator2();
		c2.setOprands(20, 40);
		c2.sum();
		
		
		Calculator2.base = 10;
		
		c1.sum();
		
		c2.sum();
		
		
		
		
		
		
		
		
		
		
		
		
	}

}
