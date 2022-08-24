using HeroesApp.Models.Dtos;

namespace HeroesApp.Repository
{
    public interface IRepository
    {
        List<HeroDto> Get();
    }
}
