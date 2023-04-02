using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<Action<string, string>, bool> func = GetTrue; 
            Action<string, string> action = Draw; //инициализация делегата
            func.Invoke(action); //вызов делегата
            func = GetFalse; // инициализация делегата
            func.Invoke(action); //вызов делегата

        }

        static void Draw(string x, string y) 
        {
            Console.WriteLine($"{x} and {y}");

        }
        static bool GetTrue(Action<string, string> draw) 
        {
            draw.Invoke("word", "word2");
            return true;
        }
        static bool GetFalse(Action<string, string> draw)
        {
            draw.Invoke("elemination", "word4");
            return false;
        }


    }
}
