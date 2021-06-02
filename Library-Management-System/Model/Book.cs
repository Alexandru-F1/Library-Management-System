using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Table("Books")]
	public class Book
	{
		[Column("book_id")]
		public int Id { get; set; }
		[Column("title")]
		public string Title { get; set; }
		[Column("author")]
		public string Author { get; set; }
		[Column("rating")]
		public string Rating { get; set; }

		[Column("copies")]
		public int Copies { get; set; }

		public Book()
		{
			Id = -1;
			Title = "";
			Author = "";
			Rating = "";
			Copies = 0;
		}

		public Book(int id)
		{
			Id = id;
			Title = "";
			Author = "";
			Rating = "";
			Copies = 0;
		}

		public Book(int id, string title, string author, string rating, int copies)
		{
			Id = id;
			Title = title;
			Author = author;
			Rating = rating;
			Copies = copies;
		}

		public Book(string title, string author, string rating, int copies)
		{
			Title = title;
			Author = author;
			Rating = rating;
			Copies = copies;
		}
	}
}
