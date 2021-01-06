package array_20201223;

public class Array_practice3 {

	public static void main(String[] args) {

		int arr[] = new int[10];
		int arr2[] = new int[10];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = (i + 1) * 10;
		}
		for(int i = 0; i < 10; i++) {
			arr2[i] = arr[9-i];
			System.out.println(arr2[i]);
		}

	}

}
