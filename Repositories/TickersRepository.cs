using System.Collections.Generic;
using my_tickers.Domains;
using my_tickers.Repositories.Contracts;

namespace my_tickers.Repositories
{
    public class TickersRepository : ITickersRepository
    {
        public void Save(Ticker ticker)
        {
            throw new System.NotImplementedException();
        }

        public List<Ticker> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}