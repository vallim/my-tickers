using Microsoft.Extensions.DependencyInjection;
using my_tickers.Repositories;
using my_tickers.Repositories.Contracts;

namespace my_tickers.Config
{
    public static class RepositoriesConfiguration
    {
        public static void MapRepositories(this IServiceCollection services)
        {
            services.AddSingleton<ITickersRepository, TickersRepository>();
        }
    }
}