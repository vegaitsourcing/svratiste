using Microsoft.EntityFrameworkCore;
using SafeHouse.Data.Entities;

namespace SafeHouse.Data
{
    public class SafeHouseContext : DbContext
    {
        public SafeHouseContext() : base() { }

        public SafeHouseContext(DbContextOptions<SafeHouseContext> options) : base(options) { }

        public virtual DbSet<SafeHouseUser> SafeHouseUsers { get; set; }
        public virtual DbSet<Carton> Cartons { get; set; }
        public virtual DbSet<DailyEntry> DailyEntries { get; set; }
        public virtual DbSet<FirstEvaluation> FirstEvaluations { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<ActivityDetails> ActivityDetails { get; set; }
        public virtual DbSet<GoalAndResult> GoalAndResults { get; set; }
        public virtual DbSet<IncludedPerson> IncludedPersons { get; set; }
        public virtual DbSet<IndividualServicePlan> IndividualServicePlans { get; set; }
        public virtual DbSet<LifeSkillDailyEntry> LifeSkillDailyEntries { get; set; }
        public virtual DbSet<LifeSkill> LifeSkills { get; set; }
        public virtual DbSet<SchoolActivity> SchoolActivities { get; set; }
        public virtual DbSet<Suitability> Suitabilities { get; set; }
        public virtual DbSet<SuitabilityItem> SuitabilityItems { get; set; }
        public virtual DbSet<SuitabilityCache> SuitabilityCaches { get; set; }
        public virtual DbSet<Workshop> Workshops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SafeHouseUser>().ToTable("SafeHouseUser");
            modelBuilder.Entity<Carton>().ToTable("Carton");
            modelBuilder.Entity<DailyEntry>().ToTable("DailyEntry");
            modelBuilder.Entity<FirstEvaluation>().ToTable("FirstEvaluation");
            modelBuilder.Entity<Evaluation>().ToTable("Evaluation");
            modelBuilder.Entity<ActivityDetails>().ToTable("ActivityDetails");
            modelBuilder.Entity<GoalAndResult>().ToTable("GoalAndResult");
            modelBuilder.Entity<IncludedPerson>().ToTable("IncludedPerson");
            modelBuilder.Entity<IndividualServicePlan>().ToTable("IndividualServicePlan");
            modelBuilder.Entity<LifeSkillDailyEntry>().ToTable("LifeSkillDailyEntry");
            modelBuilder.Entity<LifeSkill>().ToTable("LifeSkill");
            modelBuilder.Entity<SchoolActivity>().ToTable("SchoolActivity");
            modelBuilder.Entity<SuitabilityItem>().ToTable("SuitabilityItem");
            modelBuilder.Entity<SuitabilityCache>().ToTable("SuitabilityCache");
            modelBuilder.Entity<Workshop>().ToTable("Workshop");
        }
    }
}
