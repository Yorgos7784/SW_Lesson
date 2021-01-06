package studentScore;

public class Main {

	public static void main(String[] args) {

		StudentScore studentA = new StudentScore();
		studentA.setStudentName("홍길동");
		studentA.setKor(randScore());
		studentA.setEng(randScore());
		studentA.setMath(randScore());
		studentA.showStudentScore();

		StudentScore studentB = new StudentScore();
		studentA.setStudentName("최길동");
		studentA.setKor(randScore());
		studentA.setEng(randScore());
		studentA.setMath(randScore());
		studentA.showStudentScore();

		StudentScore studentC = new StudentScore();
		studentA.setStudentName("김길동");
		studentA.setKor(randScore());
		studentA.setEng(randScore());
		studentA.setMath(randScore());
		studentA.showStudentScore();

		StudentScore studentD = new StudentScore();
		studentA.setStudentName("이길동");
		studentA.setKor(randScore());
		studentA.setEng(randScore());
		studentA.setMath(randScore());
		studentA.showStudentScore();

		StudentScore studentE = new StudentScore();
		studentA.setStudentName("강길동");
		studentA.setKor(randScore());
		studentA.setEng(randScore());
		studentA.setMath(randScore());
		studentA.showStudentScore();

	}
	
	public static int randScore() {
		return (int)(Math.random()*91)+10;
	}

}
