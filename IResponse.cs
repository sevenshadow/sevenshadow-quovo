using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    public interface IResponse
    {
        string RawApiRequest { get; set; }
        string RawApiResponse { get; set; }
       // string CleanApiResponse { get; set; }
        bool success { get; set; }
        QuovoException ApiException { get; set; }
    }
}
