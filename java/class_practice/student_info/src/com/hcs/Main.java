package com.hcs;

public class Main {

	public static void main(String[] args) {
		System.out.println("학생 정보");
		String name[] = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
		int age[] = {20, 25, 30, 35, 40};
		char gender[] = {'남', '여'};
		String address[] = {"대구시 동구 신암4동", "서울시 동구 신암4동", "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
		
	}
	public static int randNum() {
		return (int)(Math.random()*5);
	}
	

}
