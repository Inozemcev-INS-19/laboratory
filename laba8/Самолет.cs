using System;
using System.Collections.Generic;
using System.Text;

namespace laba8
{
    class Самолет : Вооружение
    {
        public Самолет(string рСтрана, string рМодель, double рМасса, double рКалибр, int рЭкипаж, ВидыСамолетов рВид, double рСкорость) : base(рСтрана, рМодель, рМасса, рКалибр)
        {
            this.Скорость = рСкорость;
            this.Экипаж = рЭкипаж;
            Вид = рВид;
        }
        //Переопределение свойства
        public override string Proverka => "\nВид самолета: " + Вид;

        //Переопределение метода
        public override string output()
        {
            return "\nСамолет \n" + $"Модель: {getMod()},\t\t Калибр: {getKalibr()}, Масса: {getMassa()}т,   Страна: {getCountry()} " + $"Скорость: {Скорость} км/ч, Вид: {Вид}, Экипаж:{Экипаж} чел.";
        }
        

        //тип перечисления
        public enum ВидыСамолетов
        {
            Истребитель,
            Бомбардировщик,
            Разведчик,
            Военно_транспортный_самолет
        }

        private int Экипаж;
        private double Скорость;
        private ВидыСамолетов Вид;
    }
}
