using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSite.Classes.Film
{
	public class Comment
	{
		public long Id { get; set; }
		public long SourceId { get; set; }
		public int SourceType { get; set; }
		public string Content { get; set; }
		public DateTime RegDateTime { get; set; }
		public long Likes { get; set; }
		public long Dislikes { get; set; }

		public FilmUser User { get; set; }

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

		public void SetLike(FilmUser user)
		{
			throw new NotImplementedException();
		}

		public void SetDisLike(FilmUser user)
		{
			throw new NotImplementedException();
		}
	}
}
