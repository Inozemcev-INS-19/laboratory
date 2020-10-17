using System;
using System.Collections.Generic;
using System.Text;

namespace laba8
{

    class Танк : Вооружение
    {
        public Танк(string рСтрана, string рМодель, double рМасса, double рКалибр, double рСкорость, int рЭкипаж, ВидыТанков рТанк) : base(рСтрана, рМодель, рМасса, рКалибр)
        {
            this.Скорость = рСкорость;
            this.Экипаж = рЭкипаж;
            this.танк = рТанк;
        }

        //Переопределение свойства
        public override string Proverka => "\nВид танка:" + танк;


        //переопределение метода
        public override string output()
        {
            return "\nТанк \n" + $"Модель: {getMod()},\t\t Калибр: {getKalibr()}, Масса: {getMassa()}т,   Страна: {getCountry()} " + $" Скорость: {Скорость} км/ч, Экипаж: {Экипаж} чел.";
        }
        private double Скорость;
        private int Экипаж;
        private ВидыТанков танк; 
        //тип перечисления
        public enum ВидыТанков
        {
            Тяжелый,
            Средний,
            Легкий
        }
    }
}
