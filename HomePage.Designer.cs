
namespace MtiExamSystem
{
	partial class HomePage
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.welcomeLabel = new System.Windows.Forms.Label();
			this.newExamButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Controls.Add(this.newExamButton);
			this.panel2.Controls.Add(this.welcomeLabel);
			this.panel2.Location = new System.Drawing.Point(7, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(764, 63);
			this.panel2.TabIndex = 0;
			// 
			// welcomeLabel
			// 
			this.welcomeLabel.AutoSize = true;
			this.welcomeLabel.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.welcomeLabel.ForeColor = System.Drawing.SystemColors.GrayText;
			this.welcomeLabel.Location = new System.Drawing.Point(11, 15);
			this.welcomeLabel.Name = "welcomeLabel";
			this.welcomeLabel.Size = new System.Drawing.Size(141, 32);
			this.welcomeLabel.TabIndex = 0;
			this.welcomeLabel.Text = "Welcome, ";
			// 
			// newExamButton
			// 
			this.newExamButton.BackColor = System.Drawing.Color.RoyalBlue;
			this.newExamButton.FlatAppearance.BorderSize = 0;
			this.newExamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newExamButton.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newExamButton.ForeColor = System.Drawing.Color.White;
			this.newExamButton.Location = new System.Drawing.Point(627, 3);
			this.newExamButton.Name = "newExamButton";
			this.newExamButton.Size = new System.Drawing.Size(134, 57);
			this.newExamButton.TabIndex = 1;
			this.newExamButton.Text = "New Exam";
			this.newExamButton.UseVisualStyleBackColor = false;
			this.newExamButton.Visible = false;
			this.newExamButton.Click += new System.EventHandler(this.newExamButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(2, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(793, 455);
			this.panel1.TabIndex = 1;
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(797, 461);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "HomePage";
			this.Text = "HomePage";
			this.Load += new System.EventHandler(this.HomePage_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label welcomeLabel;
		private System.Windows.Forms.Button newExamButton;
		private System.Windows.Forms.Panel panel1;
	}
}