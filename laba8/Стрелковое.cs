using System;
using System.Collections.Generic;
using System.Text;

namespace laba8
{
    class Стрелковое : Вооружение
    {
        public Стрелковое(string рСтрана, string рМодель, double рМасса, double рКалибр, int pQuant, ВидыСтрелкОруж pGuns) : base(рСтрана, рМодель, рМасса, рКалибр)
        {

            this.quantity = pQuant;
            this.guns = pGuns;
        }
        //Переопределение свойства
        public override string Proverka => "\nВид стрелкового оружия: " + guns;

        //переопределение метода
        public override string output()
        {
            return "\nСтрелковое оружие \n" + $"Модель: {getMod()},\t Калибр: {getKalibr()}, Масса: {getMassa()}т,   Страна: {getCountry()} " + $" Кол-во патрон в магазине: {quantity}";
        }

        //тип перечисления
        public enum ВидыСтрелкОруж
        {
            Тяжелое,
            Среднее,
            Легкое
        }



        private ВидыСтрелкОруж guns;
        private int quantity;
    }
}
