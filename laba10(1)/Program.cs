using System;



namespace laba10
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                int[,] myArray1 = Input.Input1();
                Console.WriteLine("Исходный массив 1 >>");
                Matr.Print(myArray1);

                Console.WriteLine();

                int[,] myArray2 = Input.Input2();
                Console.WriteLine("Исходный массив 2 >>");
                Matr.Print(myArray2);

                Console.WriteLine();

                Console.WriteLine("Разность сумм двух матриц >> ");
                Console.WriteLine($"{Matr.SummaElement(myArray1)} - {Matr.SummaElement(myArray2)} = " + (Matr.SummaElement(myArray1) - Matr.SummaElement(myArray2)));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

