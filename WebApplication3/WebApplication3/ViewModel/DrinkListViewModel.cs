using DrinkAndGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.ViewModel
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> drinks{get; set;}
        public String CatagoryName { get; set; }
    }
}
