
namespace Library_Management_System
{
	partial class RatingForm
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
			this.RatingtextBox = new System.Windows.Forms.TextBox();
			this.RatingLabel = new System.Windows.Forms.Label();
			this.ConfirmButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RatingtextBox
			// 
			this.RatingtextBox.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RatingtextBox.Location = new System.Drawing.Point(29, 58);
			this.RatingtextBox.Name = "RatingtextBox";
			this.RatingtextBox.Size = new System.Drawing.Size(241, 30);
			this.RatingtextBox.TabIndex = 0;
			// 
			// RatingLabel
			// 
			this.RatingLabel.AutoSize = true;
			this.RatingLabel.Font = new System.Drawing.Font("Rubik", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RatingLabel.Location = new System.Drawing.Point(79, 18);
			this.RatingLabel.Name = "RatingLabel";
			this.RatingLabel.Size = new System.Drawing.Size(134, 28);
			this.RatingLabel.TabIndex = 1;
			this.RatingLabel.Text = "Rating: 1-5";
			// 
			// ConfirmButton
			// 
			this.ConfirmButton.BackColor = System.Drawing.Color.White;
			this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ConfirmButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ConfirmButton.Location = new System.Drawing.Point(29, 114);
			this.ConfirmButton.Name = "ConfirmButton";
			this.ConfirmButton.Size = new System.Drawing.Size(99, 39);
			this.ConfirmButton.TabIndex = 2;
			this.ConfirmButton.Text = "Confirm";
			this.ConfirmButton.UseVisualStyleBackColor = false;
			this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.BackColor = System.Drawing.Color.White;
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CancelButton.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CancelButton.Location = new System.Drawing.Point(171, 114);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(99, 39);
			this.CancelButton.TabIndex = 3;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// RatingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(295, 181);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ConfirmButton);
			this.Controls.Add(this.RatingLabel);
			this.Controls.Add(this.RatingtextBox);
			this.Name = "RatingForm";
			this.Text = "RatingForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox RatingtextBox;
		private System.Windows.Forms.Label RatingLabel;
		private System.Windows.Forms.Button ConfirmButton;
		private System.Windows.Forms.Button CancelButton;
	}
}