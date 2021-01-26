import java.util.Scanner;
public class Test_5 {
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		String input = s.next();
		char word[] = input.toCharArray();
		for (int i = 0; i < word.length; i++) {
			if((int)(word[i]) < 97) {
				word[i] = (char)((int)(word[i]+32));
			}
		}
		int count[] = new int[26];
		char letters[] = new char[26];
		for (int i = 0; i < letters.length; i++) {
			letters[i] = (char)(i + 97);
		}
		for (int i = 0; i < letters.length; i++) {
			int countword = 0;
			for (int j = 0; j < word.length; j++) {
				if(letters[i] == word[j])
					countword++;
			}
			count[i] = countword;
		}
		for (int i = 0; i < count.length; i++) {
			if(count[i] != 0) {
				System.out.println("'" + (char)letters[i] + "' 는" + count[i] + "글자입니다.");
			}
		}
	}
}