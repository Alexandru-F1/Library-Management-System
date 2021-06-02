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
	public partial class ReturnedBooksForm : Form
	{
		private IService service;
		private int currentIndex;
		private AdminForm admin;

		public ReturnedBooksForm(IService service, AdminForm admin)
		{
			InitializeComponent();
			this.service = service;
			this.admin = admin;
			DisplayBooks();
		}

		private void DisplayBooks()
		{
			var source = new BindingSource();
			var returnedBooks = new List<ReturnedBookDTO>();
			var books = service.GetAllReturnedBooks().ToList();
			foreach (var b in books)
			{
				var user = service.FindSubscriber(b.IdSubscriber);
				var book = service.FindBook(b.IdBook);
				returnedBooks.Add(new ReturnedBookDTO(b.Id, book.Id, user.Id, book.Title, book.Author, user.UserName));
			}
			source.DataSource = returnedBooks;
			DataGridView.DataSource = source;
		}


		//Confirm Button
		private void button1_Click(object sender, EventArgs e)
		{
			var row = DataGridView.Rows[currentIndex];
			var id = int.Parse(row.Cells[3].Value.ToString());
			var idBook = int.Parse(row.Cells[4].Value.ToString());
			var book = service.FindBook(idBook);
			book.Copies += 1;
			service.UpdateBook(book);
			service.DeleteReturnedBook(id);
			ClearLabels();
			DisplayBooks();
			admin.DisplayBooks();
		}

		private void ClearLabels()
		{
			currentIndex = 1;
			TitleLabel.Text = "Title: ";
			AuthorLabel.Text = "Author: ";
			UserLabel.Text = "User: ";
		}

		private void PopulateLabels()
		{
			var row = DataGridView.Rows[currentIndex];
			TitleLabel.Text ="Title: "+ row.Cells[0].Value.ToString();
			AuthorLabel.Text ="Author: "+ row.Cells[1].Value.ToString();
			UserLabel.Text ="User: "+ row.Cells[2].Value.ToString();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			ClearLabels();
			Hide();
		}

		private void ReturnedBooksForm_Load(object sender, EventArgs e)
		{

		}

		private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			currentIndex = e.RowIndex;
			PopulateLabels();
		}

		private void ReturnedBooksForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
		}
	}
}
