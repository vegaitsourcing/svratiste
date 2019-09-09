using Microsoft.EntityFrameworkCore;
using SafeHouse.Core.Entities;
using System;
using System.Linq;

namespace SafeHouse.Infrastructure.Data
{
    public class SafeHouseDbContext : DbContext
    {
        public virtual DbSet<SafeHouseUser> SafeHouseUsers { get; set; }

        public virtual DbSet<Carton> Cartons { get; set; }

        public virtual DbSet<DailyEntry> DailyEntries { get; set; }

        public virtual DbSet<FirstEvaluation> FirstEvaluations { get; set; }

        public virtual DbSet<Evaluation> Evaluations { get; set; }

        public virtual DbSet<ActivityDetails> ActivityDetails { get; set; }

        public virtual DbSet<GoalAndResult> GoalAndResults { get; set; }

        public virtual DbSet<IncludedPerson> IncludedPersons { get; set; }

        public virtual DbSet<IndividualPlan> IndividualPlans { get; set; }

        public virtual DbSet<LifeSkillDailyEntry> LifeSkillDailyEntries { get; set; }

        public virtual DbSet<LifeSkill> LifeSkills { get; set; }

        public virtual DbSet<SchoolActivity> SchoolActivities { get; set; }

        public virtual DbSet<Suitability> Suitabilities { get; set; }

        public virtual DbSet<SuitabilityItem> SuitabilityItems { get; set; }

        public virtual DbSet<SuitabilityCache> SuitabilityCaches { get; set; }

        public virtual DbSet<Workshop> Workshops { get; set; }

        public SafeHouseDbContext() : base()
        {
        }

        public SafeHouseDbContext(DbContextOptions<SafeHouseDbContext> options) : base(options)
        {
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker
                .Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreationDate = DateTime.UtcNow;
                }

                ((BaseEntity)entity.Entity).LastModificationDate = DateTime.UtcNow;
            }
        }
    }
}