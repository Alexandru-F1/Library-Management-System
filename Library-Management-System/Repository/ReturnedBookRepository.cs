using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class ReturnedBookRepository : IReturnedBookRepository
	{
		private readonly ReturnedBookContext returnedBookContext;

		public ReturnedBookRepository(ReturnedBookContext returnedBookContext)
		{
			this.returnedBookContext = returnedBookContext;
		}

		public void Add(ReturnedBook entity)
		{
			var response = returnedBookContext.Add(entity);
			returnedBookContext.SaveChanges();
		}

		public void Delete(int id)
		{
			returnedBookContext.Remove(Find(id));
			returnedBookContext.SaveChanges();
		}

		public ReturnedBook Find(int id)
		{
			return returnedBookContext.ReturnedBooks.Where(e => e.Id == id).FirstOrDefault();
		}

		public List<ReturnedBook> GetAll()
		{
			return returnedBookContext.ReturnedBooks.ToList();
		}

		public void Update(ReturnedBook entity)
		{
			var result = Find(entity.Id);
			result.IdBook = entity.IdBook;
			result.IdSubscriber = entity.IdSubscriber;
			returnedBookContext.SaveChanges();
		}
	}
}
