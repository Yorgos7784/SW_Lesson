package name_maker;

import java.io.IOException;

public class Main {

	public static void main(String[] args) throws IOException {

		NameMaker newNames = new NameMaker();
		String babyNames[] = new String[50];
		for (int i = 0; i < babyNames.length; i++) {
			babyNames[i] = newNames.fullName();
		}
		
		MyFileWrite writeFile = new MyFileWrite();
		writeFile.fileWrite(babyNames);
		
		MyFileRead readFile = new MyFileRead();
		readFile.fileRead();
	}

}
