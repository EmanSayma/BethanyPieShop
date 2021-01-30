using System;
using System.Linq;
using System.Collections.Generic;

namespace BethanyPieShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}