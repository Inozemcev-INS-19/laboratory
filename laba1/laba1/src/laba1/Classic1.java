package laba1;
import  java.util.Scanner;
import java.lang.Math;
import java.util.ArrayList;
import java.util.Collections;
public class Classic1 {
	
	public static void Task() 
	{
		Scanner sc = new Scanner(System.in);
		double num1;
		double N = sc.nextDouble();
		
		ArrayList<Double> list1 = new ArrayList();
		
		for(int i = 0; i<N; i++) {
			System.out.print("¬ведите число"+String.valueOf(i+1)+ " - ");
			num1 = sc.nextDouble();
			list1.add(num1);
		}
		
		double max1 = Collections.max(list1);
		
		int num = list1.indexOf(max1)+1;
		
		double num2 = list1.get(num);
		int sum = 0;
		System.out.println(Math.pow((num+num2), 2));
		
		//
	}
}
