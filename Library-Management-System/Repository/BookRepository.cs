using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class BookRepository : IBookRepository
	{
		private readonly BookContext bookContext;

		public BookRepository(BookContext bookContext)
		{
			this.bookContext = bookContext;
		}

		public void Add(Book entity)
		{
			var response = bookContext.Add(entity);
			bookContext.SaveChanges();
		}

		public void Delete(int id)
		{
			bookContext.Remove(Find(id));
			bookContext.SaveChanges();
		}

		public Book Find(int id)
		{
			return bookContext.Books.Where(e => e.Id == id).FirstOrDefault();
		}

		public List<Book> GetAll()
		{
			return bookContext.Books.ToList();
		}

		public void Update(Book entity)
		{
			var result = Find(entity.Id);
			result.Title = entity.Title;
			result.Author = entity.Author;
			result.Copies = entity.Copies;
			result.Rating = entity.Rating;
			bookContext.SaveChanges();
		}
	}
}
