package laba3;

import java.util.Scanner;

public class First {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		System.out.println("������� ����������� ������ �����. : ");
		int num1 = sc.nextInt();
		System.out.println("������� ��������� ������ �����.");
		int num2 = sc.nextInt();
		System.out.println("������� ����������� ������ �����.");
		int num3 = sc.nextInt();
		System.out.println("������� ��������� ������ �����.");
		int num4 = sc.nextInt();
		
		
		System.out.println("��������� �����:" + (num1*num3) + "\n����������� �����: " + (num2*num4));
		
	}
}
