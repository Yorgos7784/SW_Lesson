package com.lg.carapp.car;

public class Car {
	static String deri = "동대구 영업소";
	private String madeCom;
	private String color;
	private String model;
	private String price;


	public Car() {
		madeCom = "기아";
		model = "K7";
		price = "4천만원";
		color = "블랙";
	}

	public String getMadeCom() {
		return madeCom;
	}

	public void setMadeCom(String madeCom) {
		this.madeCom = madeCom;
	}

	public String getColor() {
		return color;
	}

	public void setColor(String color) {
		this.color = color;
	}

	public String getModel() {
		return model;
	}

	public void setModel(String model) {
		this.model = model;
	}

	public String getPrice() {
		return price;
	}

	public void setPrice(String price) {
		this.price = price;
	}
	
	

	public Car(String madeCom, String color, String model, String price) {
		super();
		this.madeCom = madeCom;
		this.color = color;
		this.model = model;
		this.price = price;
	}

	public void showCarInfo() {
		System.out.println("제조사 : " + madeCom);
		System.out.println("색상 : " + color);
		System.out.println("모델 : " + model);
		System.out.println("가격 : " + price);
		System.out.println("대리점명 : " + deri);
		System.out.println("-------------------");
	}

}
