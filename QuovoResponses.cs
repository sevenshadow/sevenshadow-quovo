using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenShadow.Quovo
{
    public class BasicResponse : IResponse
    {
        public string RawApiRequest { get; set; }
        public string RawApiResponse { get; set; }
        public bool success { get; set; }
        public QuovoException ApiException { get; set; }
        
    }
    public class BrokerageResponse : BasicResponse
    {
          public List<Brokerage> Brokerages { get; set; }
    }

    public class ClientResponse : BasicResponse
    {
          public List<Client> Clients { get; set; }
    }

    public class ClientAccountResponse : BasicResponse
    {
        public List<ClientAccount> ClientAccounts { get; set; }
    }

    public class ClientPortfolioResponse : BasicResponse
    {
        public List<QuovoPortfolio> ClientPortfolios { get; set; }
    }

    public class ClientPositionsResponse : BasicResponse
    {
        public List<QuovoPosition> ClientPositions { get; set; }
    }
}
