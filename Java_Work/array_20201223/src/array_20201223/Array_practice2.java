package array_20201223;

public class Array_practice2 {

	public static void main(String[] args) {

		int arr[] = new int[100];
		for (int i = 0; i < arr.length; i++) {
			arr[i] = i + 1;
			if(arr[i]%5 == 0 && i < 90) {
				System.out.println(arr[i]);
			}
		}
		

	}

}
