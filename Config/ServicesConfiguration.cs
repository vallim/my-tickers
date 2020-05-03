using Microsoft.Extensions.DependencyInjection;
using my_tickers.Services;
using my_tickers.Services.Contracts;

namespace my_tickers.Config
{
    public static class ServicesConfiguration
    {
        public static void MapServices(this IServiceCollection services)
        {
            services.AddSingleton<ITickersService, TickersService>();
        }
    }
}