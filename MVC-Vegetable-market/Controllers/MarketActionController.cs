using MVC_Vegetable_market.Models;
using MVC_Vegetable_market.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Vegetable_market.Controllers
{
    internal class MarketActionController
    {

        public Market market;
        public Display display;

        public MarketActionController()
        {
            market = new Market();
            display = new Display();
        }

        public void Initialize()
        {
            display.Input();
            market.PricePerKilogramVegetables = display.PricePerKilogramVegetables;
            market.PricePerKilogramFruits = display.PricePerKilogramFruits;
            market.TotalKilogramsVegetables = display.TotalKilogramsVegetables;
            market.TotalKilogramsFruits = display.TotalKilogramsFruits;
            display.TotalBillEuro = market.GetTotalBillEuro();
            display.TotalBillLeva = market.GetTotalBillLeva();
            display.Output(display.TotalBillEuro, market, display.TotalBillLeva);

        }
    }
}
