using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Repository.Interfaces;

namespace Service
{
	public class Service : IService
	{
		private IBookRepository bookRepository;
		private ILibrarianRepository librarianRepository;
		private ISubscriberRepository subscriberRepository;
		private IBorrowedBookRepository borrowedBookRepository;
		private IReservedBookRepository reservedBookRepository;
		private IReturnedBookRepository returnedBookRepository;

		public Service(IBookRepository bookRepository, ILibrarianRepository librarianRepository, ISubscriberRepository subscriberRepository, IBorrowedBookRepository borrowedBookRepository, IReservedBookRepository reservedBookRepository, IReturnedBookRepository returnedBookRepository)
		{
			this.bookRepository = bookRepository;
			this.librarianRepository = librarianRepository;
			this.subscriberRepository = subscriberRepository;
			this.borrowedBookRepository = borrowedBookRepository;
			this.reservedBookRepository = reservedBookRepository;
			this.returnedBookRepository = returnedBookRepository;
		}

		public void AddBook(Book book)
		{
			bookRepository.Add(book);
		}

		public void AddBorrowedBook(BorrowedBook borrowedBook)
		{
			borrowedBookRepository.Add(borrowedBook);
		}

		public void AddRatingBook(int id, int rating)
		{
			var book = bookRepository.Find(id);
			book.Rating = ((float.Parse(book.Rating) + rating) / 2).ToString();
			bookRepository.Update(book);
		}

		public void AddReservedBook(ReservedBook reservedBook)
		{
			reservedBookRepository.Add(reservedBook);
		}

		public void AddReturnedBook(ReturnedBook returnedBook)
		{
			returnedBookRepository.Add(returnedBook);
		}

		public void AddSubscriber(Subscriber subscriber)
		{
			subscriberRepository.Add(subscriber);
		}

		public void DeleteBook(int id)
		{
			bookRepository.Delete(id);
		}

		public void DeleteBorrowedBook(int id)
		{
			borrowedBookRepository.Delete(id);
		}

		public void DeleteReservedBook(int id)
		{
			reservedBookRepository.Delete(id);
		}

		public void DeleteReturnedBook(int id)
		{
			returnedBookRepository.Delete(id);
		}

		public Book FindBook(int id)
		{
			return bookRepository.Find(id);
		}

		public Subscriber FindSubscriber(int id)
		{
			return subscriberRepository.Find(id);
		}

		public bool FindSubscriberUsername(string username)
		{
			if (subscriberRepository.FindByUsername(username) != null)
			{
				return false;
			}
			return true;
		}

		public List<Book> GetAllBooks()
		{
			return bookRepository.GetAll();
		}

		public List<BorrowedBook> GetAllBorrowedBooks()
		{
			return borrowedBookRepository.GetAll();
		}

		public List<ReservedBook> GetAllReservedBooks()
		{
			return reservedBookRepository.GetAll();
		}

		public List<ReturnedBook> GetAllReturnedBooks()
		{
			return returnedBookRepository.GetAll();
		}

		public Librarian LogInAdmin(string userName, string password)
		{
			Librarian librarian = librarianRepository.FindLibrarianByUsername(userName);

			if (password == librarian.Password)
			{
				return librarian;
			}
			return null;
		}

		public Subscriber LogInSubscriber(string userName, string password)
		{
			Subscriber subscriber = subscriberRepository.FindByUsername(userName);

			if (subscriber !=null &&password == subscriber.Password)
			{
				return subscriber;
			}
			return null;
		}

		public void UpdateBook(Book book)
		{
			bookRepository.Update(book);
		}
	}
}
