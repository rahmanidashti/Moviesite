using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSite.Classes.Film
{
	public abstract class Film
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public string Summary { get; set; }
		public int Year { get; set; }
		public DateTime RegDateTime { get; set; }
		public float Imdb { get; set; }
		public float Critics { get; set; }

		public float Score { get; set; }

		public string MainPosterLink { get; set; }
		public string MainTrailerLink { get; set; }

		public List<string> DownloadLinks { get; set; }
		public List<string> PosterLinks { get; set; }
		public List<string> TrailerLinks { get; set; }

		public List<Country> Countries { get; set; }
		public List<Person> Directors { get; set; }
		public List<Person> Casts { get; set; }


		public void Register()
		{
			throw new NotImplementedException();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void SetScore(FilmUser user, float score)
		{
			throw new NotImplementedException();
		}

		public bool IsUserScored(FilmUser user)
		{
			throw new NotImplementedException();
		}
	}
}
