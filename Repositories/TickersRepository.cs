using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using my_tickers.Domains;
using my_tickers.Repositories.Contracts;
using Npgsql;

namespace my_tickers.Repositories
{
    public class TickersRepository : ITickersRepository
    {
        private IDbConnection _database;
        
        public TickersRepository(IConfiguration configuration)
        {
            _database = new NpgsqlConnection(configuration.GetSection("DbConnectionString").Value);
        }
        
        public Ticker Save(Ticker ticker)
        {
            var affectedRows = _database.Execute("INSERT INTO tickers (code, type, trading_name) VALUES (@code, @type, @tradingName);", new { code = ticker.Code, type = ticker.Type, tradingName = ticker.TradingName });

            return affectedRows > 0 ? ticker : null;
        }

        public List<Ticker> GetAll()
        {
            return _database.Query<Ticker>("SELECT * FROM tickers").ToList();
        }
    }
}