using MVC_Vegetable_market.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Vegetable_market.Views
{
    internal class Display
    {
        public double PricePerKilogramVegetables
        {
            get;
            private set;
        }
        public double PricePerKilogramFruits
        {
            get;
            private set;
        }
        public int TotalKilogramsVegetables
        {
            get;
            private set;
        }
        public int TotalKilogramsFruits
        {
            get;
            private set;
        }
        public double TotalBillLeva
        {
            get;
            set;
        }
        public double TotalBillEuro
        {
            get;
            set;
        }

        public void Input()//метод за вход
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter price per kilogram Vegetables: ");
            this.PricePerKilogramVegetables = double.Parse(Console.ReadLine());
            Console.Write("Enter price per kilogram Fruits: ");
            this.PricePerKilogramFruits = double.Parse(Console.ReadLine());
            Console.Write("Input total kilograms Vegetables: ");
            this.TotalKilogramsVegetables = int.Parse(Console.ReadLine());
            Console.Write("Input total kilograms Fruits: ");
            this.TotalKilogramsFruits = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public void Output(double totalBillEuro, Market market, double totalBillLeva) //метод за изход
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Price per kilogram Vegetables: {market.PricePerKilogramVegetables}");
            Console.WriteLine($"Price per kilogram Fruits: {market.PricePerKilogramFruits}");
            Console.WriteLine($"Total kilograms Vegetables: {market.TotalKilogramsVegetables}");
            Console.WriteLine($"Total kilograms Fruits: {market.TotalKilogramsFruits}");
            Console.WriteLine($"Total bill: {totalBillLeva:f2} lv");
            Console.WriteLine($"Total bill: {totalBillEuro:f2} euro");
        }
    }
}
