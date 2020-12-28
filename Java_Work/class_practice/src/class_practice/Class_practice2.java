package class_practice;

import java.util.Random;

public class Class_practice2 {

	public static void main(String[] args) {
	
		String first[] = {"김", "박", "이", "최", "장"};
		String mid[] = {"가", "나", "다", "라", "마"};
		String last[] = {"바", "사", "아", "자", "차"};
		NameCreator name1 = new NameCreator();
		System.out.println(name1.makeName(first, mid, last));
		

	}

}

class NameCreator{
	String fullname;
	
	public String makeName (String first[], String mid[], String last[]) {
		Random rand = new Random();
		fullname = first[rand.nextInt(5)] + mid[rand.nextInt(5)] + last[rand.nextInt(5)];
		return fullname;
	}
	
}