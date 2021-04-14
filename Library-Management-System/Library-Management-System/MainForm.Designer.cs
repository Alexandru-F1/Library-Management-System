
namespace Library_Management_System
{
	partial class MainForm
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
			this.AllBooksButton = new System.Windows.Forms.Button();
			this.ReservedBooksButton = new System.Windows.Forms.Button();
			this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.CopiesLabel = new System.Windows.Forms.Label();
			this.RatingLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.BorrowedBooksButton = new System.Windows.Forms.Button();
			this.BorrowBookButton = new System.Windows.Forms.Button();
			this.ReserveButton = new System.Windows.Forms.Button();
			this.CancelReservationButton = new System.Windows.Forms.Button();
			this.ReturnBookButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
			this.DetailsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// BooksDataGridView
			// 
			this.BooksDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.Rating,
            this.Copies});
			this.BooksDataGridView.Location = new System.Drawing.Point(12, 83);
			this.BooksDataGridView.Name = "BooksDataGridView";
			this.BooksDataGridView.ReadOnly = true;
			this.BooksDataGridView.RowTemplate.Height = 25;
			this.BooksDataGridView.Size = new System.Drawing.Size(450, 375);
			this.BooksDataGridView.TabIndex = 0;
			this.BooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksDataGridView_CellContentClick);
			// 
			// AllBooksButton
			// 
			this.AllBooksButton.BackColor = System.Drawing.Color.White;
			this.AllBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AllBooksButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AllBooksButton.Location = new System.Drawing.Point(149, 12);
			this.AllBooksButton.Name = "AllBooksButton";
			this.AllBooksButton.Size = new System.Drawing.Size(152, 29);
			this.AllBooksButton.TabIndex = 1;
			this.AllBooksButton.Text = "All Books";
			this.AllBooksButton.UseVisualStyleBackColor = false;
			// 
			// ReservedBooksButton
			// 
			this.ReservedBooksButton.BackColor = System.Drawing.Color.White;
			this.ReservedBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ReservedBooksButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ReservedBooksButton.Location = new System.Drawing.Point(234, 47);
			this.ReservedBooksButton.Name = "ReservedBooksButton";
			this.ReservedBooksButton.Size = new System.Drawing.Size(228, 30);
			this.ReservedBooksButton.TabIndex = 2;
			this.ReservedBooksButton.Text = "Reserved Books";
			this.ReservedBooksButton.UseVisualStyleBackColor = false;
			// 
			// DetailsGroupBox
			// 
			this.DetailsGroupBox.Controls.Add(this.CopiesLabel);
			this.DetailsGroupBox.Controls.Add(this.RatingLabel);
			this.DetailsGroupBox.Controls.Add(this.AuthorLabel);
			this.DetailsGroupBox.Controls.Add(this.TitleLabel);
			this.DetailsGroupBox.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DetailsGroupBox.Location = new System.Drawing.Point(484, 26);
			this.DetailsGroupBox.Name = "DetailsGroupBox";
			this.DetailsGroupBox.Size = new System.Drawing.Size(384, 213);
			this.DetailsGroupBox.TabIndex = 3;
			this.DetailsGroupBox.TabStop = false;
			this.DetailsGroupBox.Text = "Details";
			// 
			// CopiesLabel
			// 
			this.CopiesLabel.AutoSize = true;
			this.CopiesLabel.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CopiesLabel.Location = new System.Drawing.Point(20, 152);
			this.CopiesLabel.Name = "CopiesLabel";
			this.CopiesLabel.Size = new System.Drawing.Size(76, 23);
			this.CopiesLabel.TabIndex = 3;
			this.CopiesLabel.Text = "Copies:";
			// 
			// RatingLabel
			// 
			this.RatingLabel.AutoSize = true;
			this.RatingLabel.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RatingLabel.Location = new System.Drawing.Point(19, 114);
			this.RatingLabel.Name = "RatingLabel";
			this.RatingLabel.Size = new System.Drawing.Size(73, 23);
			this.RatingLabel.TabIndex = 2;
			this.RatingLabel.Text = "Rating:";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.AuthorLabel.Location = new System.Drawing.Point(20, 74);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(77, 23);
			this.AuthorLabel.TabIndex = 1;
			this.AuthorLabel.Text = "Author:";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TitleLabel.Location = new System.Drawing.Point(20, 38);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(55, 23);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title:";
			// 
			// BorrowedBooksButton
			// 
			this.BorrowedBooksButton.BackColor = System.Drawing.Color.White;
			this.BorrowedBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BorrowedBooksButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BorrowedBooksButton.Location = new System.Drawing.Point(12, 47);
			this.BorrowedBooksButton.Name = "BorrowedBooksButton";
			this.BorrowedBooksButton.Size = new System.Drawing.Size(216, 30);
			this.BorrowedBooksButton.TabIndex = 6;
			this.BorrowedBooksButton.Text = "Borrowed Books";
			this.BorrowedBooksButton.UseVisualStyleBackColor = false;
			// 
			// BorrowBookButton
			// 
			this.BorrowBookButton.BackColor = System.Drawing.Color.White;
			this.BorrowBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BorrowBookButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BorrowBookButton.Location = new System.Drawing.Point(484, 269);
			this.BorrowBookButton.Name = "BorrowBookButton";
			this.BorrowBookButton.Size = new System.Drawing.Size(111, 39);
			this.BorrowBookButton.TabIndex = 4;
			this.BorrowBookButton.Text = "Borrow";
			this.BorrowBookButton.UseVisualStyleBackColor = false;
			// 
			// ReserveButton
			// 
			this.ReserveButton.BackColor = System.Drawing.Color.White;
			this.ReserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ReserveButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ReserveButton.Location = new System.Drawing.Point(625, 269);
			this.ReserveButton.Name = "ReserveButton";
			this.ReserveButton.Size = new System.Drawing.Size(109, 40);
			this.ReserveButton.TabIndex = 5;
			this.ReserveButton.Text = "Reserve";
			this.ReserveButton.UseVisualStyleBackColor = false;
			// 
			// CancelReservationButton
			// 
			this.CancelReservationButton.BackColor = System.Drawing.Color.White;
			this.CancelReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CancelReservationButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CancelReservationButton.Location = new System.Drawing.Point(571, 328);
			this.CancelReservationButton.Name = "CancelReservationButton";
			this.CancelReservationButton.Size = new System.Drawing.Size(201, 41);
			this.CancelReservationButton.TabIndex = 7;
			this.CancelReservationButton.Text = "Cancel Reservation";
			this.CancelReservationButton.UseVisualStyleBackColor = false;
			// 
			// ReturnBookButton
			// 
			this.ReturnBookButton.BackColor = System.Drawing.Color.White;
			this.ReturnBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ReturnBookButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ReturnBookButton.Location = new System.Drawing.Point(758, 269);
			this.ReturnBookButton.Name = "ReturnBookButton";
			this.ReturnBookButton.Size = new System.Drawing.Size(110, 39);
			this.ReturnBookButton.TabIndex = 8;
			this.ReturnBookButton.Text = "Return";
			this.ReturnBookButton.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Library_Management_System.Properties.Resources.BookLeft1;
			this.pictureBox1.Location = new System.Drawing.Point(468, 314);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(98, 143);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Library_Management_System.Properties.Resources.BookRight1;
			this.pictureBox2.Location = new System.Drawing.Point(778, 314);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(98, 143);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// Title
			// 
			this.Title.HeaderText = "Title";
			this.Title.Name = "Title";
			this.Title.ReadOnly = true;
			// 
			// Author
			// 
			this.Author.HeaderText = "Author";
			this.Author.Name = "Author";
			this.Author.ReadOnly = true;
			// 
			// Rating
			// 
			this.Rating.HeaderText = "Rating";
			this.Rating.Name = "Rating";
			this.Rating.ReadOnly = true;
			// 
			// Copies
			// 
			this.Copies.HeaderText = " Copies";
			this.Copies.Name = "Copies";
			this.Copies.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(889, 469);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ReturnBookButton);
			this.Controls.Add(this.CancelReservationButton);
			this.Controls.Add(this.ReserveButton);
			this.Controls.Add(this.BorrowBookButton);
			this.Controls.Add(this.BorrowedBooksButton);
			this.Controls.Add(this.DetailsGroupBox);
			this.Controls.Add(this.ReservedBooksButton);
			this.Controls.Add(this.AllBooksButton);
			this.Controls.Add(this.BooksDataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
			this.DetailsGroupBox.ResumeLayout(false);
			this.DetailsGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView BooksDataGridView;
		private System.Windows.Forms.Button AllBooksButton;
		private System.Windows.Forms.Button ReservedBooksButton;
		private System.Windows.Forms.GroupBox DetailsGroupBox;
		private System.Windows.Forms.Label CopiesLabel;
		private System.Windows.Forms.Label RatingLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Button BorrowedBooksButton;
		private System.Windows.Forms.Button BorrowBookButton;
		private System.Windows.Forms.Button ReserveButton;
		private System.Windows.Forms.Button CancelReservationButton;
		private System.Windows.Forms.Button ReturnBookButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn Author;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
		private System.Windows.Forms.DataGridViewTextBoxColumn Copies;
	}
}