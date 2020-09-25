using System;


namespace _1_laba
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 1: Разработка консольного приложения.");
            Console.WriteLine("");
            Console.WriteLine("Выполнил:              Иноземецв Алекснадр Юрьевич.");
            Console.WriteLine("Группа:                Инс-б-о-19-2(1).");
            Console.WriteLine("Дата рождения:         15.01.2000.");
            Console.WriteLine("Населенный пункт:      Город Ставрополь.");
            Console.WriteLine("Любимый предмет:       Математика.");
            Console.WriteLine("Хобби:                 Програмирование на С++, баскетбол, волейбол.\n");

            task1();
        }

        static void task1()
        {
            int a; int b; int t; int x; int f; int i_2; double R_x;
            Console.Write("Введите значения a:");   a = Convert.ToInt32(Console.ReadLine());
                
            Console.Write("Введите значения b:");    b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите значения t:");    t = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значения x:");    x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значения f:");    f = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значения i_2:");  i_2 = Convert.ToInt32(Console.ReadLine());


            R_x = a * b + b / t - x + f * i_2;
            Console.WriteLine(R_x);
        }

    }
}
