using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class LibrarianRepository : ILibrarianRepository
	{
		private readonly LibrarianContext librarianContext;

		public LibrarianRepository(LibrarianContext librarianContext)
		{
			this.librarianContext = librarianContext;
		}

		public void Add(Librarian entity)
		{
			var response = librarianContext.Add(entity);
			librarianContext.SaveChanges();
		}

		public void Delete(int id)
		{
			librarianContext.Remove(Find(id));
			librarianContext.SaveChanges();
		}

		public Librarian Find(int id)
		{
			return librarianContext.Librarians.Where(e => e.Id == id).FirstOrDefault();
		}

		public Librarian FindLibrarianByUsername(string username)
		{
			return librarianContext.Librarians.Where(e => e.UserName == username).FirstOrDefault();
		}

		public List<Librarian> GetAll()
		{
			return librarianContext.Librarians.ToList();
		}

		public void Update(Librarian entity)
		{
			var response = librarianContext.Update(entity);
			librarianContext.SaveChanges();
		}
	}
}
