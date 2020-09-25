using System;
using System.IO;

namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);


            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] mas = new int [N, M];
            Console.WriteLine(" Elementary matrix ");

            for (int i = 0; i < N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');

                for (int j = 0; j < M; j++) 
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");              
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            Console.WriteLine(" Sum of line elements ");

            int sum = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {

                    sum += mas[i, j];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.WriteLine();


            Console.WriteLine(" Last matrix ");


            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {  
                    sum += mas[i, j];
                    
                    if (mas[i, j] > sum) Console.Write(" + ");
                    else if (mas[i, j] < sum) Console.Write(" - ");
                    else Console.Write(mas[i, j]);
                }

                sum = 0;
                Console.WriteLine();
            }

            
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
