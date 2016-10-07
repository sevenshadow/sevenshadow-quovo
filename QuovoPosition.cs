using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    public class QuovoPosition
    {
        public int userid { get; set; }
        public string username { get; set; }
        public int Portfolio { get; set; }
        public string PortfolioName { get; set; }
        public string Ticker { get; set; }
        public string tickername { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Value { get; set; }
        public string Cur { get; set; }
        public string AssetClass { get; set; }
        public string Sector { get; set; }
    }
}
