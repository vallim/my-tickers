using FluentMigrator;

namespace my_tickers.Migrations
{
    [Migration(20200510161700)]
    public class AddTickersTable : Migration
    {
        public override void Up()
        {
            Create.Table("tickers")
                .WithColumn("code").AsString(10).PrimaryKey()
                .WithColumn("type").AsString(60)
                .WithColumn("trading_name").AsString(100);
        }

        public override void Down()
        {
            throw new System.NotImplementedException();
        }
    }
}