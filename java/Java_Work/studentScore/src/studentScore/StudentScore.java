package studentScore;

public class StudentScore {
	private String studentName;
	private int kor;
	private int eng;
	private int math;
	
	public String getStudentName() {
		return studentName;
	}
	public void setStudentName(String studentName) {
		this.studentName = studentName;
	}
	public int getKor() {
		return kor;
	}
	public void setKor(int kor) {
		this.kor = kor;
	}
	public int getEng() {
		return eng;
	}
	public void setEng(int eng) {
		this.eng = eng;
	}
	public int getMath() {
		return math;
	}
	public void setMath(int math) {
		this.math = math;
	}
	
	public int totalScore() {
		int totalScore = kor + eng + math;
		return totalScore;
	}
	public double ave() {
		double ave = totalScore() / 3.0;
		return ave;
	}
	
	public String hakjeom() {
		String hakjeom;
		if(ave() <= 100 && ave() >= 90) {
			hakjeom = "A";
		}
		else if(ave() <= 89 && ave() >= 80) {
			hakjeom = "B";
		}
		else if(ave() <= 79 && ave() >= 70) {
			hakjeom = "C";
		}
		else if(ave() <= 69 && ave() >= 60) {
			hakjeom = "D";
		}
		else {
			hakjeom = "F";
		}
		return hakjeom;
	}
	
	
	public void showStudentScore() {
		System.out.println("학생 이름 : " + studentName);
		System.out.println("국어 점수 : " + kor);
		System.out.println("영어 점수 : " + eng);
		System.out.println("수학 점수 : " + math);
		System.out.println("  총점   : " + totalScore());
		System.out.println("  평균   : " + ave());
		System.out.println("  학점   : " + hakjeom());
		System.out.println("-----------------------------");
	}
	
	
}
