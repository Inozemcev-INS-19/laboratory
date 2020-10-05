using System;
using System.Collections.Generic;
using System.Text;

namespace _7laba
{
    class Class1
    {
        private double d1, d2;
        //Конструктор
        public Class1() { }
        //Конструктор
        public Class1(double pd1, double pd2)
        {
            d1 = pd1;
            d2 = pd2;
        }
        //Конструктор
        public static Class1 Var2()
        {
            string pdp = "\nЭто ромб, который выводится с помощью конструктора";
            Console.WriteLine(pdp);
            double dd1 = Convert.ToDouble(Console.ReadLine());
            double dd2 = Convert.ToDouble(Console.ReadLine());
            return new Class1(dd1, dd2);
        }

        public void Load()
        {
            d1 = Convert.ToDouble(Console.ReadLine());
            d2 = Convert.ToDouble(Console.ReadLine());
        }

        public double GetS() { return d1 * d2 * 1 / 2; }

        public double GetP() { return Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2)) * 2; }

        //Метод
        public void Info()
        {
            string str =
                "          ****         \n" +
                "         **  **        \n" +
                "        **    **       \n" +
                "       **      **      \n" +
                "      **        **     \n" +
                "     **          **    \n" +
                "    **            **   \n" +
                "   **      Р       **  \n" +
                "  **       О        ** \n" +
                "  **       М        ** \n" +
                "   **      Б       **  \n" +
                "    **            **   \n" +
                "     **          **    \n" +
                "      **        **     \n" +
                "       **      **      \n" +
                "        **    **       \n" +
                "         **  **        \n" +
                "          ****         \n";
            Console.WriteLine(str);
            Console.WriteLine(string.Format("D1 = {0:0.00}, ", d1));
            Console.WriteLine(string.Format("D2 = {0:0.00}, ", d2));
            Console.WriteLine(string.Format("S = {0:0.00}", GetS()));
            Console.WriteLine(string.Format("P = {0:0.00}", GetP()));
        }
        //Метод
        public void Info(ConsoleColor fg, ConsoleColor bgs)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgs;
            Console.Clear();
            Info();
        }

        


    }
}
