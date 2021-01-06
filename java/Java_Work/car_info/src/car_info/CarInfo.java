package car_info;

public class CarInfo {
	static String deri = "동대구 영업소";
	private String madeCom;
	private String carColor;
	private String carModelName;
	private String carPrice;
	public String getMadeCom() {
		return madeCom;
	}
	public void setMadeCom(String madeCom) {
		this.madeCom = madeCom;
	}
	public String getCarColor() {
		return carColor;
	}
	public void setCarColor(String carColor) {
		this.carColor = carColor;
	}
	public String getCarModelName() {
		return carModelName;
	}
	public void setCarModelName(String carModelName) {
		this.carModelName = carModelName;
	}
	public String getCarPrice() {
		return carPrice;
	}
	public void setCarPrice(String carPrice) {
		this.carPrice = carPrice;
	}
	
	public void showCarInfo() {
		System.out.println("제조사 : " + madeCom);
		System.out.println("모델명 : " + carModelName);
		System.out.println("색상 : " + carColor);
		System.out.println("가격 : " + carPrice);
		System.out.println("대리점명 : " + deri);
		
	}
	
	
	
	
}
