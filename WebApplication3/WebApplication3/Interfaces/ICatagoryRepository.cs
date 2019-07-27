using DrinkAndGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Interfaces
{
    public interface ICatagoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
