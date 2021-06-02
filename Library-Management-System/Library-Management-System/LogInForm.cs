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
	public partial class LogInForm : Form
	{
		private IService service;

		public LogInForm(IService service)
		{
			this.service = service;
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void LogInButton_Click(object sender, EventArgs e)
		{
			var username = UsernameTextBox.Text;
			var password = PasswordTextBox.Text;

			if (username == "" || password == "")
			{
				MessageBox.Show("Username or password are null!");
			}
			else
			{
				var subscriber = service.LogInSubscriber(username, password);
				if (subscriber != null)
				{
					Hide();
					var mainForm = new MainForm(service, subscriber.Id);
					mainForm.Show();
				}
				else
				{
					MessageBox.Show("Username or password are inccorect!");
				}
			}
		}

		private void SingUpButton_Click(object sender, EventArgs e)
		{
			var registerForm = new RegisterForm(service);
			registerForm.Show();
		}

		private void LogInAdminButton_Click(object sender, EventArgs e)
		{
			var username = UsernameTextBox.Text;
			var password = PasswordTextBox.Text;

			if (username == "" || password == "")
			{
				MessageBox.Show("Username or password are null!");
			}
			else
			{
				var librarian = service.LogInAdmin(username, password);
				if(librarian!=null)
				{
					Hide();
					var adminForm = new AdminForm(service);
					adminForm.Show();
				}
				else
				{
					MessageBox.Show("Username or password are inccorect!");
				}
			}
		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
