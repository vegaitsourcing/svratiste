using Microsoft.EntityFrameworkCore;

namespace Svratiste.Model
{
    public class SafeHouseContext : DbContext
    {
        public SafeHouseContext() : base()
        {
        }

        public SafeHouseContext(DbContextOptions<SafeHouseContext> options) : base(options)
        {
        }

        public virtual DbSet<SafeHouseUser> SafeHouseUsers { get; set; }
        public virtual DbSet<Carton> Cartons { get; set; }
        public virtual DbSet<DailyEntry> DailyEntries { get; set; }
        public virtual DbSet<FirstEvaluation> FirstEvaluations { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SafeHouseUser>().ToTable("SafeHouseUser");
            modelBuilder.Entity<Carton>().ToTable("Carton");
            modelBuilder.Entity<DailyEntry>().ToTable("DailyEntry");
            modelBuilder.Entity<FirstEvaluation>().ToTable("FirstEvaluation");
            modelBuilder.Entity<Evaluation>().ToTable("Evaluation");
        }

    }
}
