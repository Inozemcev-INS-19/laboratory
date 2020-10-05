using System;
using System.IO;
namespace _7laba
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"Class1_output.txt");
            var new_in = new StreamReader(@"Class1_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Class1 p1, p2;
#if DEBUG
            p2= new Class1(10, 12);
            p2.Info(ConsoleColor.Red, ConsoleColor.DarkBlue);
#endif

#if !DEBUG

            p1 = new Class1(4.5, 10.2);
            p1.Info(ConsoleColor.Red, ConsoleColor.DarkBlue);
            p2 = Class1.Var2();
            p2.Info();
            

#endif


#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
