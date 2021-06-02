using Model;
using System;

namespace Repository
{
	class Program
	{
		static void Main(string[] args)
		{
			var provider = new BookRepository(new BookContext("Data Source = LUNA\\SQLEXPRESS; Initial Catalog = Library; Integrated Security = True"));
			provider.Delete(2);
			provider.Delete(3);
		}
	}
}
