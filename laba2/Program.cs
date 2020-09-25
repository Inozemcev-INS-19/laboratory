using System;
using System.IO;

namespace Laba2
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
            
            double a, c, d, b, e;

             a = Convert.ToInt32(Console.ReadLine());

            c = Convert.ToInt32(Console.ReadLine());

            d = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadLine());

            e = Convert.ToInt32(Console.ReadLine());
            

            double s, k;

            if ((a > 0 && c > 0 && d > 0 && e > 0 && b > 0))
            {

                s = (Math.Sqrt(Math.Pow(c, 2) - a)) / (Math.Sqrt(Math.Pow(a, 2) - c));

                k = Math.Sqrt(Math.Pow(d, 2) - Math.Sqrt(Math.Pow(b, 2) - Math.Sqrt(e - c)));

                if(s >= 0) Console.WriteLine(Math.Round(s, 2));
                else Console.WriteLine("ERROR");

                if(k >= 0) Console.WriteLine(Math.Round(k, 2));
                else Console.WriteLine("ERROR");

            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
