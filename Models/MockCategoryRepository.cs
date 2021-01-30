using System;
using System.Linq;
using System.Collections.Generic;

namespace BethanyPieShop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => 
        new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Fruit pies", Description="All-fruits in a pie"},
            new Category{CategoryId=2, CategoryName="Cheese pies", Description="All-cheese in a pie"},
            new Category{CategoryId=3, CategoryName="Seasonal pies", Description="All-seasonal in a pie"}
        };

    }
}