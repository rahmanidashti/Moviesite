using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FilmSite.Controllers
{
	public class ContentController : Controller
	{
		public IActionResult Film(string id)
		{
			return View();
		}

		public IActionResult List()
		{
			return View();
		}
	}
}