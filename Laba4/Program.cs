using System;
using System.IO;
using System.Collections.Generic;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод с txt
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
           
            //объявление массива 
            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for (int i = 0; i < N; i++) mas[i] = Convert.ToInt32(str_elem[i]);


            //Кратность 10
            int max = mas[0];
            int indexmax = 0;

            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 10 == 0)
                {
                    if (mas[i] > max) { 
                        
                        max = mas[i];
                        indexmax = i;
                    }
                }
            }

            if(max != 0) Console.WriteLine($"Максимальное число кратное 10: {max}");
            else Console.WriteLine("1000");

            //Кратность 7

            int min = 0;
            int indexmin = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 7 == 0)
                {
                    min = mas[i];
                }
                
            }

            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 7 == 0)
                {
                    if (min > mas[i]) { min = mas[i]; indexmin = i; }
                }
            }

            
            if (min != 0) Console.WriteLine($"Минимальное число кратное 7: {min}");
            else Console.WriteLine("-1000");
          
            
            Console.WriteLine();

            //Вывод всех элементов между %10 and %7
            Console.Write("Вывод всех элементов между %10 and %7: ");
            if (indexmin < indexmax)
            {
                for (int i = indexmin + 1; i < indexmax; i++)
                {
                    Console.Write(mas[i] + " ");
                }
            }

            if (indexmax < indexmin)
            {
                for (int i = indexmax + 1; i < indexmin; i++)
                {
                    Console.Write(mas[i] + " ");
                }
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
            

        }
    }
}