using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	public interface IService
	{
		Librarian LogInAdmin(string userName, string password);
		void AddBook(Book book);
		void DeleteBook(int id);
		Book FindBook(int id);
		Subscriber FindSubscriber(int id);
		void UpdateBook(Book book);
		List<Book> GetAllBooks();
		List<BorrowedBook> GetAllBorrowedBooks();
		List<ReturnedBook> GetAllReturnedBooks();
		List<ReservedBook> GetAllReservedBooks();
		void AddSubscriber(Subscriber subscriber);
		Subscriber LogInSubscriber(string userName, string password);
		bool FindSubscriberUsername(string username);
		void AddBorrowedBook(BorrowedBook borrowedBook);
		void AddReservedBook(ReservedBook reservedBook);
		void AddReturnedBook(ReturnedBook returnedBook);
		void DeleteBorrowedBook(int id);
		void DeleteReservedBook(int id);
		void DeleteReturnedBook(int id);
		void AddRatingBook(int id, int rating);
		
	}
}
