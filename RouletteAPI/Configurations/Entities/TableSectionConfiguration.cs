using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouletteAPI.Data;

namespace RouletteAPI.Configurations.Entities
{
    public class TableSectionConfiguration : IEntityTypeConfiguration<TableSection>
    {
        public void Configure(EntityTypeBuilder<TableSection> builder)
        {
            builder.HasData(
                new TableSection { TableSectionId = 1, Description = "1-18" },
                new TableSection { TableSectionId = 2, Description = "Even" },
                new TableSection { TableSectionId = 3, Description = "Red" },
                new TableSection { TableSectionId = 4, Description = "Black" },
                new TableSection { TableSectionId = 5, Description = "Odd" },
                new TableSection { TableSectionId = 6, Description = "19-36" }
                );
        }
    }
}
