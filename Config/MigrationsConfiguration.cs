using System;
using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using my_tickers.Migrations;

namespace my_tickers.Config
{
    public static class MigrationsConfiguration
    {
        public static void RunMigrations(this IServiceCollection services, IConfiguration configuration)
        {
            var serviceProvider = AddFluentMigrator(services, configuration);
            
            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }
        }
        
        private static IServiceProvider AddFluentMigrator(IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddPostgres()
                    .WithGlobalConnectionString(configuration.GetSection("DbConnectionString").Value)
                    .ScanIn(typeof(AddTickersTable).Assembly).For.Migrations())
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }
        
        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            
            runner.MigrateUp();
        }
    }
}