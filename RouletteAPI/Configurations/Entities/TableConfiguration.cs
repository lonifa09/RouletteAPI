using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RouletteAPI.Data;

namespace RouletteAPI.Configurations.Entities
{
    public class TableConfiguration : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {

            builder.HasData(
                new Table
                {
                    TableId = 1,
                    Number = 1,
                    Color = "Red",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 2,
                    Number = 2,
                    Color = "Black",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 3,
                    Number = 3,
                    Color = "Red",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 4,
                    Number = 4,
                    Color = "Black",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 5,
                    Number = 5,
                    Color = "Red",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 6,
                    Number = 6,
                    Color = "Black",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 7,
                    Number = 7,
                    Color = "Red",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 8,
                    Number = 8,
                    Color = "Black",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 9,
                    Number = 9,
                    Color = "Red",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 10,
                    Number = 10,
                    Color = "Black",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 11,
                    Number = 11,
                    Color = "Black",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 12,
                    Number = 12,
                    Color = "Red",
                    Range = "1st 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 13,
                    Number = 13,
                    Color = "Black",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 14,
                    Number = 14,
                    Color = "Red",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 15,
                    Number = 15,
                    Color = "Black",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 16,
                    Number = 16,
                    Color = "Red",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 17,
                    Number = 17,
                    Color = "Black",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 18,
                    Number = 18,
                    Color = "Red",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 19,
                    Number = 19,
                    Color = "Black",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 20,
                    Number = 20,
                    Color = "Black",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 21,
                    Number = 21,
                    Color = "Red",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 22,
                    Number = 22,
                    Color = "Black",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 23,
                    Number = 23,
                    Color = "Red",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 24,
                    Number = 24,
                    Color = "Black",
                    Range = "2nd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 25,
                    Number = 25,
                    Color = "Red",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 26,
                    Number = 26,
                    Color = "Black",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 27,
                    Number = 27,
                    Color = "Red",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 28,
                    Number = 28,
                    Color = "Red",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 29,
                    Number = 29,
                    Color = "Black",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 30,
                    Number = 30,
                    Color = "Red",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 31,
                    Number = 31,
                    Color = "Black",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 32,
                    Number = 32,
                    Color = "Red",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 33,
                    Number = 33,
                    Color = "Black",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 34,
                    Number = 34,
                    Color = "Red",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 35,
                    Number = 35,
                    Color = "Black",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 36,
                    Number = 36,
                    Color = "Red",
                    Range = "3rd 12",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 37,
                    Number = 0,
                    Color = "Green",
                    Range = "",
                    Polarity = ""
                },
                new Table
                {
                    TableId = 38,
                    Number = 00,
                    Color = "Green",
                    Range = "",
                    Polarity = ""
                }
                );
        }
    }
}
