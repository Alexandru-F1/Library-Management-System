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
	public partial class RegisterForm : Form
	{
		IService service;

		public RegisterForm(IService service)
		{
			InitializeComponent();
			this.service = service;
		}

		private void SingUpButton_Click(object sender, EventArgs e)
		{
			var username = UsernameTextBox.Text;
			var password = PasswordTextBox.Text;
			var name = NameTextBox.Text;

			var subscriber = new Subscriber(username, password, name);
			var existent = service.FindSubscriberUsername(username);
			if (existent)
			{
				service.AddSubscriber(subscriber);
				Hide();
				var logInForm = new LogInForm(service);
				logInForm.Show();
			}
			else
			{
				MessageBox.Show("Username taken!");
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Hide();
			var logInForm = new LogInForm(service);
			logInForm.Show();
		}
	}
}
