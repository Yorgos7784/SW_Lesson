package array_20201223;

public class Array_practice5 {

	public static void main(String[] args) {

		int arr[][] = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
		int arr2[][] = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
		int sum[][] = new int[3][3];
		System.out.println("arr배열");
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.print(arr[i][j] + " ");
			}
			System.out.println();
		}
		System.out.println("--------------------------");
		System.out.println("arr2배열");
		for (int i = 0; i < arr2.length; i++) {
			for (int j = 0; j < arr2[i].length; j++) {
				System.out.print(arr2[i][j] + " ");
			}
			System.out.println();
		}
		System.out.println("--------------------------");
		System.out.println("두 배열의 합");
		for (int i = 0; i < sum.length; i++) {
			for (int j = 0; j < sum[i].length; j++) {
				sum[i][j] = arr[i][j] + arr2[i][j];
				System.out.print(sum[i][j] + " ");
			}
			System.out.println();
		}

	}

}
