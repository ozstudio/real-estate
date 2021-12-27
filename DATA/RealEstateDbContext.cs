using System;
using Microsoft.EntityFrameworkCore;
using realEstate.Models;


namespace realEstate.DATA
{
    public class RealEstateDbContext : DbContext
    {
        public RealEstateDbContext()
        {

        }

        public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options): base (options)
        {

        }
        
        public DbSet<SellingAgent> Agents { get; set; }
        public DbSet<RealEstateModel> realEstateModels { get; set; }
        

    }
}
