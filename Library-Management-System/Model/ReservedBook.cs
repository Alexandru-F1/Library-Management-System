using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Table("ReservedBooks")]
	public class ReservedBook
	{
		[Column("reserved_id")]
		public int Id { get; set; }
		[Column("id_carte")]
		public int IdBook { get; set; }
		[Column("id_subscriber")]
		public int IdSubscriber { get; set; }

		public ReservedBook()
		{
			Id = 0;
			IdBook = 0;
			IdSubscriber = 0;
		}

		public ReservedBook(int id)
		{
			Id = id;
			IdBook = 0;
			IdSubscriber = 0;
		}

		public ReservedBook(int idBook, int idSubscriber)
		{
			Id = 0;
			IdBook = idBook;
			IdSubscriber = idSubscriber;
		}

		public ReservedBook(int id, int idBook, int idSubscriber)
		{
			Id = id;
			IdBook = idBook;
			IdSubscriber = idSubscriber;
		}
	}
}
