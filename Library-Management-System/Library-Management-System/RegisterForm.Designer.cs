
namespace Library_Management_System
{
	partial class RegisterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SingUpButton = new System.Windows.Forms.Button();
			this.CreateNewUserLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameLabel.Location = new System.Drawing.Point(70, 83);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(113, 25);
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "Username";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(70, 153);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(108, 25);
			this.PasswordLabel.TabIndex = 1;
			this.PasswordLabel.Text = "Password";
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameTextBox.Location = new System.Drawing.Point(70, 111);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(236, 30);
			this.UsernameTextBox.TabIndex = 3;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordTextBox.Location = new System.Drawing.Point(70, 181);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(236, 30);
			this.PasswordTextBox.TabIndex = 4;
			// 
			// CancelButton
			// 
			this.CancelButton.BackColor = System.Drawing.Color.White;
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CancelButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CancelButton.Location = new System.Drawing.Point(79, 314);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(90, 38);
			this.CancelButton.TabIndex = 6;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// SingUpButton
			// 
			this.SingUpButton.BackColor = System.Drawing.Color.White;
			this.SingUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SingUpButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SingUpButton.Location = new System.Drawing.Point(197, 314);
			this.SingUpButton.Name = "SingUpButton";
			this.SingUpButton.Size = new System.Drawing.Size(90, 38);
			this.SingUpButton.TabIndex = 7;
			this.SingUpButton.Text = "Sing Up";
			this.SingUpButton.UseVisualStyleBackColor = false;
			this.SingUpButton.Click += new System.EventHandler(this.SingUpButton_Click);
			// 
			// CreateNewUserLabel
			// 
			this.CreateNewUserLabel.AutoSize = true;
			this.CreateNewUserLabel.Font = new System.Drawing.Font("Rubik", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CreateNewUserLabel.Location = new System.Drawing.Point(43, 24);
			this.CreateNewUserLabel.Name = "CreateNewUserLabel";
			this.CreateNewUserLabel.Size = new System.Drawing.Size(285, 42);
			this.CreateNewUserLabel.TabIndex = 8;
			this.CreateNewUserLabel.Text = "Create new User";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NameLabel.Location = new System.Drawing.Point(70, 227);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(69, 25);
			this.NameLabel.TabIndex = 2;
			this.NameLabel.Text = "Name";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NameTextBox.Location = new System.Drawing.Point(70, 255);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(236, 30);
			this.NameTextBox.TabIndex = 5;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(377, 381);
			this.Controls.Add(this.CreateNewUserLabel);
			this.Controls.Add(this.SingUpButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button SingUpButton;
		private System.Windows.Forms.Label CreateNewUserLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameTextBox;
	}
}