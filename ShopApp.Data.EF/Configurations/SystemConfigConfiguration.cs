﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Data.EF.Extensions;
using ShopApp.Data.Entities;

namespace ShopApp.Data.EF.Configurations
{
    internal class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}