package array_20201223;

public class Array_practice6 {

	public static void main(String[] args) {

		int arr[][] = new int[9][8];
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				arr[i][j] = (i + 1) * (j + 2);
				System.out.printf("%d x %d = %d\t", j+2, i+1, arr[i][j]);
			}
			System.out.println();
		}

	}

}
