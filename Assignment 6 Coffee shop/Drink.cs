using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Coffee_shop
{
    class Drink
    {
        private string name; //tea   coffee   juice
        private int price;   //45      50       30

        public Drink(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPrice()
        {
            return price;
        }
    }
}
