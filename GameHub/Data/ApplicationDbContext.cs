using GameHub.Models;

namespace GameHub.Data
{
    //this classe connect us to database 
    public class ApplicationDbContext : DbContext  
        {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<GameDevice> GameDevices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(new Category[]
                {
                    new Category { Id=1, Name="Sports" },
                    new Category { Id=2, Name="Action" },
                    new Category { Id=3, Name="Adventure" },
                    new Category { Id=4, Name="Role-Playing" },
                    new Category { Id=5, Name="Strategy" },
                    new Category { Id=6, Name="Simulation" },
                    new Category { Id=7, Name="Puzzle" },
                    new Category { Id=8, Name="Racing" },
                    new Category { Id=9, Name="Fighting" },
                    new Category { Id=10, Name="Horror" },
                    new Category { Id=11, Name="Multiplayer" },
                    new Category { Id=12, Name="Educational" },
                    new Category { Id=13, Name="Music" },
                    new Category { Id=14, Name="Board Games" },
                    new Category { Id=15, Name="Card Games" },
                    new Category { Id=16, Name="Casual" },
                    new Category { Id=17, Name="Science Fiction" },
                    new Category { Id=18, Name="Fantasy" },
                    new Category { Id=19, Name="Historical" },
                    new Category { Id=20, Name="Mystery" },

                });

            modelBuilder.Entity<Device>()
                .HasData(new Device[]
                {
                    new Device{Id=1,Name="PlayStation",Icon="bi bi-playstation"},
                    new Device { Id=2, Name="Xbox", Icon="bi bi-xbox" },
                    new Device { Id=3, Name="Nintendo Switch", Icon="bi bi-nintendot-switch" },
                    new Device { Id=4, Name="PC", Icon="bi bi-display" },
                });

            modelBuilder.Entity<GameDevice>()
                .HasKey(e => new { e.GameId, e.DeviceId });
            base.OnModelCreating(modelBuilder);
        }


    }

    
}
