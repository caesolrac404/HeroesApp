using HeroesApp.Data.Models;

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
                    new Rating { NameGrader = "Elizabeth Vasquez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alan Fernandez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ruben Romero", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Serratos Ramirez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alicia Ramirez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alicia Contreras", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Gustavo Dominguez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Matias Gutierrez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jesus Antonio", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jorge Rojas", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Lexi Scott", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sawyer Campbell", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Leon Kelly", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Blakely Porter", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Presley White", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Aria Mccarty", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Dahlia Webster", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alaina Gibson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Andrew Hill", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Willa Webster", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Steven Brown", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Clayton Butler", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Winston Nelson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Hayden Watkins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Stella Walker", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Londyn Bailey", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Leah Barrett", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Joel Hughes", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Elise Gray", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Amari Hale", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Raelyn Collins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Aaron Morgan", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Waylon Carter", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Avianna Meyer", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ryder Brooks", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jaylen Davidson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sage Ward", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Winter Edwards", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Mariana Wilson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sarah Hale", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Raelyn Mccarty", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Damian Lee", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Callum Anderson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Emmett Murphy", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Damian Rogers", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Peter Parker", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Callum May", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Giovanni Castillo", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jaxton Myers", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Romeo Ortiz", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Solomon Perez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Natalia Johnson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Malia Mills", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Lillian Webster", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Erik Johnson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Mia Hoffman", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Margaret Stokes", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Samuel Parker", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Camilla Carter", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jorge Morgan", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Aniyah Cruz", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Rylee Long", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ember Ross", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Callum Floyd", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Axel Collins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sara Kelly", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Kaylani Garcia", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Liam Simpson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Andy Peterson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Mariana Mitchell", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Blake Fleming", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Xavier Thomas", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jocelyn Simpson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ricardo Young", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alayna Castillo", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Leilani Hopkins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Felicity Morales", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Axel Morris", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sawyer Howard", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Eli Perez", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Jake Johnston", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Gael Butler", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Nora Webster", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Kennedy Cook", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Morgan Cruz", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Marley Barrett", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Maria Diaz", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Eric Houston", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ayden Perez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Kane Garcia", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Caroline Morris", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Hector Roberts", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Raelyn Campbell", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Emilio Allen", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Connor Torres", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Rowan Collins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Dylan Patel", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Catalina Ramos", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Mario Scott", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ryder Mills", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Elizabeth Vasquez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alan Fernandez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ruben Romero", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Serratos Ramirez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alicia Ramirez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alicia Contreras", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Gustavo Dominguez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Matias Gutierrez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jesus Antonio", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jorge Rojas", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Lexi Scott", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sawyer Campbell", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Leon Kelly", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Blakely Porter", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Presley White", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Aria Mccarty", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Dahlia Webster", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alaina Gibson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Andrew Hill", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Willa Webster", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Steven Brown", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Clayton Butler", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Winston Nelson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Hayden Watkins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Stella Walker", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Londyn Bailey", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Leah Barrett", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Joel Hughes", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Elise Gray", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Amari Hale", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Raelyn Collins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Aaron Morgan", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Waylon Carter", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Avianna Meyer", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ryder Brooks", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jaylen Davidson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sage Ward", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Winter Edwards", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Mariana Wilson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sarah Hale", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Raelyn Mccarty", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Damian Lee", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Callum Anderson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Emmett Murphy", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Damian Rogers", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Peter Parker", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Callum May", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Giovanni Castillo", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jaxton Myers", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Romeo Ortiz", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Solomon Perez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Natalia Johnson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Malia Mills", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Lillian Webster", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Erik Johnson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Mia Hoffman", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Margaret Stokes", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Samuel Parker", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Camilla Carter", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jorge Morgan", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Aniyah Cruz", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Rylee Long", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ember Ross", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Callum Floyd", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Axel Collins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sara Kelly", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Kaylani Garcia", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Liam Simpson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Andy Peterson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Mariana Mitchell", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Blake Fleming", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Xavier Thomas", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Jocelyn Simpson", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ricardo Young", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Alayna Castillo", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Leilani Hopkins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Felicity Morales", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Axel Morris", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Sawyer Howard", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Eli Perez", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Jake Johnston", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Gael Butler", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Nora Webster", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Kennedy Cook", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Morgan Cruz", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Marley Barrett", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Maria Diaz", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Eric Houston", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ayden Perez", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Kane Garcia", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
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
                    new Rating { NameGrader = "Caroline Morris", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Hector Roberts", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Raelyn Campbell", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Emilio Allen", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Connor Torres", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Rowan Collins", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Dylan Patel", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Catalina Ramos", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Mario Scott", Score = (Convert.ToDouble(random.Next(1, 11))/2)},
                    new Rating { NameGrader = "Ryder Mills", Score = (Convert.ToDouble(random.Next(1, 11))/2)}
                }
            });

            context.SaveChanges();
        }
    }
}
