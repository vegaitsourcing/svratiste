using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SafeHouse.Data;
using SafeHouse.Data.Entities;

namespace SafeHouse.Api
{
    public static class SafeHouseSeedData
    {
        public static void EnsureSeedData(this SafeHouseContext db)
        {
            if (!db.SuitabilityCaches.Any())
            {
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Spava na ulici" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Hranu pronalazi u kontejnerima" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Skuplja sekundarne sirovine" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Prodaje seksualne usluge" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Prodaje na pijaci/ulici" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Pomaze porodici u radu na ulici" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Pomaze porodici u radu na ulici" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Ekstremno siromasna porodica, postoji rizik za dete" });
                db.SuitabilityCaches.Add(new SuitabilityCache { Name = "Drugo" });
            }

            if (!db.SafeHouseUsers.Any())
            {
                db.SafeHouseUsers.Add(new SafeHouseUser
                {
                    CommonName = "SafeHouse Administrator",
                    Username = "admin",
                    Password = "$2a$10$smR2P.jjOez5efnnaSle2uTlGJIzv2TLH9OTlR2b7aYICVARBOVga"
                });
            }

            db.SaveChanges();
        }
    }
}
