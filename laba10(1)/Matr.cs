using System;
using System.IO;


namespace laba10
{
    class Matr
    {

        public static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0} ", a[i, j]);
        }


        public static int[,] SummaElementov(int[,] mas1, int[,] mas2)
        {
            int[,] resMatrix = new int[mas1.Length, mas2.Length];

            for (int i = 0; i < mas2.GetLength(0); i++)
                for (int j = 0; j < mas2.GetLength(1); j++)
                {
                    resMatrix[i, j] = mas1[i, j] + mas2[i, j];
                    Console.WriteLine($"[{i}] [{j}] == " + resMatrix[i, j] + " ");
                }
            Console.WriteLine();
            return resMatrix;
        }

        public static int[,] RaznElementov(int[,] mas1, int[,] mas2)
        {
            int[,] resMatrix = new int[mas1.Length, mas2.Length];

            for (int i = 0; i < mas2.GetLength(1); i++)
                for (int j = 0; j < mas2.GetLength(1); j++)
                {
                    resMatrix[i, j] = mas1[i, j] - mas2[i, j];
                    Console.WriteLine($"[{i}] [{j}] == " + resMatrix[i, j] + " ");
                }
            Console.WriteLine();
            return resMatrix;

        }
        static float sum = 0;
        public static float SummaElement(int[,] mas1) {

            for (int i = 0; i < mas1.GetLength(0); i++)
            {
                for (int j = 0; j < mas1.GetLength(1); j++)
                    sum += mas1[i, j];
            }
            
            return sum;
        }

    }
}
