using System;
using System.Linq;
using BethanyPieShop.Models;
using BethanyPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BethanyPieShop.Controllers
{
  public class HomeController : Controller
  {

    private readonly IPieRepository _pieRepository;

    public HomeController(IPieRepository pieRepository)
    {
      _pieRepository = pieRepository;
    }

    public IActionResult Index()
    {
      var homeViewModel = new HomeViewModel
      {
          PiesOfTheWeek = _pieRepository.PiesOfTheWeek
      };
    
      return View(homeViewModel);
    }
  }
}