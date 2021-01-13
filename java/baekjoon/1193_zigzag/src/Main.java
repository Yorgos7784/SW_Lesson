import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		int x = s.nextInt();
		int count = 1;
		int a = 1;
		int b = 1;
		while(true) {
			b++;
			count++;
			if(count == x) {
				break;
			}
			a++;
			b--;
			count++;
			if(count == x) {
				break;
			}
			a++;
			count++;
			if(count == x) {
				break;
			}
			a--;
			b++;
			count++;
			if(count == x) {
				break;
			}
		}
		System.out.println(a + "/" + b);

	}

}
