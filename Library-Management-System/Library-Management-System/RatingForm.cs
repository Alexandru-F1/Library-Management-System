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
	public partial class RatingForm : Form
	{
		private IService service;
		private int idBook;


		public RatingForm(IService service, int idBook)
		{
			InitializeComponent();
			this.service = service;
			this.idBook = idBook;
		}

		private void ConfirmButton_Click(object sender, EventArgs e)
		{
			if (RatingtextBox.Text != "")
			{
				try
				{
					var rating = int.Parse(RatingtextBox.Text);
					if(rating>0 && rating<6)
					{
						service.AddRatingBook(idBook, rating);
						Hide();
					}
					else
					{
						MessageBox.Show("Invalid Rating, you need to choose a rating between 1 and 5!");

					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			else
			{
				MessageBox.Show("You should give a rating before pressing Confirm!");
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
