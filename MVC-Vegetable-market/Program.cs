using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Vegetable_market.Controllers;
using MVC_Vegetable_market.Models;
using MVC_Vegetable_market.Views;

namespace Vegetable_market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MarketActionController controller = new MarketActionController();
            controller.Initialize();
        }
    }
}
