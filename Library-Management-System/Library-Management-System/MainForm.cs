using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
	enum TableStatus
	{
		All,
		Borrowed,
		Reserved
	}

	public partial class MainForm : Form
	{
		private IService service;
		private TableStatus tableStatus;
		private int currentIndex;
		private int idCurrentSubscriber;

		public MainForm(IService service, int idCurrentSubscriber)
		{
			InitializeComponent();
			this.service = service;
			this.idCurrentSubscriber = idCurrentSubscriber;
			tableStatus = TableStatus.All;
			DisplayBooks();
		}

		private void DisplayBooks()
		{
			if (tableStatus == TableStatus.All)
			{
				var source = new BindingSource();
				var books = service.GetAllBooks().ToList();
				source.DataSource = books;
				BooksDataGridView.DataSource = source;
			}
			else if (tableStatus == TableStatus.Borrowed)
			{
				DisplayBorrowedBooks();
			}
			else
			{
				DisplayReservedBooks();
			}
		}

		private void DisplayBorrowedBooks()
		{
			var source = new BindingSource();
			var borrowedBooks = service.GetAllBorrowedBooks().ToList();
			List<BookDTO> books = new List<BookDTO>();
			foreach (var book in borrowedBooks)
			{
				if (book.IdSubscriber == idCurrentSubscriber)
				{
					var b = service.FindBook(book.IdBook);
					if (b != null)
					{
						books.Add(new BookDTO(book.Id, b.Id, b.Title, b.Author));
					}
				}
			}


			source.DataSource = books;
			BooksDataGridView.DataSource = source;
		}


		private void DisplayReservedBooks()
		{
			var source = new BindingSource();
			var reservedBooks = service.GetAllReservedBooks().ToList();
			List<BookDTO> books = new List<BookDTO>();
			foreach (var book in reservedBooks)
			{
				if (book.IdSubscriber == idCurrentSubscriber)
				{
					var b = service.FindBook(book.IdBook);
					if (b != null)
					{
						books.Add(new BookDTO(book.Id, b.Id, b.Title, b.Author));
					}
				}
			}
			source.DataSource = books;
			BooksDataGridView.DataSource = source;
		}

		private void PopulateLabels()
		{
			var row = BooksDataGridView.Rows[currentIndex];

			if (tableStatus == TableStatus.All)
			{
				TitleLabel.Text = "Title: " + row.Cells[1].Value.ToString();
				AuthorLabel.Text = "Author: " + row.Cells[2].Value.ToString();
				RatingLabel.Text = "Rating: " + row.Cells[3].Value.ToString();
				CopiesLabel.Text = "Copies: " + row.Cells[4].Value.ToString();
			}
			else
			{
				TitleLabel.Text = "Title: " + row.Cells[2].Value.ToString();
				AuthorLabel.Text = "Author: " + row.Cells[3].Value.ToString();
				RatingLabel.Text = "";
				CopiesLabel.Text = "";
			}
		}

		private void ClearLabels()
		{
			currentIndex = 0;
			TitleLabel.Text = "Title: ";
			AuthorLabel.Text = "Author: ";
			RatingLabel.Text = "Rating: ";
			CopiesLabel.Text = "Copies: ";
		}

		private void BooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			currentIndex = e.RowIndex;

			PopulateLabels();
		}

		private void BorrowBookButton_Click(object sender, EventArgs e)
		{
			if (tableStatus == TableStatus.All)
			{
				var row = BooksDataGridView.Rows[currentIndex];

				var idBook = int.Parse(row.Cells[0].Value.ToString());
				var idSubscriber = idCurrentSubscriber;
				service.AddBorrowedBook(new BorrowedBook(idBook, idSubscriber));
				if (int.Parse(row.Cells[4].Value.ToString()) == 1)
				{
					service.DeleteBook(idBook);
				}
				else
				{
					var book = new Book(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), int.Parse(row.Cells[4].Value.ToString()) - 1);
					service.UpdateBook(book);
				}
				ClearLabels();
				DisplayBooks();
			}
			else
			{
				MessageBox.Show("You can't borrow a borrowed or reserved book!");
			}
		}

		private void BorrowedBooksButton_Click(object sender, EventArgs e)
		{
			tableStatus = TableStatus.Borrowed;
			ClearLabels();
			DisplayBooks();
		}

		private void ReservedBooksButton_Click(object sender, EventArgs e)
		{
			tableStatus = TableStatus.Reserved;
			ClearLabels();
			DisplayBooks();
		}

		private void AllBooksButton_Click(object sender, EventArgs e)
		{
			tableStatus = TableStatus.All;
			ClearLabels();
			DisplayBooks();
		}

		private void ReserveButton_Click(object sender, EventArgs e)
		{
			if (tableStatus == TableStatus.All)
			{
				var row = BooksDataGridView.Rows[currentIndex];

				var idBook = int.Parse(row.Cells[0].Value.ToString());
				var idSubscriber = idCurrentSubscriber;
				service.AddReservedBook(new ReservedBook(idBook, idSubscriber));
				if (int.Parse(row.Cells[4].Value.ToString()) == 1)
				{
					service.DeleteBook(idBook);
				}
				else
				{
					var book = new Book(int.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), int.Parse(row.Cells[4].Value.ToString()) - 1);
					service.UpdateBook(book);
				}
				ClearLabels();
				DisplayBooks();
			}
			else
			{
				MessageBox.Show("You can't reserve a borrowed or reserved book!");
			}
		}

		private void ReturnBookButton_Click(object sender, EventArgs e)
		{
			if (tableStatus == TableStatus.Borrowed)
			{
				var row = BooksDataGridView.Rows[currentIndex];
				var id = int.Parse(row.Cells[0].Value.ToString());
				var idBook = int.Parse(row.Cells[1].Value.ToString());
				var idSubscriber = idCurrentSubscriber;
				service.AddReturnedBook(new ReturnedBook(idBook, idSubscriber));

				service.DeleteBorrowedBook(id);
				ClearLabels();
				DisplayBooks();

				var ratingForm = new RatingForm(service, idBook);
				ratingForm.Show();
			}
			else
			{
				MessageBox.Show("You can return only borrowed books!");
			}
		}

		private void CancelReservationButton_Click(object sender, EventArgs e)
		{
			if (tableStatus == TableStatus.Reserved)
			{
				var row = BooksDataGridView.Rows[currentIndex];
				var id = int.Parse(row.Cells[0].Value.ToString());
				var idBook = int.Parse(row.Cells[1].Value.ToString());
				var idSubscriber = idCurrentSubscriber;
				var book = service.FindBook(idBook);
				book.Copies += 1;
				service.UpdateBook(book);

				service.DeleteReservedBook(id);


				ClearLabels();
				DisplayBooks();
			}
			else
			{
				MessageBox.Show("You can cancele only reserved books!");
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var logInForm = new LogInForm(service);
			logInForm.Show();
		}
	}
}
