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
}
