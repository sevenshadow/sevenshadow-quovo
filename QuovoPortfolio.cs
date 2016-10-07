using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    public class QuovoPortfolio
    {
        public int userid { get; set; }
        public string username { get; set; }
        public int Brokerage { get; set; }
        public string brokeragename { get; set; }
        public int Account { get; set; }
        public int Portfolio { get; set; }
        public string portfolioname { get; set; }
        public DateTime LastChange { get; set; }
        public decimal? Value { get; set; }
    }
}
