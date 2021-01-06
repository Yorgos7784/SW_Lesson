package sum_ave;

public class Main {

	public static void main(String[] args) {

		int arr[] = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
		int sum = new SumAve().numSum(arr);
		int ave = new SumAve().numAve(arr);
		System.out.println("배열의 합 : " + sum);
		System.out.println("배열의 평균 : " + ave);
	}

}
