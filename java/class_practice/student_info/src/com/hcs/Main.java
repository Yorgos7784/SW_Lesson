package com.hcs;

public class Main {

	public static void main(String[] args) {
		System.out.println("학생 정보");
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'남', '여'};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		
		StudentInfo student1 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student2 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student3 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student4 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student5 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student6 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student7 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student8 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student9 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		StudentInfo student10 = new StudentInfo(name[randNum()], age[randNum()], gender[(int)(Math.random()*2)], address[randNum()]);
		student1.showStudentInfo();
		student2.showStudentInfo();
		student3.showStudentInfo();
		student4.showStudentInfo();
		student5.showStudentInfo();
		student6.showStudentInfo();
		student7.showStudentInfo();
		student8.showStudentInfo();
		student9.showStudentInfo();
		student1.showStudentInfo();
		
		
		
		

	}
	public static int randNum() {
		return (int)(Math.random()*5);
	}
	

}
