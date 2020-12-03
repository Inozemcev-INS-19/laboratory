using System;
using System.Collections.Generic;
using System.Text;

namespace laba8
{
    class Самолет : Вооружение, IConversion, IVisual
    {
        public Самолет(string рСтрана, string рМодель, double рМасса, double рКалибр, int рЭкипаж, ВидыСамолетов рВид, double рСкорость) : base(рСтрана, рМодель, рМасса, рКалибр)
        {
            this.Скорость = рСкорость;
            this.Экипаж = рЭкипаж;
            Вид = рВид;
        }

        public override string Proverka => "\nВид самолета: " + Вид;

        public override string output()
        {
            return "\nСамолет \n" + $"Модель: {getMod()},\t\t Калибр: {getKalibr()}, Масса: {getMassa()}т,   " +
                $"Страна: {getCountry()} " + $"Скорость: {convert()} м/c, Экипаж:{Экипаж} чел.\n" + Max3d();
        }
       
        
        public enum ВидыСамолетов
        {
            Истребитель,
            Бомбардировщик,
            Разведчик,
            Военно_транспортный_самолет
        }

        public string Max3d()
        {
            return "Представим, что тут 3D рисунок xD";
        }

        public double convert()
        {
            Скорость = Скорость / 3.6;
            return Скорость;
        }

        private int Экипаж;
        private double Скорость;
        private ВидыСамолетов Вид;
        
    }
}
