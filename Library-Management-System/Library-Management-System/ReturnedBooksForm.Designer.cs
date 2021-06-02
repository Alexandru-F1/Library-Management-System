
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
			this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.UserLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.DataGridView = new System.Windows.Forms.DataGridView();
			this.DetailsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
			this.SuspendLayout();
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
			// UserLabel
			// 
			this.UserLabel.AutoSize = true;
			this.UserLabel.Location = new System.Drawing.Point(22, 115);
			this.UserLabel.Name = "UserLabel";
			this.UserLabel.Size = new System.Drawing.Size(56, 23);
			this.UserLabel.TabIndex = 2;
			this.UserLabel.Text = "User:";
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
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = new System.Drawing.Point(22, 40);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(55, 23);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "Title:";
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
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// DataGridView
			// 
			this.DataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.DataGridView.Location = new System.Drawing.Point(12, 12);
			this.DataGridView.Name = "DataGridView";
			this.DataGridView.RowTemplate.Height = 25;
			this.DataGridView.Size = new System.Drawing.Size(366, 236);
			this.DataGridView.TabIndex = 4;
			this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
			this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
			// 
			// ReturnedBooksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(714, 278);
			this.Controls.Add(this.DataGridView);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DetailsGroupBox);
			this.Name = "ReturnedBooksForm";
			this.Text = "ReturnedBooksForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnedBooksForm_FormClosing);
			this.Load += new System.EventHandler(this.ReturnedBooksForm_Load);
			this.DetailsGroupBox.ResumeLayout(false);
			this.DetailsGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox DetailsGroupBox;
		private System.Windows.Forms.Label UserLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.DataGridView DataGridView;
	}
}