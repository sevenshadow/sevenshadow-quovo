using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    public class ClientAccount
    {
        public int userid { get; set; }
        public string username { get; set; }
        public int Account { get; set; }
        public string Nickname { get; set; }
        public int Brokerage { get; set; }
        public string brokeragename { get; set; }
        public DateTime Opened { get; set; }
        public DateTime Updated { get; set; }
        public int UpdateCount { get; set; }
        public int Failures { get; set; }
        public string Status { get; set; }
        public decimal? Value { get; set; }

    }
}
