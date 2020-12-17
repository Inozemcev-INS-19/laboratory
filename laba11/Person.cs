using System;
using System.Collections.Generic;
using System.Text;

namespace laba_11
{
    enum CategoryType
    {
        A, B, C, D
    }

    class Person
    {
        public String ID { get; set; }
        public String Name { get; set; }
        public String Company { get; set; }
        public Double Price { get; set; }
        public int Count { get; set; }
        public CategoryType Category { get; set; }
        public int Discount { get; set; }


        public static Person Create(String str)
        {
            Person p = new Person();
            string[] e = str.Split(',');
            p.ID = e[0].Trim();
            p.Name = e[1].Trim();

            p.Company = e[2].Trim();
            p.Price = Convert.ToDouble(e[3].TrimStart('$').Replace('.', ','));
            p.Count = Convert.ToInt32(e[4].Trim());

            String categ = e[5].Trim();
            if (categ == "A") p.Category = CategoryType.A;
            else if (categ == "B") p.Category = CategoryType.B;
            else if (categ == "C") p.Category = CategoryType.C;
            else p.Category = CategoryType.D;

            p.Discount = Convert.ToInt32(e[6].Trim());


            return p;
        }

        public override string ToString()
        {
            String s = string.Format("\n" +
                "ID: {0}, Name: {1},\n" +
                "Company: {2}, Price: {3}, Count: {4},\n" +
                "Category: {5}, Discount: {6}", ID, Name, Company, Price, Count, Category, Discount);
            return s;
        }
    }
}
