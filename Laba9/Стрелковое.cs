using System;
using System.Collections.Generic;
using System.Text;

namespace laba8
{
    class Стрелковое : Вооружение, IConversion
    {
        public Стрелковое(string рСтрана, string рМодель, double рМасса, double рКалибр, int pQuant, double pSpid, ВидыСтрелкОруж pGuns) : base(рСтрана, рМодель, рМасса, рКалибр)
        {

            this.quantity = pQuant;
            this.spid = pSpid;
            this.guns = pGuns;
        }

        public override string Proverka => "\nВид стрелкового оружия: " + guns;

        public override string output()
        {
            return "\nСтрелковое оружие \n" + $"Модель: {getMod()},\t Калибр: {getKalibr()}, " +
                $"Масса: {getMassa()}т,   Страна: {getCountry()} " + $" Кол-во патрон в магазине: {quantity}" + $"\nСкорость пули в м/c: {convert()}";
        }

        public enum ВидыСтрелкОруж
        {
            Тяжелое,
            Среднее,
            Легкое
        }

        public double convert()
        {
            spid *= 3.6;
            return spid;
        }

        private ВидыСтрелкОруж guns;
        private int quantity;
        private double spid;
    }
}