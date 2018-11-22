using System.Linq;
using BethanysPies.Models;
using BethanysPies.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPies.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            // constructor injection
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Pie Overview";
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethany's Pie Shop",
                Pies = pies.ToList()
            };
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null) return NotFound();

            return View(pie);
        }
    }
}