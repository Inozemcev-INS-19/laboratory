using System;
using System.Collections.Generic;
using System.Text;

namespace laba8
{
    class Вооружение
    {
        public Вооружение(string рСтрана, string рМодель, double рМасса, double рКалибр) {
            this.Страна = рСтрана; this.Модель = рМодель; this.Масса = рМасса; this.Калибр = рКалибр;
        }

        private string Страна, Модель;
        private double Масса, Калибр;

        public string getCountry() {
            return Страна;
        }

        public string getMod()
        {
            return Модель;
        }
        public double getMassa()
        {
            return Масса;
        }
        public double getKalibr()
        {
            return Калибр;
        }
        //Свойство
        public virtual string Proverka => " " + Модель;
        //Метод
        public virtual string output() {
            return $"Модель: {getMod()},\t\t Калибр: {getKalibr()}, Масса: {getMassa()}кг,   Страна: {getCountry()}";
        }

    }



}
