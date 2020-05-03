using System.Collections.Generic;
using my_tickers.Domains;
using my_tickers.Services.Contracts;

namespace my_tickers.Services
{
    public class TickersService : ITickersService
    {
        public List<Ticker> GetAll()
        {
            return new List<Ticker>();
        }
    }
}