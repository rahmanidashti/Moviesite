using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FilmSite.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
			var data = new
			{
				name = "Ali",
				family = "Alizadeh"
			};


            return Json(data);
        }

		public IActionResult List()
		{
			return View();
		}
    }
}