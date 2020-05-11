using System.Collections.Generic;
using my_tickers.Domains;
using my_tickers.Repositories.Contracts;
using my_tickers.Services.Contracts;

namespace my_tickers.Services
{
    public class TickersService : ITickersService
    {
        private readonly ITickersRepository _tickersRepository;

        public TickersService(ITickersRepository tickersRepository)
        {
            _tickersRepository = tickersRepository;
        }

        public List<Ticker> GetAll()
        {
            return _tickersRepository.GetAll();
        }
    }
}