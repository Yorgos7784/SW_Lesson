package array_20201223;

public class Array9 {

	public static void main(String[] args) {

		int arr[][] = {
				{1, 2, 3}, 
				{4, 5, 6}, 
				{7, 8, 9}, 
				{10, 11, 12}
		};
		
		for (int i = 0; i < arr.length; i++) {
			for (int j = 0; j < arr[i].length; j++) {
				System.out.printf("arr[%d][%d] : %d\t", i, j, arr[i][j]);
			}
			System.out.println();
		}
		System.out.println("-----------------------------------------------");
		
		int arr2[][] = {
				{1, 2, 3}, 
				{4, 5}, 
				{6, 7, 8}, 
				{9}
		};
		
		for (int i = 0; i < arr2.length; i++) {
			for (int j = 0; j < arr2[i].length; j++) {
				System.out.printf("arr2[%d][%d] : %d\t", i, j, arr2[i][j]);
			}
			System.out.println();
		}
		
		

	}

}
