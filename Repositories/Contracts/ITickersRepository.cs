using System.Collections.Generic;
using my_tickers.Domains;

namespace my_tickers.Repositories.Contracts
{
    public interface ITickersRepository
    {
        public void Save(Ticker ticker);
        
        public List<Ticker> GetAll();
    }
}