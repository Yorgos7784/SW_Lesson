import java.util.Scanner;

public class Switch_Practice {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		// 식당 메뉴 자동 주문 프로그램

		System.out.println("-------------------------");
		System.out.println("식당 메뉴 자동 주문 프로그램 v1.0");
		System.out.println("-------------------------");
		System.out.println("1. 김치찌개 : 5,000원");
		System.out.println("2. 된장찌개 : 5,000원");
		System.out.println("3. 칼국수  : 4,500원");
		System.out.println("4. 잔치국수 : 4,000원");
		System.out.println("5. 비빔밥  : 5,000원");
		System.out.println("-------------------------");
		System.out.print("메뉴를 선택하세요 : ");
		int menu = s.nextInt();

		System.out.println("-------------------------");
		switch (menu) {
		case 1:
			System.out.println("김치찌개를 주문했습니다.");
			break;
		case 2:
			System.out.println("된장찌개를 주문했습니다.");
			break;
		case 3:
			System.out.println("칼국수를 주문했습니다.");
			break;
		case 4:
			System.out.println("잔치국수를 주문했습니다.");
			break;
		case 5:
			System.out.println("비빔밥을 주문했습니다.");
		}

		// 간단 계산기 프로그램

		System.out.println("-------------------");
		System.out.println("간단 계산기 프로그램 v2.0");
		System.out.println("-------------------");
		System.out.print("첫번째 숫자를 입력하세요 : ");
		int num1 = s.nextInt();
		System.out.println("-------------------");
		System.out.print("두번째 숫자를 입력하세요 : ");
		int num2 = s.nextInt();
		System.out.println("-------------------");
		System.out.print("연산자를 입력하세요(+, -, x, /) : ");
		String str = s.next();

		System.out.println("-------------------");
		switch (str) {
		case "+":
			System.out.println(num1 + " + " + num2 + " = " + (num1 + num2));
			break;
		case "-":
			System.out.println(num1 + " - " + num2 + " = " + (num1 - num2));
			break;
		case "x":
			System.out.println(num1 + " x " + num2 + " = " + (num1 * num2));
			break;
		case "/":
			System.out.println(num1 + " / " + num2 + " = " + (num1 / num2));
			break;
		}

		// 담배 자판기 프로그램
		System.out.println("-------------------");
		System.out.println("담배 자판기 프로그램 v1.0");
		System.out.println("-------------------");
		System.out.println("1. 에쎄 골든 리프   : 6,000원");
		System.out.println("2. 에쎼 스페셜 골드 : 5,000원");
		System.out.println("3. 더원 블루      : 4,500원");
		System.out.println("4. 더원 오랜지     : 4,500원");
		System.out.println("5. 더원 화이트     : 4,500원");
		System.out.println("-------------------------");
		System.out.print("담베를 선택하세요 : ");
		int menu2 = s.nextInt();

		System.out.println("-------------------------");
		switch (menu2) {
		case 1:
			System.out.println("에쎄 골든 리프를 주문했습니다.");
			break;
		case 2:
			System.out.println("에쎄 스페셜 골드를 주문했습니다.");
			break;
		case 3:
			System.out.println("더원 블루를 주문했습니다.");
			break;
		case 4:
			System.out.println("더원 오랜지를 주문했습니다.");
			break;
		case 5:
			System.out.println("더원 화이트를 주문했습니다.");
		}
		System.out.println("-------------------------");
		System.out.print("금액을 입력하세요 : ");
		int price = s.nextInt();

		System.out.println("-------------------------");
		switch (menu2) {
		case 1:
			if (price >= 6000) {
				System.out.println("거스름돈 " + (price - 6000) + "원을 받으세요.");
			} else if (price < 6000) {
				System.out.println("금액이 부족합니다.");
			}
			break;
		case 2:
			if (price >= 5000) {
				System.out.println("거스름돈 " + (price - 5000) + "원을 받으세요.");
			} else if (price < 5000) {
				System.out.println("금액이 부족합니다.");
			}
			break;
		case 3:
			if (price >= 4500) {
				System.out.println("거스름돈 " + (price - 4500) + "원을 받으세요.");
			} else if (price < 4500) {
				System.out.println("금액이 부족합니다.");
			}
			break;
		case 4:
			if (price >= 4500) {
				System.out.println("거스름돈 " + (price - 4500) + "원을 받으세요.");
			} else if (price < 4500) {
				System.out.println("금액이 부족합니다.");
			}
			break;
		case 5:
			if (price >= 4500) {
				System.out.println("거스름돈 " + (price - 4500) + "원을 받으세요.");
			} else if (price < 4500) {
				System.out.println("금액이 부족합니다.");
			}
			break;
		}
		s.close();

	}

}
