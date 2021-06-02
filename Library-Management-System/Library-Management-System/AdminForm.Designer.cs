
namespace Library_Management_System
{
	partial class AdminForm
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
			this.BooksDataGridView = new System.Windows.Forms.DataGridView();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.AuthorTextBox = new System.Windows.Forms.TextBox();
			this.RatingTextBox = new System.Windows.Forms.TextBox();
			this.CopiesTextBox = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.ReturnedBooksButton = new System.Windows.Forms.Button();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.RatingLabel = new System.Windows.Forms.Label();
			this.CopiesLabel = new System.Windows.Forms.Label();
			this.DetailsLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// BooksDataGridView
			// 
			this.BooksDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BooksDataGridView.Location = new System.Drawing.Point(10, 67);
			this.BooksDataGridView.Name = "BooksDataGridView";
			this.BooksDataGridView.ReadOnly = true;
			this.BooksDataGridView.RowTemplate.Height = 25;
			this.BooksDataGridView.Size = new System.Drawing.Size(451, 376);
			this.BooksDataGridView.TabIndex = 0;
			this.BooksDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellClick);
			this.BooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellContentClick);
			// 
			// TitleTextBox
			// 
			this.TitleTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TitleTextBox.Location = new System.Drawing.Point(477, 95);
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.Size = new System.Drawing.Size(268, 30);
			this.TitleTextBox.TabIndex = 1;
			// 
			// AuthorTextBox
			// 
			this.AuthorTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AuthorTextBox.Location = new System.Drawing.Point(477, 166);
			this.AuthorTextBox.Name = "AuthorTextBox";
			this.AuthorTextBox.Size = new System.Drawing.Size(268, 30);
			this.AuthorTextBox.TabIndex = 2;
			// 
			// RatingTextBox
			// 
			this.RatingTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RatingTextBox.Location = new System.Drawing.Point(477, 236);
			this.RatingTextBox.Name = "RatingTextBox";
			this.RatingTextBox.Size = new System.Drawing.Size(268, 30);
			this.RatingTextBox.TabIndex = 3;
			// 
			// CopiesTextBox
			// 
			this.CopiesTextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CopiesTextBox.Location = new System.Drawing.Point(477, 306);
			this.CopiesTextBox.Name = "CopiesTextBox";
			this.CopiesTextBox.Size = new System.Drawing.Size(268, 30);
			this.CopiesTextBox.TabIndex = 4;
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.White;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AddButton.Location = new System.Drawing.Point(477, 355);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(112, 41);
			this.AddButton.TabIndex = 5;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.BackColor = System.Drawing.Color.White;
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DeleteButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DeleteButton.Location = new System.Drawing.Point(551, 402);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(112, 41);
			this.DeleteButton.TabIndex = 6;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button3.Location = new System.Drawing.Point(633, 355);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 41);
			this.button3.TabIndex = 7;
			this.button3.Text = "Update";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ReturnedBooksButton
			// 
			this.ReturnedBooksButton.BackColor = System.Drawing.Color.White;
			this.ReturnedBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ReturnedBooksButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ReturnedBooksButton.Location = new System.Drawing.Point(130, 12);
			this.ReturnedBooksButton.Name = "ReturnedBooksButton";
			this.ReturnedBooksButton.Size = new System.Drawing.Size(215, 49);
			this.ReturnedBooksButton.TabIndex = 8;
			this.ReturnedBooksButton.Text = "View Returned Books";
			this.ReturnedBooksButton.UseVisualStyleBackColor = false;
			this.ReturnedBooksButton.Click += new System.EventHandler(this.button4_Click);
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TitleLabel.Location = new System.Drawing.Point(477, 67);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(54, 25);
			this.TitleLabel.TabIndex = 9;
			this.TitleLabel.Text = "Title";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AuthorLabel.Location = new System.Drawing.Point(477, 138);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(80, 25);
			this.AuthorLabel.TabIndex = 10;
			this.AuthorLabel.Text = "Author";
			this.AuthorLabel.Click += new System.EventHandler(this.AuthorLabel_Click);
			// 
			// RatingLabel
			// 
			this.RatingLabel.AutoSize = true;
			this.RatingLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RatingLabel.Location = new System.Drawing.Point(477, 208);
			this.RatingLabel.Name = "RatingLabel";
			this.RatingLabel.Size = new System.Drawing.Size(76, 25);
			this.RatingLabel.TabIndex = 11;
			this.RatingLabel.Text = "Rating";
			// 
			// CopiesLabel
			// 
			this.CopiesLabel.AutoSize = true;
			this.CopiesLabel.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CopiesLabel.Location = new System.Drawing.Point(481, 278);
			this.CopiesLabel.Name = "CopiesLabel";
			this.CopiesLabel.Size = new System.Drawing.Size(79, 25);
			this.CopiesLabel.TabIndex = 12;
			this.CopiesLabel.Text = "Copies";
			// 
			// DetailsLabel
			// 
			this.DetailsLabel.AutoSize = true;
			this.DetailsLabel.Font = new System.Drawing.Font("Rubik", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DetailsLabel.Location = new System.Drawing.Point(544, 13);
			this.DetailsLabel.Name = "DetailsLabel";
			this.DetailsLabel.Size = new System.Drawing.Size(119, 38);
			this.DetailsLabel.TabIndex = 13;
			this.DetailsLabel.Text = "Details";
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(765, 464);
			this.Controls.Add(this.DetailsLabel);
			this.Controls.Add(this.CopiesLabel);
			this.Controls.Add(this.RatingLabel);
			this.Controls.Add(this.AuthorLabel);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.ReturnedBooksButton);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.CopiesTextBox);
			this.Controls.Add(this.RatingTextBox);
			this.Controls.Add(this.AuthorTextBox);
			this.Controls.Add(this.TitleTextBox);
			this.Controls.Add(this.BooksDataGridView);
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView BooksDataGridView;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.TextBox AuthorTextBox;
		private System.Windows.Forms.TextBox RatingTextBox;
		private System.Windows.Forms.TextBox CopiesTextBox;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button ReturnedBooksButton;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label RatingLabel;
		private System.Windows.Forms.Label CopiesLabel;
		private System.Windows.Forms.Label DetailsLabel;
	}
}