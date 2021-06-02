using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class BookDTO
	{
		public int Id { get; set; }
		public int IdBook { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }

		public BookDTO(int id, int idBook, string title, string author)
		{
			Id = id;
			IdBook = idBook;
			Title = title;
			Author = author;
		}
	}
}
