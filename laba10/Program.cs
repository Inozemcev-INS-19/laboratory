using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    class Program
    {

        static void Main(string[] args)
        {
            Matr x = new Matr();
            x.Generator(2, 2);
            x.Save("Matrix1.txt");

            Matr y = new Matr();
            y.Generator(2, 2);
            y.Save("Matrix2.txt");

            Console.WriteLine("Матрица 1");
            if (x.LoadMatrix("Matrix1.txt"))
                x.PrintMatrix();

            Console.WriteLine();
            Console.WriteLine("Матрица 2");
            if (y.LoadMatrix("Matrix2.txt"))
                y.PrintMatrix();

            Console.WriteLine();
            Console.WriteLine("Сумма");
            if (x.LoadMatrix("Matrix1.txt") && y.LoadMatrix("Matrix2.txt")) {
                Console.WriteLine(x.SummaElementov() - y.SummaElementov());
            }
        }
    }
}

