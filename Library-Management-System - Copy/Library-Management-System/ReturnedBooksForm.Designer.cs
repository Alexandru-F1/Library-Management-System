
namespace Library_Management_System
{
	partial class ReturnedBooksForm
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
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.UserLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
			this.DetailsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// BooksDataGridView
			// 
			this.BooksDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.User});
			this.BooksDataGridView.GridColor = System.Drawing.Color.White;
			this.BooksDataGridView.Location = new System.Drawing.Point(18, 12);
			this.BooksDataGridView.Name = "BooksDataGridView";
			this.BooksDataGridView.RowTemplate.Height = 25;
			this.BooksDataGridView.Size = new System.Drawing.Size(347, 236);
			this.BooksDataGridView.TabIndex = 0;
			// 
			// Title
			// 
			this.Title.HeaderText = "Title";
			this.Title.Name = "Title";
			// 
			// Author
			// 
			this.Author.HeaderText = "Author";
			this.Author.Name = "Author";
			// 
			// User
			// 
			this.User.HeaderText = "User";
			this.User.Name = "User";
			// 
			// DetailsGroupBox
			// 
			this.DetailsGroupBox.Controls.Add(this.UserLabel);
			this.DetailsGroupBox.Controls.Add(this.AuthorLabel);
			this.DetailsGroupBox.Controls.Add(this.TitleLabel);
			this.DetailsGroupBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DetailsGroupBox.Location = new System.Drawing.Point(384, 12);
			this.DetailsGroupBox.Name = "DetailsGroupBox";
			this.DetailsGroupBox.Size = new System.Drawing.Size(309, 165);
			this.DetailsGroupBox.TabIndex = 1;
			this.DetailsGroupBox.TabStop = false;
			this.DetailsGroupBox.Text = "Details";
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = new System.Drawing.Point(22, 40);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(55, 23);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title:";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Location = new System.Drawing.Point(22, 78);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(77, 23);
			this.AuthorLabel.TabIndex = 1;
			this.AuthorLabel.Text = "Author:";
			// 
			// UserLabel
			// 
			this.UserLabel.AutoSize = true;
			this.UserLabel.Location = new System.Drawing.Point(22, 115);
			this.UserLabel.Name = "UserLabel";
			this.UserLabel.Size = new System.Drawing.Size(56, 23);
			this.UserLabel.TabIndex = 2;
			this.UserLabel.Text = "User:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(416, 201);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 47);
			this.button1.TabIndex = 2;
			this.button1.Text = "Confirm";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.White;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CloseButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CloseButton.Location = new System.Drawing.Point(567, 201);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(108, 46);
			this.CloseButton.TabIndex = 3;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = false;
			// 
			// ReturnedBooksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(714, 278);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DetailsGroupBox);
			this.Controls.Add(this.BooksDataGridView);
			this.Name = "ReturnedBooksForm";
			this.Text = "ReturnedBooksForm";
			((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
			this.DetailsGroupBox.ResumeLayout(false);
			this.DetailsGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView BooksDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn Author;
		private System.Windows.Forms.DataGridViewTextBoxColumn User;
		private System.Windows.Forms.GroupBox DetailsGroupBox;
		private System.Windows.Forms.Label UserLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button CloseButton;
	}
}