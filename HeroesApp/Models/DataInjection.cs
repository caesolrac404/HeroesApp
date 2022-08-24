using HeroesApp.Data.Models;
using System;

namespace HeroesApp.Models
{
    public static class DataInjection
    {
        public static void Injection(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<HeroesDataContext>();
            context.Database.EnsureCreated();
            AddHeroes(context);
        }

        private static double GetRandomRating(Random random)
        {
            return Convert.ToDouble(random.Next(1, 11))/2;
        }

        private static void AddHeroes(HeroesDataContext context)
        {
            var hero = context.Heroes.FirstOrDefault();
            if (hero != null) return;
            var random = new Random();

            context.Heroes.Add(new Hero
            {
                Name = "Iron Man",
                Age = 43,
                City = "New York",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/002irm_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Elizabeth Vasquez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alan Fernandez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ruben Romero", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Serratos Ramirez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alicia Ramirez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alicia Contreras", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Gustavo Dominguez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Matias Gutierrez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jesus Antonio", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jorge Rojas", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Iron Fist",
                Age = 33,
                City = " K'un-Lun",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/029irf_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Lexi Scott", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sawyer Campbell", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Leon Kelly", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Blakely Porter", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Presley White", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Aria Mccarty", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Dahlia Webster", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alaina Gibson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Andrew Hill", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Willa Webster", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Spider-Man",
                Age = 18,
                City = "New York",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/005smp_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Steven Brown", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Clayton Butler", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Winston Nelson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Hayden Watkins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Stella Walker", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Londyn Bailey", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Leah Barrett", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Joel Hughes", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Elise Gray", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Amari Hale", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "War Machine",
                Age = 48,
                City = "New York",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/042wmr_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Raelyn Collins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Aaron Morgan", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Waylon Carter", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Avianna Meyer", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ryder Brooks", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jaylen Davidson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sage Ward", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Winter Edwards", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Mariana Wilson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sarah Hale", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Luke Cage",
                Age = 52,
                City = "Manhattan",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/028lcg_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Raelyn Mccarty", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Damian Lee", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Callum Anderson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Emmett Murphy", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Damian Rogers", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Peter Parker", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Callum May", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Giovanni Castillo", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jaxton Myers", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Romeo Ortiz", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Black Widow",
                Age = 32,
                City = "Los Angeles",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/011blw_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Solomon Perez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Natalia Johnson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Malia Mills", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Lillian Webster", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Erik Johnson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Mia Hoffman", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Margaret Stokes", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Samuel Parker", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Camilla Carter", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jorge Morgan", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Hawkeye",
                Age = 35,
                City = "Ohio",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/018hcb_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Aniyah Cruz", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Rylee Long", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ember Ross", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Callum Floyd", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Axel Collins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sara Kelly", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Kaylani Garcia", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Liam Simpson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Andy Peterson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Mariana Mitchell", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Captain America",
                Age = 80,
                City = "Washington",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/003cap_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Blake Fleming", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Xavier Thomas", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jocelyn Simpson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ricardo Young", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alayna Castillo", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Leilani Hopkins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Felicity Morales", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Axel Morris", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sawyer Howard", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Eli Perez", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Vision",
                Age = 40,
                City = "Boston",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/013vis_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Jake Johnston", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Gael Butler", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Nora Webster", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Kennedy Cook", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Morgan Cruz", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Marley Barrett", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Maria Diaz", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Eric Houston", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ayden Perez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Kane Garcia", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Black Panther",
                Age = 30,
                City = "Wakanda",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/007blp_com_crd_01_0.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Caroline Morris", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Hector Roberts", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Raelyn Campbell", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Emilio Allen", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Connor Torres", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Rowan Collins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Dylan Patel", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Catalina Ramos", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Mario Scott", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ryder Mills", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Hulk",
                Age = 45,
                City = "Texas",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/006hbb_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Elizabeth Vasquez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alan Fernandez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ruben Romero", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Serratos Ramirez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alicia Ramirez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alicia Contreras", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Gustavo Dominguez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Matias Gutierrez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jesus Antonio", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jorge Rojas", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Captain Marvel",
                Age = 25,
                City = "California",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/008cmv_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Lexi Scott", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sawyer Campbell", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Leon Kelly", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Blakely Porter", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Presley White", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Aria Mccarty", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Dahlia Webster", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alaina Gibson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Andrew Hill", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Willa Webster", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Ant-Man",
                Age = 35,
                City = "Lousiana",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/ant-man-eric-o-grady-earth-616.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Steven Brown", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Clayton Butler", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Winston Nelson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Hayden Watkins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Stella Walker", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Londyn Bailey", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Leah Barrett", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Joel Hughes", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Elise Gray", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Amari Hale", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Thor",
                Age = 1500,
                City = "Asgard",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/004tho_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Raelyn Collins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Aaron Morgan", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Waylon Carter", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Avianna Meyer", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ryder Brooks", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jaylen Davidson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sage Ward", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Winter Edwards", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Mariana Wilson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sarah Hale", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Invisible-Woman",
                Age = 31,
                City = "San Francisco",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/211sus_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Raelyn Mccarty", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Damian Lee", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Callum Anderson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Emmett Murphy", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Damian Rogers", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Peter Parker", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Callum May", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Giovanni Castillo", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jaxton Myers", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Romeo Ortiz", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "She-Hulk",
                Age = 29,
                City = "Manhattan",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/123shh_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Solomon Perez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Natalia Johnson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Malia Mills", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Lillian Webster", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Erik Johnson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Mia Hoffman", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Margaret Stokes", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Samuel Parker", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Camilla Carter", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jorge Morgan", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Daredevil",
                Age = 41,
                City = "San Diego",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/026ddm_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Aniyah Cruz", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Rylee Long", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ember Ross", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Callum Floyd", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Axel Collins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sara Kelly", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Kaylani Garcia", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Liam Simpson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Andy Peterson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Mariana Mitchell", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Captain Britain",
                Age = 50,
                City = "London",
                Picture = "https://i.annihil.us/u/prod/marvel/i/mg/d/00/5f3d368aa8fe7/standard_fantastic.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Blake Fleming", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Xavier Thomas", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Jocelyn Simpson", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ricardo Young", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Alayna Castillo", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Leilani Hopkins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Felicity Morales", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Axel Morris", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Sawyer Howard", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Eli Perez", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Wolverine",
                Age = 100,
                City = "Texas",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/034wlv_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Jake Johnston", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Gael Butler", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Nora Webster", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Kennedy Cook", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Morgan Cruz", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Marley Barrett", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Maria Diaz", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Eric Houston", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ayden Perez", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Kane Garcia", Score = GetRandomRating(random)}
                }
            });

            context.Heroes.Add(new Hero
            {
                Name = "Doctor Strange",
                Age = 47,
                City = "California",
                Picture = "https://terrigen-cdn-dev.marvel.com/content/prod/1x/009drs_com_crd_01.jpg",
                Ratings = new List<Rating>
                {
                    new Rating { NameGrader = "Caroline Morris", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Hector Roberts", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Raelyn Campbell", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Emilio Allen", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Connor Torres", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Rowan Collins", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Dylan Patel", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Catalina Ramos", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Mario Scott", Score = GetRandomRating(random)},
                    new Rating { NameGrader = "Ryder Mills", Score = GetRandomRating(random)}
                }
            });

            context.SaveChanges();
        }
    }
}
