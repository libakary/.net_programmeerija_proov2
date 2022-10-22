using Microsoft.EntityFrameworkCore;
using RazorPagesAriulesanne.Data;

namespace RazorPagesAriulesanne.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesAriulesanneContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesAriulesanneContext>>()))
            {
                if (context == null || context.Eraisik == null)
                {
                    throw new ArgumentNullException("Null RazorPagesAriulesanneContext");
                }

                // Look for any x.
                if (context.Eraisik.Any())
                {
                    return;   // DB has been seeded
                }

                context.Uritus.AddRange(
                    new Uritus
                    {
                        UrituseNimi = "Lorem ipsum dolor sit amet",
                        Toimumisaeg = DateTime.Parse("2012-2-12"),
                        Toimumiskoht = "Tallinn",
                        Lisainfo = "Lisainfo"
                    },

                    new Uritus
                    {
                        UrituseNimi = "Ut enim ad",
                        Toimumisaeg = DateTime.Parse("2007-4-06"),
                        Toimumiskoht = "Tartu",
                        Lisainfo = "Quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat"
                    }
                );

                context.Eraisik.AddRange(
                    new Eraisik
                    {
                        Eesnimi = "Mihkel",
                        Perekonnanimi = "Amman",
                        Isikukood = 32412246523,
                        Maksmisviis = "pangaülekanne",
                        Lisainfo = "Lisainfo"
                    },

                    new Eraisik
                    {
                        Eesnimi = "Uku",
                        Perekonnanimi = "Leele",
                        Isikukood = 37810014944,
                        Maksmisviis = "sularaha",
                        Lisainfo = "Quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat"
                    }
                );

                context.Ettevotja.AddRange(
                    new Ettevotja
                    {
                        JuriidilineNimi = "Nullam OÜ",
                        Registrikood = 70000622,
                        OsavotjateArv = 3,
                        Maksmisviis = "pangaülekanne",
                        Lisainfo = "Quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat"
                    },
                    new Ettevotja
                    {
                        JuriidilineNimi = "Registrite ja Infosüsteemide Keskus",
                        Registrikood = 70000310,
                        OsavotjateArv = 5,
                        Maksmisviis = "pangaülekanne",
                        Lisainfo = "Lisainfo"
                    }


                );

                var kulastused = new UrituseKulastused[]
                {
                    new UrituseKulastused
                    {
                        EraisikID = 2,
                        EttevotjaID = 1,
                        UritusID = 2,
                    },

                    new UrituseKulastused
                    {
                        EraisikID = 1,
                        EttevotjaID = 2,
                        UritusID = 1,
                    },
                };


                context.SaveChanges();
            }
        }
    }
}
