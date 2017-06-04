using BethanysPieShop.WebUI.ViewModels;
using DataAccess.Contracts;
using System.Web.Mvc;

namespace BethanysPieShop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfWeek
            };

            return View(homeViewModel);
        }
    }
}
