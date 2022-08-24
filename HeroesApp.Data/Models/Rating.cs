namespace HeroesApp.Data.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public string NameGrader { get; set; } = String.Empty;
    }
}
