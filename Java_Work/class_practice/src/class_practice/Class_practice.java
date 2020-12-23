package class_practice;

class Arrsumave{
	int sum = 0;
	int ave = 0;
	
	public int[] makeArr(int arr[]){
		for(int i = 0; i < arr.length; i++) {
			arr[i] = (i+1)*10;
		}
		return arr;
	}
	
	public int arrsum (int arr[]) {
		for(int i = 0; i < arr.length; i++) {
			sum += arr[i];
		}
		return sum;
	}
	public int arrave (int arr[]) {
		ave = sum / arr.length;
		return ave;
	}
	
	
}


public class Class_practice {

	public static void main(String[] args) {
		Arrsumave asv = new Arrsumave();
		int arr[] = new int[10];
		asv.makeArr(arr);
					
		System.out.println("arr배열의 합 : " + asv.arrsum(arr));
		System.out.println("arr배열의 평균 : " + asv.arrave(arr));
		
		
		

	}

}
