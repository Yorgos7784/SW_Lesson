package method;

public class Method_practice7 {

	public static void main(String[] args) {
		int arr[];
		arr = holjjack();
		System.out.println("1부터 100까지의 짝수의 합 : " + arr[0]);
		System.out.println("1부터 100까지의 홀수의 합 : " + arr[1]);
	}
	
	public static int[] holjjack() {
		int arr[] = new int[2];
		int holsum = 0;
		int jjacksum = 0;
		for(int i = 1; i <= 100; i++) {
			if(i%2 == 0) {
				jjacksum += i;
			}
			else {
				holsum += i;
			}
		}
		arr[0] = holsum;
		arr[1] = jjacksum;
		return arr;
	}
	
	

}
