package array_20201223;

public class Array8 {

	public static void main(String[] args) {

		int arr[][] = new int[4][3];
		int value = 1;
		
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 3; j++) {
				arr[i][j] = value++;
				
			}
		}
		
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 3; j++) {
				System.out.printf("arr[%d][%d] : %d\t", i, j, arr[i][j]);
			}
			System.out.println();
		}
		

	}

}