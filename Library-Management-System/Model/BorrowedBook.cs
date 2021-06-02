using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Table("BorrowedBooks")]
	public class BorrowedBook
	{
		[Column("borrowed_id")]
		public int Id { get; set; }
		[Column("id_carte")]
		public int IdBook { get; set; }
		[Column("id_subscriber")]
		public int IdSubscriber { get; set; }

		public BorrowedBook()
		{
			Id = 0;
			IdBook = 0;
			IdSubscriber = 0;
		}

		public BorrowedBook(int id)
		{
			Id = id;
			IdBook = 0;
			IdSubscriber = 0;
		}

		public BorrowedBook(int idBook, int idSubscriber)
		{
			Id = 0;
			IdBook = idBook;
			IdSubscriber = idSubscriber;
		}

		public BorrowedBook(int id, int idBook, int idSubscriber)
		{
			Id = id;
			IdBook = idBook;
			IdSubscriber = idSubscriber;
		}
	}
}
