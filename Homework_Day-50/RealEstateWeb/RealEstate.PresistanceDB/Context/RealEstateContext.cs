using Microsoft.EntityFrameworkCore;
using RealEstateW.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateW.PresistanceDB.Context
{
    public class RealEstateContext:DbContext
    {

        public RealEstateContext(DbContextOptions<RealEstateContext> options) : base(options)
        {

        }


        public DbSet<RealEstate> Properties { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RealEstateContext).Assembly);
        }

    }

}
