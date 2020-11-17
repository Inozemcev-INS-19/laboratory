using System;
using System.IO;
namespace laba10
{
    class Input
    {
        public static int[,] Input1()
        {
            StreamReader f = new StreamReader("Matrix1.txt");
            string s = f.ReadToEnd();
            f.Close();
            string[] line1 = s.Split('\n');
            string[] column1 = line1[0].Split(' ');
            int[,] a1 = new int[line1.Length, column1.Length];
            int t;

            for (int i = 0; i < line1.Length; i++)
            {
                column1 = line1[i].Split(' ');
                for (int j = 0; j < column1.Length; j++)
                {
                    t = Convert.ToInt32(column1[j]);
                    a1[i, j] = t;

                }
            }
            return a1;
        }

        public static int[,] Input2()
        {
            StreamReader file2 = new StreamReader("Matrix2.txt");
            string s2 = file2.ReadToEnd();
            file2.Close();
            string[] line2 = s2.Split('\n');
            string[] column2 = line2[0].Split(' ');
            int[,] a2 = new int[line2.Length, column2.Length];
            int t2;

            for (int i = 0; i < line2.Length; i++)
            {
                column2 = line2[i].Split(' ');
                for (int j = 0; j < column2.Length; j++)
                {
                    t2 = Convert.ToInt32(column2[j]);
                    a2[i, j] = t2;

                }
            }
            return a2;
        }


    }
}
