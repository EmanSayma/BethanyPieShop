using BethanyPieShop.Models;
using System.Collections.Generic;

namespace BethanyPieShop.ViewModels
{
  public class ShoppingCartViewModel
  {
      public ShoppingCart ShoppingCart { get; set; }

      public decimal ShoppingCartTotal { get; set; }
  }
}