using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouletteAPI.Data;

namespace RouletteAPI.Configurations.Entities
{
    public class WheelConfiguration : IEntityTypeConfiguration<Wheel>
    {
        public void Configure(EntityTypeBuilder<Wheel> builder)
        {

            builder.HasData(
                new Wheel { WheelId = 1, Number = 1, Color = "Black" },
                new Wheel { WheelId = 2, Number = 2, Color = "Red" },
                new Wheel { WheelId = 3, Number = 3, Color = "Black" },
                new Wheel { WheelId = 4, Number = 4, Color = "Red" },
                new Wheel { WheelId = 5, Number = 5, Color = "Black" },
                new Wheel { WheelId = 6, Number = 6, Color = "Red" },
                new Wheel { WheelId = 7, Number = 7, Color = "Black" },
                new Wheel { WheelId = 8, Number = 8, Color = "Red" },
                new Wheel { WheelId = 9, Number = 9, Color = "Black" },
                new Wheel { WheelId = 10, Number = 10, Color = "Red" },
                new Wheel { WheelId = 11, Number = 11, Color = "Red" },
                new Wheel { WheelId = 12, Number = 12, Color = "Black" },
                new Wheel { WheelId = 13, Number = 13, Color = "Red" },
                new Wheel { WheelId = 14, Number = 14, Color = "Black" },
                new Wheel { WheelId = 15, Number = 15, Color = "Red" },
                new Wheel { WheelId = 16, Number = 16, Color = "Black" },
                new Wheel { WheelId = 17, Number = 17, Color = "Red" },
                new Wheel { WheelId = 18, Number = 18, Color = "Black" },
                new Wheel { WheelId = 19, Number = 19, Color = "Red" },
                new Wheel { WheelId = 20, Number = 20, Color = "Red" },
                new Wheel { WheelId = 21, Number = 21, Color = "Black" },
                new Wheel { WheelId = 22, Number = 22, Color = "Red" },
                new Wheel { WheelId = 23, Number = 23, Color = "Black" },
                new Wheel { WheelId = 24, Number = 24, Color = "Red" },
                new Wheel { WheelId = 25, Number = 25, Color = "Black" },
                new Wheel { WheelId = 26, Number = 26, Color = "Red" },
                new Wheel { WheelId = 27, Number = 27, Color = "Black" },
                new Wheel { WheelId = 28, Number = 28, Color = "Black" },
                new Wheel { WheelId = 29, Number = 29, Color = "Red" },
                new Wheel { WheelId = 30, Number = 30, Color = "Black" },
                new Wheel { WheelId = 31, Number = 31, Color = "Red" },
                new Wheel { WheelId = 32, Number = 32, Color = "Black" },
                new Wheel { WheelId = 33, Number = 33, Color = "Red" },
                new Wheel { WheelId = 34, Number = 34, Color = "Black" },
                new Wheel { WheelId = 35, Number = 35, Color = "Red" },
                new Wheel { WheelId = 36, Number = 36, Color = "Black" },
                new Wheel { WheelId = 37, Number = 0, Color = "Green" },
                new Wheel { WheelId = 38, Number = 00, Color = "Green" }
                );
        }
    }
}
