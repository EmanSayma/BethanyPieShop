using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BethanyPieShop.Controllers
{
  public class ContactController : Controller
  {

    public IActionResult Index()
    {
      
      return View();
    }
  }
}