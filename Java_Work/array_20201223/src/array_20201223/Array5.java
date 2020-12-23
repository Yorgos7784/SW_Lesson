package array_20201223;

public class Array5 {

	public static void main(String[] args) {

		int arr1[] = new int[100];
		int arr2[] = new int[100];
		for (int i = 0; i < arr1.length; i++) {
			arr1[i] = i * 2;
			System.out.print(arr1[i] + " ");
		}
		System.out.println("\n#############################");
		for (int j = 0; j < arr2.length; j++) {
			arr2[j] = arr1[99 - j];
			System.out.print(arr2[j] + " ");
		}

	}

}
