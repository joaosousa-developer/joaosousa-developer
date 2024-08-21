//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.IO;

//namespace AppBloodWeb.Infrastructure.Context
//{
//    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
//    {
//        public AppDbContext CreateDbContext(string[] args)
//        {
//            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "AppBloodWeb.API");
//            var configuration = new ConfigurationBuilder()
//                .SetBasePath(basePath)
//                .AddJsonFile("appsettings.json")
//                .Build();

//            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
//            var connectionString = configuration.GetConnectionString("DefaultConnection");

//            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 2, 0)));

//            return new AppDbContext(optionsBuilder.Options);
//        }
//    }
//}
