package class_tutorial1;

class C1 {
	static int static_variable = 1;
	int intstance_variable = 2;
	static void static_static() {
		System.out.println(static_variable);
	}
	static void static_intstance() {
		// 클래스 메소드에서는 인스턴스 변수에 접근할 수 없다.
		// System.out.println(instance_variable);
	}
	void instance_static() {
		// 클래스 메소드에서는 인스턴스 변수에 접근할 수 있다.
		System.out.println(static_variable);
	}
	void instance_instance() {
		System.out.println(intstance_variable);
	}
	
}


public class Class_tutorial4 {

	public static void main(String[] args) {
		C1 c = new C1();
		c.static_static();
		c.static_intstance();
		c.instance_static();
		c.instance_instance();
		
		

	}

}
