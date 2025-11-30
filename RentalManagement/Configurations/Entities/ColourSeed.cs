using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentalManagement.Domain;

namespace RentalManagement.Configurations.Entities
{
    public class ColourSeed : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    Id = 1,
                    Name = "Black",
                    CreatedDate = new DateTime(2025, 11, 30, 17, 19, 50, DateTimeKind.Utc),
                    UpdatedDate = new DateTime(2025, 11, 30, 17, 19, 50, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Colour
                {
                    Id = 2,
                    Name = "Blue",
                    CreatedDate = new DateTime(2025, 11, 30, 17, 19, 50, DateTimeKind.Utc),
                    UpdatedDate = new DateTime(2025, 11, 30, 17, 19, 50, DateTimeKind.Utc),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
                );
        }
    }
}
