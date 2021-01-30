using System;
using System.Linq;
using System.Collections.Generic;

namespace BethanyPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }

        IEnumerable<Pie> PiesOfTheWeek { get; }

        Pie GetPieById(int pieId);
    }
}