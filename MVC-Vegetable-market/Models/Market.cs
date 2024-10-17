using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Vegetable_market.Models
{
    internal class Market
    {
        //полета
        private double pricePerKilogramVegetables;//цена на килограм зеленчуци
        private double pricePerKilogramFruits;//цена на килограм плодове
        private int totalKilogramVegetables;//общо колко килограма зеленчуци
        private int totalKilogramFruits;// общо колко килограма плодове
        //property-та
        public double PricePerKilogramVegetables
        {
            get
            {
                return pricePerKilogramVegetables;
            }
            set
            {
                pricePerKilogramVegetables = value;
            }
        }
        public double PricePerKilogramFruits
        {
            get
            {
                return pricePerKilogramFruits;
            }
            set
            {
                pricePerKilogramFruits = value;
            }
        }
        public int TotalKilogramsVegetables
        {
            get
            {
                return totalKilogramVegetables;
            }
            set
            {
                totalKilogramVegetables = value;
            }
        }
        public int TotalKilogramsFruits
        {
            get
            {
                return totalKilogramFruits;
            }
            set
            {
                totalKilogramFruits = value;
            }
        }
        public double GetTotalBillEuro()//метод за цялата сметка в евро
        {
            double billLeva = (this.TotalKilogramsFruits * this.PricePerKilogramFruits)
                  + (this.TotalKilogramsVegetables * this.PricePerKilogramVegetables);
            return billLeva / 1.94;
        }
        public double GetTotalBillLeva()//метод за цялата сметка в лева
        {
            double billLeva = (this.TotalKilogramsFruits * this.PricePerKilogramFruits)
                  + (this.TotalKilogramsVegetables * this.PricePerKilogramVegetables);
            return billLeva;
        }
    }
}
