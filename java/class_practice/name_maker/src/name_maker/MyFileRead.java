package name_maker;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.StringTokenizer;

public class MyFileRead {
	public void fileRead() throws IOException {
		BufferedReader br = new BufferedReader(new FileReader(new File("d:/names.txt")));
		String str = br.readLine();
		StringTokenizer stk = new StringTokenizer(str,"/");
		while(stk.hasMoreTokens()) {
			System.out.println(stk.nextToken());}
		br.close();
	}
}
