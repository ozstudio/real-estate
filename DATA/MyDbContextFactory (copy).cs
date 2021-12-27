using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using realEstate.Models;

namespace realEstate.DATA
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<RealEstateDbContext>
    {

        RealEstateDbContext IDesignTimeDbContextFactory<RealEstateDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RealEstateDbContext>();
            var connectionString = configuration.GetConnectionString("connection");


            builder.UseMySql(connectionString);
        

            return new RealEstateDbContext(builder.Options);
        }
       
    }
}