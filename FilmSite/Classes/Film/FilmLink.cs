using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSite.Classes.Film
{
	public class FilmLink
	{
		public long Id { get; set; }
		public long FilmId { get; set; }
		public string Url { get; set; }
		public LinkType LinkType { get; set; }
	}
}
