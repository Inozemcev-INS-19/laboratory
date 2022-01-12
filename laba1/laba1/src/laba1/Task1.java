package laba1;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Task1 {
	
	private ArrayList<Double> list1 = new ArrayList();
	private double N;
	
	public void Input() {
		
		list1.clear();
		Scanner sc = new Scanner(System.in);
		double num1;
		N = sc.nextDouble();
		
		
		for(int i = 0; i<N; i++) {
			System.out.print("¬ведите число"+String.valueOf(i+1)+ " - ");
			num1 = sc.nextDouble();
			list1.add(num1);
		}
		sc.close();
	}
	
	public void Print() {
		
		double max1 = Collections.max(list1);
		
		int num = list1.indexOf(max1)+1;
		double num2 = list1.get(num);
		int sum = 0;
		System.out.println(Math.pow((num+num2), 2));
	
	}
}
