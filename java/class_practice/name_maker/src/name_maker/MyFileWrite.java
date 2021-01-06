package name_maker;

import java.io.BufferedOutputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class MyFileWrite {
	public void fileWrite(String[] name) {
		BufferedOutputStream bs = null;
		try {
			bs = new BufferedOutputStream(
					new FileOutputStream("d:/names.txt"));
			for(int i = 0; i< name.length; i++) {
				bs.write(name[i].getBytes());
				bs.write("/".getBytes());
			}
			bs.close();
		}
		catch(FileNotFoundException e) {
			e.printStackTrace();
		}
		catch(IOException e) {
			e.printStackTrace();
		}
	}
}
