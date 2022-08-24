namespace HeroesApp.Models.Dtos
{
    public class HeroDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public string City { get; set; } = String.Empty;
        public string Picture { get; set; } = String.Empty;
        public double Score { get; set; }
        public List<RatingDto> Ratings { get; set; }

    }
}
