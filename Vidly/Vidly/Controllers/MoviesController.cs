﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Saikat" };
            //return View(movie);

            return Content("hello bro");

            // return RedirectToAction("Index", "Home", new { page = 2, sortBy = "name" });
        }

        public ActionResult Edit(int id) {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy) {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month) {
            return Content(year + "/" + month);
        }

        

    }
}