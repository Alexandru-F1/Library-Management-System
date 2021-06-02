using Model;
using Repository;
using Repository.Interfaces;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			var connectionString = "Data Source = LUNA\\SQLEXPRESS; Initial Catalog = Library; Integrated Security = True";
			IBookRepository bookRepository = new BookRepository(new BookContext(connectionString));
			ILibrarianRepository librarianRepository = new LibrarianRepository(new LibrarianContext(connectionString));
			ISubscriberRepository subscriberRepository = new SubscriberRepository(new SubscriberContext(connectionString));
			IBorrowedBookRepository borrowedBookRepository = new BorrowedBookRepository(new BorrowedBookContext(connectionString));
			IReservedBookRepository reservedBookRepository = new ReservedBookRepository(new ReservedBookContext(connectionString));
			IReturnedBookRepository returnedBookRepository = new ReturnedBookRepository(new ReturnedBookContext(connectionString));
			IService service = new Service.Service(bookRepository, librarianRepository, subscriberRepository, borrowedBookRepository, reservedBookRepository, returnedBookRepository);


			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LogInForm(service));
		}
	}
}
