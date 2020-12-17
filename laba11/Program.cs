using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace laba_11
{
    class Program
    {

        static void Main()
        {
            StreamReader fileIn = new StreamReader(
                "lr11_31.csv");


#if !DEBUG
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"output.txt");
            Console.SetOut(new_out);
#endif

            List<Person> all = new List<Person>();

            try
            {
                String line = fileIn.ReadLine();
                while ((line = fileIn.ReadLine()) != null)
                {
                    all.Add(Person.Create(line));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Всего пользователей: {0}", all.Count);
            

            Console.WriteLine();
            Console.WriteLine("**** 1 Task ****");
            float aType = all.FindAll(p => p.Category == CategoryType.A).ToList().Count;
            float bType = all.FindAll(p => p.Category == CategoryType.B).ToList().Count;
            float cType = all.FindAll(p => p.Category == CategoryType.C).ToList().Count;

            Console.WriteLine("Товаров категории А: {0}", aType);
            Console.WriteLine("Товаров категории B: {0}", bType);
            Console.WriteLine("Товаров категории C: {0}", cType);
            Console.WriteLine("Товаров категории D: {0}", all.Count-(aType+bType+cType));

            Console.WriteLine();
            Console.WriteLine("**** 2 Task ****");

            double Volume = (from p in all
                             where (p.Company == "")
                             select p.Price).Sum();
            Console.WriteLine("Суммарный объем (в валюте) без поставщика: {0:0.000}", Volume);
            
            Console.WriteLine();
            Console.WriteLine("**** 3 Task ****");
            
            double  MaxCountA = (from p in all 
                                where(p.Category == CategoryType.A) 
                                select p.Price).Max();
            Console.WriteLine("Cамый дорогой товар категории A: {0}", MaxCountA);
            double MaxCountB = (from p in all
                                where (p.Category == CategoryType.B)
                                select p.Price).Max();
            Console.WriteLine("Cамый дорогой товар категории B: {0}", MaxCountB);
            double MaxCountC = (from p in all
                                where (p.Category == CategoryType.C)
                                select p.Price).Max();
            Console.WriteLine("Cамый дорогой товар категории C: {0}", MaxCountC);
            double MaxCountD = (from p in all
                                where (p.Category == CategoryType.D)
                                select p.Price).Max();
            Console.WriteLine("Cамый дорогой товар категории D: {0}", MaxCountD);



            Console.WriteLine();
            Console.WriteLine("**** 4 Task ****");
            int MaxDiscount = (from p in all select p.Discount).Max(); 
            Person MaxTovar = (from p in all where p.Discount == MaxDiscount select p).First();
            Console.WriteLine("Товар с максимальной скидкой: {0}", MaxTovar);

#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#else
            Console.ReadKey();
#endif

        }
    }
}
