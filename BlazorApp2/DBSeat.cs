using Microsoft.EntityFrameworkCore;

namespace BlazorApp2
{
    public partial class DBSeat:DbContext
    {
        public DBSeat(DbContextOptions<DBSeat> options): base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=TRANG\\SQLEXPRESS;Initial Catalog=TestSignIR;Integrated Security=True;TrustServerCertificate=true");
        }
        public virtual DbSet<Seat> Seats { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Seat>().HasData(
                new Seat { Id = Guid.Parse("e0e12a8a-10e6-4186-b5df-81c7c923ec0f"), Code = "A1", SeatColumn = 1, Price = 45, Row = "A1", Status = EntityStatus.Available },
                new Seat { Id = Guid.Parse("e0e12a8a-10e6-4186-b5df-81c7c923ec1f"), Code = "A2", SeatColumn = 2, Price = 45, Row = "A2", Status = EntityStatus.Available },
                new Seat { Id = Guid.Parse("e0e12a8a-10e6-4186-b5df-81c7c923ec2f"), Code = "B1", SeatColumn = 1, Price = 45, Row = "B2", Status = EntityStatus.Available },
                new Seat { Id = Guid.Parse("e0e12a8a-10e6-4186-b5df-81c7c923ec3f"), Code = "B2", SeatColumn = 2, Price = 45, Row = "B2", Status = EntityStatus.Available }
                );
        }
    }
}
