using System;
using System.Linq;
using BethanyPieShop.Models;
using BethanyPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BethanyPieShop.Components
{
  public class CategoryMenu : ViewComponent
  {

    private readonly ICategoryRepository _categoryRepository;

    public CategoryMenu(ICategoryRepository categoryRepository)
    {
      _categoryRepository = categoryRepository;
    }

    public IViewComponentResult Invoke()
    {
        var categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);

        return View(categories);
    }
  }
}