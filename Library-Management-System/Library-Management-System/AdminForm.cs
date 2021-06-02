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
	public partial class AdminForm : Form
	{
		private IService service;
		private int currentBookIndex = 1;

		public AdminForm(IService service)
		{
			this.service = service;
			InitializeComponent();
			DisplayBooks();
		}

		//ViewReturnedBook
		private void button4_Click(object sender, EventArgs e)
		{
			var returnedBooks = new ReturnedBooksForm(service,this);
			returnedBooks.Show();
		}

		private void AuthorLabel_Click(object sender, EventArgs e)
		{

		}

		private void ClearTextBoxes()
		{
			TitleTextBox.Text = "";
			AuthorTextBox.Text = "";
			RatingTextBox.Text = "";
			CopiesTextBox.Text = "";
		}

		public void DisplayBooks()
		{
			var source = new BindingSource();
			var matches = service.GetAllBooks().ToList();
			source.DataSource = matches;
			BooksDataGridView.DataSource = source;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var title = TitleTextBox.Text;
			var author = TitleTextBox.Text;
			var rating = RatingTextBox.Text;
			var copies = CopiesTextBox.Text;

			var book = new Book(title, author, rating, int.Parse(copies));
			service.AddBook(book);

			ClearTextBoxes();
			DisplayBooks();
		}

		//UpdateButton
		private void button3_Click(object sender, EventArgs e)
		{
			var title = TitleTextBox.Text;
			var author = TitleTextBox.Text;
			var rating = RatingTextBox.Text;
			var copies = CopiesTextBox.Text;

			if (title == "" || author == "" || rating == "" || copies == "")
			{
				MessageBox.Show("One field is empty!");
			}
			else { 
				var row = BooksDataGridView.Rows[currentBookIndex];
				var book = new Book(int.Parse(row.Cells[0].Value.ToString()), title, author, rating, int.Parse(copies));
				service.UpdateBook(book);
				ClearTextBoxes();
				DisplayBooks();
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			var row = BooksDataGridView.Rows[currentBookIndex];
			service.DeleteBook(int.Parse(row.Cells[0].Value.ToString()));
			DisplayBooks();
		}

		private void BooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			currentBookIndex = e.RowIndex;
		}

		private void BooksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			currentBookIndex = e.RowIndex;
		}

		private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var logInForm = new LogInForm(service);
			logInForm.Show();
		}
	}
}
