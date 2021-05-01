using Senserpage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senserpage.Data
{
    interface IGoods
    {
        List<Good> GetGoods();
    }

    interface ICartGood
    {
        string Name { get; set; }
        string PhotoLink { get; set; }
        int Number { get; set; }
        decimal Price { get; set; }
        decimal PriceAction { get; set; }
        decimal TotalPrice { get; set; }
    }
}
