using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    public enum HttpVerb
    {
        [Description("DELETE")]
        Delete = 0,
        [Description("GET")]
        Get = 1,
        [Description("POST")]
        Post = 2,
        [Description("PUT")]
        Put = 3,
      
        
    }
    
        public enum FiscalPeriod
        {
            [Description("ALL")]
            All = 0,
            [Description("FY")]
            FY = 1,
            [Description("Q1")]
            Q1 = 2,
            [Description("Q2")]
            Q2 = 3,
            [Description("Q3")]
            Q3 = 4,
            [Description("Q4")]
            Q4 = 5,
          
        }
        public enum FiscalYear
        {
            [Description("ALL")]
            All = 0,
            [Description("LATEST")]
            Latest = 1

        }
        public enum Format
        {
            [Description("json")]
            Json = 0,
            [Description("csv")]
            Csv = 1,
            [Description("xml")]
            Xml = 2,
            [Description("excel")]
            Excel = 3,
          

        }

        public enum Tag
        {
            [Description("Default")]
            Default = 0,
           
            [Description("DOW30")]
            Dow30 = 1,
            [Description("SP500")]
            SP500 = 2,
            [Description("FORTUNE100")]
            Fortune100 = 3,
            [Description("PJI")]
            PJI = 4,
        
          

        }
    
}
