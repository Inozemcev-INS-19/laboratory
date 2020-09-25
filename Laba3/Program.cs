using System;
using System.IO;
namespace Laba3
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


            int N, t;
            double x, y, z = 0;

            int i, step ;
            double znam, chisl;

            N = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            int l;

            if (t == 0)
            {
                for (i = 1; i <= N; i++)
                {
                    l = 2 * i;
                    step = i;
                    znam = (l - 1) * (l + 1);

                    if (i % 2 == 0) chisl = -Math.Pow(y, l) * Math.Log(x);
                    else chisl = Math.Pow(x, l) * Math.Log(y);

                    z += chisl / znam;
                    i++;
                }
            }
            else if (t == 1)
            {
                i = 1;
                while (i <= N)
                {
                    l = 2 * i;
                    step = i;
                    znam = (l - 1) * (l + 1);

                    if (i % 2 == 0) chisl = -Math.Pow(y, l) * Math.Log(x);
                    else chisl = Math.Pow(x, l) * Math.Log(y);

                    z += chisl / znam;
                    i++;
                }
            }
            else if (t == 2) {
                i = 1;
                do
                {
                    l = 2 * i;
                    step = i;
                    znam = (l - 1) * (l + 1);

                    if (i % 2 == 0) chisl = -Math.Pow(y, l) * Math.Log(x);
                    else chisl = Math.Pow(x, l) * Math.Log(y);

                    z += chisl / znam;
                    i++;
                } while (i <= N);
                      
            }
            Console.WriteLine(z);

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
