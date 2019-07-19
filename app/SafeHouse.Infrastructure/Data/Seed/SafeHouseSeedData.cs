using Microsoft.EntityFrameworkCore.Internal;
using SafeHouse.Core.Entities;
using System;
using LifeSkill = SafeHouse.Core.Entities.Enums.LifeSkill;

namespace SafeHouse.Infrastructure.Data.Seed
{
    public static class SafeHouseSeedData
    {
        public static void EnsureSeedData(this SafeHouseDbContext db)
        {
            if (!db.SuitabilityCaches.Any())
            {
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Spava na ulici" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Hranu pronalazi u kontejnerima" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Skuplja sekundarne sirovine" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Prodaje seksualne usluge" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Prodaje na pijaci/ulici" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Pomaze porodici u radu na ulici" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Ekstremno siromasna porodica, postoji rizik za dete" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Drugo" });
            }

            if (!db.LifeSkills.Any())
            {
                foreach (LifeSkill lifeSkill in Enum.GetValues(typeof(LifeSkill)))
                {
                    db.LifeSkills.Add(new Core.Entities.LifeSkill { LifeSkillType = lifeSkill, IsGroupSkill = false });
                }
            }

            if (!db.SafeHouseUsers.Any())
            {
                // Username: admin
                // Password: admin
                db.SafeHouseUsers.Add(new SafeHouseUser
                {
                    CommonName = "SafeHouse Administrator",
                    Username = "admin",
                    Password = "$2y$12$vDDFGNGdrRy.eYRpYBJh4.TziOKDocvoo.nxD8WkWkhGMxCQapFGq"
                });
            }

            db.SaveChanges();
        }
    }
}