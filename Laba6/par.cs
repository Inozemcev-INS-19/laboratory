using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_6
{
    class par
    {
        public double r;

        public double GetV() { return Math.PI * Math.Pow(r, 3) * 4/3; }

        public double GetS() { return 4 * Math.PI * Math.Pow(r, 2); }

        public void Info()
        {
            string str =
                "      ***********      \n" +
                "    **            **   \n" +
                "   **      Ш       **  \n" +
                "  **       А        ** \n" +
                "  **       Р        ** \n" +
                "   **              **  \n" +
                "    **            **   \n" +
                "      ***********      \n";

            Console.WriteLine(str);
            Console.WriteLine(string.Format("R = {0:0.00}, ", r));
            Console.WriteLine(string.Format("V = {0:0.00}", GetV()));
            Console.WriteLine(string.Format("S = {0:0.00}", GetS()));
        }

        public void Load()
        {
            r = Convert.ToDouble(Console.ReadLine());
        }
    }
}
