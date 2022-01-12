package laba3;

import java.util.Scanner;

public class First {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		System.out.println("¬ведите знаменатель первой дроби. : ");
		int num1 = sc.nextInt();
		System.out.println("¬ведите числитель первой дроби.");
		int num2 = sc.nextInt();
		System.out.println("¬ведите знаменатель второй дроби.");
		int num3 = sc.nextInt();
		System.out.println("¬ведите числитель второй дроби.");
		int num4 = sc.nextInt();
		
		
		System.out.println("„ислитель равен:" + (num1*num3) + "\n«наменатель равен: " + (num2*num4));
		
	}
}
