using System.Collections.Generic;
using my_tickers.Domains;

namespace my_tickers.Services.Contracts
{
    public interface ITickersService
    {

        public List<Ticker> GetAll();
    }
}