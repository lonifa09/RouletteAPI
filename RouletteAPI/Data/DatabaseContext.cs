using Microsoft.EntityFrameworkCore;

namespace RouletteAPI.Data
{
    public class DatabaseContext : DbContext
    {
        //constructor
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Table> Tables { get; set; }
        public DbSet<TableSection> TableSections { get; set; }
        public DbSet<Wheel> Wheel { get; set; }
        public DbSet<Spin> Spins { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<PayOut> PayOuts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Table>().HasData(
                new Table
                { 
                    TableId= 1,
                    Number= 1,
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



            builder.Entity<TableSection>().HasData(
                new TableSection { TableSectionId = 1, Description = "1-18" },
                new TableSection { TableSectionId = 2, Description = "Even" },
                new TableSection { TableSectionId = 3, Description = "Red" },
                new TableSection { TableSectionId = 4, Description = "Black" },
                new TableSection { TableSectionId = 5, Description = "Odd" },
                new TableSection { TableSectionId = 6, Description = "19-36" }
                );


            builder.Entity<Wheel>().HasData(
                new Wheel { WheelId = 1, Number = 1, Color = "Black"  },
                new Wheel { WheelId = 2, Number = 2, Color = "Red" },
                new Wheel { WheelId = 3,  Number = 3, Color = "Black" },
                new Wheel { WheelId = 4, Number = 4,Color = "Red" },
                new Wheel { WheelId = 5,Number = 5, Color = "Black" },
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
                new Wheel { WheelId = 37, Number = 0,Color = "Green" },
                new Wheel { WheelId = 38, Number = 00, Color = "Green" }
                );
        }

    }
}