using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSite.Classes.User
{
	public abstract class User
	{
		public long Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Enabled { get; set; }

		public virtual void Register()
		{
			throw new NotImplementedException();
		}

		public virtual void Delete()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Block()
		{
			throw new NotImplementedException();
		}
	}
}
