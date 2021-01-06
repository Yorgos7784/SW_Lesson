package name_maker;

public class NameMaker {
	private String fullName;
	static String first[] = {"김", "박", "이", "최", "장"};
	static String mid[] = {"가", "나", "다", "라", "마"};
	static String last[] = {"바", "사", "아", "자", "차"};
	
	public String fullName() {
		fullName = first[(int)(Math.random()*5)] + mid[(int)(Math.random()*5)] + last[(int)(Math.random()*5)];	
		return fullName;
	}
	
}
