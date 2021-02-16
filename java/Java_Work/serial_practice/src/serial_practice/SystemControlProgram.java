package serial_practice;

import java.util.Scanner;
import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SystemControlProgram {
	static final int TV_ON = 1;
	static final int TV_OFF = 2;
	static final int BOILER_ON = 3;
	static final int CLEANER_ON = 4;
	static final int PROGRAM_EXIT = 5;
	static SerialPort serialPort;

	public static int getMenu(Scanner s) {
		System.out.println("-------------------------");
		System.out.println("   스마트 홈 프로그램 v1.0");
		System.out.println("-------------------------");
		System.out.println("   1. TV 켜기");
		System.out.println("   2. TV 끄기");
		System.out.println("   3. 보일러 동작");
		System.out.println("   4. 세틱기 동작");
		System.out.println("   5. 프로그램 종료");
		System.out.println("-------------------------");
		System.out.print("   메뉴 선택 : ");
		return s.nextInt();
	}
	
	public static void getSerialPort() {
		String[] portNames = SerialPortList.getPortNames();
		System.out.println(portNames[0]);
		serialPort = new SerialPort(portNames[0]);
		try {
			serialPort.openPort();
			serialPort.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1, SerialPort.PARITY_NONE);
		} catch (SerialPortException e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) throws SerialPortException {
		getSerialPort();
		Scanner s = new Scanner(System.in);
		while(true) {
			switch(getMenu(s)) {
			case TV_ON :
				System.out.println("TV ON!");
				serialPort.writeInt(Character.forDigit(TV_ON, 10));
				break;
			case TV_OFF :
				System.out.println("TV OFF!");
				serialPort.writeInt(Character.forDigit(TV_OFF, 10));
				break;
			case BOILER_ON :
				System.out.println("BOILER ON!");
				serialPort.writeInt(Character.forDigit(BOILER_ON, 10));
				break;
			case CLEANER_ON :
				System.out.println("CLEANER ON!");
				serialPort.writeInt(Character.forDigit(CLEANER_ON, 10));
				break;
			case PROGRAM_EXIT :
				System.out.println("BYE!");
				s.close();
				System.exit(0);
				break;
			}
		}
	}
}

//class WriteThread extends Thread{
//	SerialPort serial;
//
//	WriteThread(SerialPort serial) {
//		this.serial = serial;
//	}
//
//	public void run() {
//		try {
//			int c = 0;
//			while ((c = System.in.read()) > -1) {
//				serial.writeInt(c);
//			}
//		} catch (Exception e) {
//			e.printStackTrace();
//		}
//	}
//}
