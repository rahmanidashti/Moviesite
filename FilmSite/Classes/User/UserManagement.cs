using FilmSite.Classes.Film;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace FilmSite.Classes.User
{
	public class UserManagement
	{
		public User GetUserById(long userId)
		{
			var sqlConnection = new SqlConnection(Config.ConnectionString);
			sqlConnection.Open();

			var users = sqlConnection.Query<FilmUser>("Film.GetUserById", new
			{
				id = userId
			}, commandType: System.Data.CommandType.StoredProcedure);

			sqlConnection.Close();

			return users.FirstOrDefault();
		}

		public List<User> GetUsers(string username, string firstName, string lastName, string email, bool? enabled, int skip, int take)
		{
			throw new NotImplementedException();
		}
	}
}
