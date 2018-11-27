using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Search(string q)
		{
			var result = new List<SearchResult>();
			result.Add(new SearchResult
			{
				title = "film 1"
			});

			result.Add(new SearchResult
			{
				title = "film 2"
			});

			return Json(result);
		}
	}
}