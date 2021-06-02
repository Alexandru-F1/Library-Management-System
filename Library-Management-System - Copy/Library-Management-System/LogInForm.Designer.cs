
namespace Library_Management_System
{
	partial class LogInForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SingUpButton = new System.Windows.Forms.Button();
			this.LogInButton = new System.Windows.Forms.Button();
			this.LogInAdminButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// UsernameLabel
			// 
			this.UsernameLabel.AutoSize = true;
			this.UsernameLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameLabel.Location = new System.Drawing.Point(182, 32);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(113, 25);
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "Username";
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(182, 109);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(108, 25);
			this.PasswordLabel.TabIndex = 1;
			this.PasswordLabel.Text = "Password";
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UsernameTextBox.Location = new System.Drawing.Point(182, 60);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(237, 30);
			this.UsernameTextBox.TabIndex = 2;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordTextBox.Location = new System.Drawing.Point(182, 137);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(237, 30);
			this.PasswordTextBox.TabIndex = 3;
			// 
			// SingUpButton
			// 
			this.SingUpButton.BackColor = System.Drawing.Color.White;
			this.SingUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SingUpButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SingUpButton.Location = new System.Drawing.Point(306, 196);
			this.SingUpButton.Name = "SingUpButton";
			this.SingUpButton.Size = new System.Drawing.Size(113, 33);
			this.SingUpButton.TabIndex = 4;
			this.SingUpButton.Text = "Sing Up";
			this.SingUpButton.UseVisualStyleBackColor = false;
			// 
			// LogInButton
			// 
			this.LogInButton.BackColor = System.Drawing.Color.White;
			this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.LogInButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LogInButton.Location = new System.Drawing.Point(182, 196);
			this.LogInButton.Name = "LogInButton";
			this.LogInButton.Size = new System.Drawing.Size(113, 33);
			this.LogInButton.TabIndex = 5;
			this.LogInButton.Text = "Log In";
			this.LogInButton.UseVisualStyleBackColor = false;
			// 
			// LogInAdminButton
			// 
			this.LogInAdminButton.BackColor = System.Drawing.Color.White;
			this.LogInAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.LogInAdminButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LogInAdminButton.Location = new System.Drawing.Point(232, 244);
			this.LogInAdminButton.Name = "LogInAdminButton";
			this.LogInAdminButton.Size = new System.Drawing.Size(143, 33);
			this.LogInAdminButton.TabIndex = 6;
			this.LogInAdminButton.Text = "Log In Admin";
			this.LogInAdminButton.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.LogInBackground;
			this.pictureBox1.Location = new System.Drawing.Point(5, -51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(528, 378);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// LogInForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(506, 317);
			this.Controls.Add(this.LogInAdminButton);
			this.Controls.Add(this.LogInButton);
			this.Controls.Add(this.SingUpButton);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "LogInForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label UsernameLabel;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button SingUpButton;
		private System.Windows.Forms.Button LogInButton;
		private System.Windows.Forms.Button LogInAdminButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

