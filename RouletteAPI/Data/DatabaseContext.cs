using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RouletteAPI.Configurations.Entities;

namespace RouletteAPI.Data
{
    public class DatabaseContext : IdentityDbContext<Player>
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
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new TableConfiguration());
            builder.ApplyConfiguration(new TableSectionConfiguration());
            builder.ApplyConfiguration(new WheelConfiguration());

        }

    }
}