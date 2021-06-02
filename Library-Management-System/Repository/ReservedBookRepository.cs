using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class ReservedBookRepository : IReservedBookRepository
	{
		private readonly ReservedBookContext reservedBookContext;

		public ReservedBookRepository(ReservedBookContext reservedBookContext)
		{
			this.reservedBookContext = reservedBookContext;
		}

		public void Add(ReservedBook entity)
		{
			var response = reservedBookContext.Add(entity);
			reservedBookContext.SaveChanges();
		}

		public void Delete(int id)
		{
			reservedBookContext.Remove(Find(id));
			reservedBookContext.SaveChanges();
		}

		public ReservedBook Find(int id)
		{
			return reservedBookContext.ReservedBooks.Where(e => e.Id == id).FirstOrDefault();

		}

		public List<ReservedBook> GetAll()
		{
			return reservedBookContext.ReservedBooks.ToList();
		}

		public void Update(ReservedBook entity)
		{
			var result = Find(entity.Id);
			result.IdBook = entity.IdBook;
			result.IdSubscriber = entity.IdSubscriber;
			reservedBookContext.SaveChanges();
		}
	}
}
