package method;

import java.util.Scanner;

public class Method_practice2 {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		System.out.print("첫번쨰 숫자를 입력하세요 : ");
		int num1 = s.nextInt();
		System.out.print("연산자(+, -, *, /)를 입력하세요 : ");
		String oper = s.next();
		System.out.print("두번쨰 숫자를 입력하세요 : ");
		int num2 = s.nextInt();
		
		System.out.println(calc(num1, oper, num2));
	}
	
	public static int calc (int num1, String oper, int num2) {
		int result = 0;
		if(oper.equals("+"))
		{
			result =  num1 + num2;
		}
		else if(oper.equals("-"))
		{
			result =  num1 - num2;
		}
		else if(oper.equals("*"))
		{
			result =  num1 * num2;
		}
		else if(oper.equals("/"))
		{
			result =  num1 / num2;
		}
		return result;
	}

}
