import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		/*Student student1 = new Student("홍길동", 20, 175, 70, "20170101", 1, 4.5);
		Student student2 = new Student("이순신", 30, 170, 80, "20090505", 4, 3.0);
		student1.show();
		student2.show();
		Teacher teacher1 = new Teacher("신사임당", 25, 180, 120, "ABC201", 3000000, 5);
		teacher1.show();
		
		
		Student[] students = new Student[100];
		for(int i = 0; i < 100; i++) {
			students[i] = new Student("홍길동", 20, 175, 70, i + "", 1, 4.5);
			students[i].show();
		}*/
		
		Scanner s = new Scanner(System.in);
		System.out.print("총 몇명? : ");
		int number = s.nextInt();
		Student[] students = new Student[number];
		for(int i = 0; i < number; i++) {
			String name;
			int age;
			int height;
			int weight;
			String studentID;
			int grade;
			double gPA;
			
			System.out.print("학생의 이름을 입력하세요 : ");
			name = s.nextLine();
			System.out.print("학생의 나이을 입력하세요 : ");
			age = s.nextInt();
			System.out.print("학생의 키를 입력하세요 : ");
			height = s.nextInt();
			System.out.print("학생의 몸무게를 입력하세요 : ");
			weight = s.nextInt();
			System.out.print("학생의 학번을 입력하세요 : ");
			studentID = s.nextLine();
			System.out.print("학생의 학년을 입력하세요 : ");
			grade = s.nextInt();
			System.out.print("학생의 학점을 입력하세요 : ");
			gPA = s.nextInt();
			students[i] =new Student(name, age, height, weight, studentID, grade, gPA);
		}
		for(int i = 0; i < number; i++) {
			students[i].show();
		}
		
	}

}
