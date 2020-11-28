using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10
{
    class Matr
    {
        private float[,] mas;
        int n, m;
        //Генерация
        public void Generator(int N, int M)
        {
            m = M;
            n = N;
            
            Random ran = new Random(DateTime.Now.Millisecond);

            mas = new float[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                    mas[i, j] = (float)ran.Next(-1000, 1000);
            }
        }
        //Сохранение
        public void Save(string pFileName) {
            if (mas.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);

                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();

                tw.WriteLine(m.ToString());
                tw.WriteLine(n.ToString());

                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < m; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + mas[i, j]);
                    
                }
                tw.Close();
            }
        }

        public Boolean LoadMatrix(string pFileName) {
            if (File.Exists(pFileName))
            {
                try
                {
                    TextReader tr = File.OpenText(pFileName);
                    n = Convert.ToInt32(tr.ReadLine());
                    m = Convert.ToInt32(tr.ReadLine());

                    mas = new float[n, m];

                    string line;
                    string[] substring;

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            line = tr.ReadLine();
                            substring = line.Split(new char[] { ' ' }, 3);
                            mas[i, j] = Convert.ToSingle(substring[2]);

                        }
                    }
                    tr.Close();
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }                       
            }
            return false;     
        }

        public void PrintMatrix() {
            if (mas.Length > 0) {
                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < m; j++)
                        Console.Write(mas[i, j]+ " ");

                    Console.WriteLine();
                }       
            }
        }

        float sum = 0;
        public float SummaElementov() { 
            if(mas.Length > 0)
            {
                for (int i = 0; i < n; i++) {
                    for (int j = 0; j < m; j++) 
                        sum += mas[i, j];
                }
                
            }
            
            return sum;
        }

        float razn = 0;
        public float RaznElementov()
        {
            if (mas.Length > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        sum += mas[i, j];
                }

            }

            return sum;
        }


    }
}
