using Microsoft.EntityFrameworkCore;
namespace ApplicationAssigment.Context{
public class ApplicationDBContext : DbContext{
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=app.db");
        }

        public DbSet<Airline> Airlines_tb  { get; set;}
        public DbSet<Baggage> Baggages_tb  { get; set; }
         public DbSet<Flight> Flights_tb  { get; set; }
          public DbSet<Gate> Gates_tb { get; set; }
           public DbSet<Officer> Officer_tb  { get; set; }
            public DbSet<Passenger> Passengers_tb  { get; set; }
             public DbSet<SecurityCheckpount> SecurityCheckpounts_tb  { get; set; }
              public DbSet<Terminal> Terminals_tb  { get; set; }


    }
}
