using System;
using Microsoft.Extensions.DependencyInjection;
using SafeHouse.Data.Entities;

namespace SafeHouse.Api
{
    public static class DbInitialization
    {
        public static void FillSuitabiltyCache(IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<SafeHouseContext>();
            dbContext.Database.EnsureCreated();

            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Spava na ulici" });
            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Hranu pronalazi u kontejnerima" });
            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Skuplja sekundarne sirovine" });
            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Prodaje seksualne usluge" });
            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Prodaje na pijaci/ulici" });
            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Pomaze porodici u radu na ulici" });
            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Pomaze porodici u radu na ulici" });
            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Ekstremno siromasna porodica, postoji rizik za dete" });
            dbContext.SuitabilityCaches.Add(new SuitabilityCache() { Name = "Drugo" });
        }
    }
}
