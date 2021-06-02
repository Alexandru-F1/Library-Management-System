using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class BorrowedBookRepository : IBorrowedBookRepository
	{
		private readonly BorrowedBookContext borrowedBookContext;

		public BorrowedBookRepository(BorrowedBookContext borrowedBookContext)
		{
			this.borrowedBookContext = borrowedBookContext;
		}

		public void Add(BorrowedBook entity)
		{
			var response = borrowedBookContext.Add(entity);
			borrowedBookContext.SaveChanges();
		}

		public void Delete(int id)
		{
			borrowedBookContext.Remove(Find(id));
			borrowedBookContext.SaveChanges();
		}

		public BorrowedBook Find(int id)
		{
			return borrowedBookContext.BorrowedBooks.Where(e => e.Id == id).FirstOrDefault();
		}

		public List<BorrowedBook> GetAll()
		{
			return borrowedBookContext.BorrowedBooks.ToList();
		}

		public void Update(BorrowedBook entity)
		{
			var result = Find(entity.Id);
			result.IdBook = entity.IdBook;
			result.IdSubscriber = entity.IdSubscriber;
			borrowedBookContext.SaveChanges();
		}
	}
}
