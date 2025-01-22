using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ProductsDemo.WebAPI.Data
{
    public static class PrepDbPipeline
    {
        public static void PrepPopulation(this IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DemoDbContext>();
                EnsureDatabaseCreated(context);
                SeedDataFromSQLFile(context);
            }
        }

        private static void EnsureDatabaseCreated(DemoDbContext context)
        {

            var databaseName = context.Database.GetDbConnection().Database;
            var masterConnectionString = context.Database.GetDbConnection().ConnectionString.Replace($"Database={databaseName}", "Database=master");

            using (var masterConnection = new SqlConnection(masterConnectionString))
            {
                masterConnection.Open();
                var commandText = $"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'{databaseName}') CREATE DATABASE [{databaseName}]";
                using (var command = new SqlCommand(commandText, masterConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private static void SeedDataFromSQLFile(DemoDbContext context)
        {
            // Check if the Products table exists
            var tableExists = context.Database.ExecuteSqlRaw(
                "SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Products'") > 0;
            
            if (!tableExists)
            {
                var sql = File.ReadAllText("Demo_Products.sql");
                context.Database.ExecuteSqlRaw(sql);
            }
        }
    }
}

