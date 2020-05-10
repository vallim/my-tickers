using System;
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
        
        public void Save(Ticker ticker)
        {
            throw new NotImplementedException();
        }

        public List<Ticker> GetAll()
        {
            return _database.Query<Ticker>("SELECT * FROM tickers").ToList();
        }
    }
}