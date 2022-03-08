using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateW.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateW.PresistanceDB.Configurations
{
    public class RealEstateConfiguration:IEntityTypeConfiguration<RealEstate>
    {
        public void Configure(EntityTypeBuilder<RealEstate> builder)
        {
            builder.HasIndex(x => x.CadastralCode).IsUnique();
            builder.Property(x => x.City).HasMaxLength(50);
            builder.Property(x => x.CadastralCode).IsRequired().HasMaxLength(12).IsFixedLength();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Area).IsRequired();
        }
    }
}
