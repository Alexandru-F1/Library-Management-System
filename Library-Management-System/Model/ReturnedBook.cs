using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
	[Table("ReturnedBooks")]
	public class ReturnedBook
	{
		[Column("returned_id")]
		public int Id { get; set; }
		[Column("id_carte")]
		public int IdBook { get; set; }
		[Column("id_subscriber")]
		public int IdSubscriber { get; set; }

		public ReturnedBook()
		{
			Id = 0;
			IdBook = 0;
			IdSubscriber = 0;
		}

		public ReturnedBook(int id)
		{
			Id = id;
			IdBook = 0;
			IdSubscriber = 0;
		}

		public ReturnedBook(int idBook, int idSubscriber)
		{
			Id = 0;
			IdBook = idBook;
			IdSubscriber = idSubscriber;
		}

		public ReturnedBook(int id, int idBook, int idSubscriber)
		{
			Id = id;
			IdBook = idBook;
			IdSubscriber = idSubscriber;
		}
	}
}
