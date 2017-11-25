using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Data.EF.Extensions;
using ShopApp.Data.Entities;

namespace ShopApp.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}