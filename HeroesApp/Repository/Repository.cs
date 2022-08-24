using AutoMapper;
using HeroesApp.Data.Models;
using HeroesApp.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace HeroesApp.Repository
{
    public class Repository : IRepository
    {
        private readonly HeroesDataContext _context;
        private readonly IMapper _mapper;

        public Repository(HeroesDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<HeroDto> Get()
        {
            var heroes = _context.Heroes.OrderBy(r => EF.Functions.Random()).Take(10).Include("Ratings");

            var heroesFull = _mapper.Map<List<HeroDto>>(heroes);
            foreach(var hero in heroesFull)
            {
                hero.Score = hero.Ratings.Average(h => h.Score);
                hero.Ratings.Reverse();
            }

            return heroesFull.OrderByDescending(x => x.Score).ToList();
        } 
    }
}
