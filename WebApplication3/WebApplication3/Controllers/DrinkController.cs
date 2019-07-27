using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Interfaces;
using DrinkAndGo.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICatagoryRepository _catagoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICatagoryRepository catagoryRepository, IDrinkRepository drinkRepository)
        {
            _catagoryRepository = catagoryRepository;
            _drinkRepository = drinkRepository;

        }

        public ViewResult List() {

            DrinkListViewModel dm = new DrinkListViewModel();
            dm.drinks = _drinkRepository.Drinks ;
            dm.CatagoryName = "DrinkCatagory";
            return View(dm);
        }
    } 
}