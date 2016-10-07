using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    interface IRequest
    {
        string SecXbrlHost { get; set; }
        string Token { get; set; }
        Format Format { get; set; }
        object Body { get; set; }
        Dictionary<string, string> HeaderParams { get; set; }
        HttpVerb HttpVerb { get; set; }
    }
}
