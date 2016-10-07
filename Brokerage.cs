using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    public class Brokerage
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool? HasLogo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Notes { get; set; }
    }
}
