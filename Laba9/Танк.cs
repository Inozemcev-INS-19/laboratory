using System;
using System.Collections.Generic;
using System.Text;

namespace laba8
{

    class Танк : Вооружение, IConversion, IVisual
    {
        public Танк(string рСтрана, string рМодель, double рМасса, double рКалибр, double рСкорость, int рЭкипаж, ВидыТанков рТанк) : base(рСтрана, рМодель, рМасса, рКалибр)
        {
            this.Скорость = рСкорость;
            this.Экипаж = рЭкипаж;
            this.танк = рТанк;
        }

        public override string Proverka => "\nВид танка:" + танк;

        public override string output()
        {
            return "\nТанк \n" + $"Модель: {getMod()},\t\t Калибр: {getKalibr()}, Масса: {getMassa()}т,   Страна: {getCountry()} " 
                + $" Скорость: {convert()} м/c, Экипаж: {Экипаж} чел\n" + Max3d();
               
        }

        public enum ВидыТанков
        {
            Тяжелый,
            Средний,
            Легкий
        }

        public double convert()
        {

            Скорость /= 3.6;
            return Скорость;
        }


        public string Max3d()
        {
            return "Представим, что тут 3D рисунок xD";
        }

        private double Скорость;
        private int Экипаж;
        private ВидыТанков танк;

    }
}