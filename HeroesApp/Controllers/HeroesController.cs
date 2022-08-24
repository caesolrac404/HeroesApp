using HeroesApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HeroesApp.Controllers
{
    public class HeroesController : Controller
    {
        private readonly IRepository _repository;

        public HeroesController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Heroes()
        {
            var heroes = _repository.Get();
            return View(heroes);
        }
    }
}
