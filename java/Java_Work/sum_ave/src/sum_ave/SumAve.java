package sum_ave;

public class SumAve {
	private int sum;
	private int ave;
	
	public int numSum(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];
		}
		return sum;
	}
	
	public int numAve(int arr[]) {
		for (int i = 0; i < arr.length; i++) {
			sum += arr[i];
		}
		ave = sum / arr.length;
		return ave;
	}
}
