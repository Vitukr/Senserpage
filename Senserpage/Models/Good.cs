using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senserpage.Models
{
    public class Good
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Attributes { get; set; }
        public List<string> ImageLinks { get; set; }
        public List<string> ImageLinksSmall { get; set; }
        public bool IsOpened { get; set; }
    }
}
