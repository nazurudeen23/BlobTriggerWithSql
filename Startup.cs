using BlobWithSql.Models;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(BlobWithSql.Startup))]

namespace BlobWithSql
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string connectionString = "Data Source= CI-NAZUR;Integrated Security=true;Database=FileRecords"; // 
            builder.Services.AddDbContext<AppDbContext>(
                options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionString));
        }
    }
}
