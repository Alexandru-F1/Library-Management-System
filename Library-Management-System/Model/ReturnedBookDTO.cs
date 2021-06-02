using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class ReturnedBookDTO
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string User { get; set; }
		public int Id { get; set; }
		public int IdBook { get; set; }
		public int IdUser { get; set; }

		public ReturnedBookDTO(int id, int idBook, int idUser, string title, string author, string user)
		{
			Id = id;
			IdBook = idBook;
			IdUser = idUser;
			Title = title;
			Author = author;
			User = user;
		}
	}
}
