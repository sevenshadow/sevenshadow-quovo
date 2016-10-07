using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    public class QuovoResponse : IResponse 
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public string CleanApiResponse { get {
            string returnString = RawApiResponse.Replace("\n", "");
            return returnString;
        } }
        public bool success { get; set; }
        public QuovoException ApiException { get; set; }
    }
}
