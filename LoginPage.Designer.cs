
namespace MtiExamSystem
{
	partial class LoginPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
			this.passwordInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.emailInput = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.loading = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// passwordInput
			// 
			this.passwordInput.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordInput.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordInput.Location = new System.Drawing.Point(288, 219);
			this.passwordInput.Multiline = true;
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.PasswordChar = '*';
			this.passwordInput.Size = new System.Drawing.Size(267, 48);
			this.passwordInput.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cascadia Code", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(310, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 46);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login";
			// 
			// emailInput
			// 
			this.emailInput.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.emailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.emailInput.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailInput.Location = new System.Drawing.Point(288, 143);
			this.emailInput.Multiline = true;
			this.emailInput.Name = "emailInput";
			this.emailInput.Size = new System.Drawing.Size(267, 48);
			this.emailInput.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(221, 301);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(334, 51);
			this.button1.TabIndex = 5;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// loading
			// 
			this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.loading.Image = global::MtiExamSystem.Properties.Resources._1;
			this.loading.Location = new System.Drawing.Point(164, 67);
			this.loading.Name = "loading";
			this.loading.Size = new System.Drawing.Size(452, 297);
			this.loading.TabIndex = 6;
			this.loading.TabStop = false;
			this.loading.Visible = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
			this.pictureBox2.Image = global::MtiExamSystem.Properties.Resources.iconfinder_lock_24_103178;
			this.pictureBox2.Location = new System.Drawing.Point(221, 219);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(67, 48);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.Image = global::MtiExamSystem.Properties.Resources.iconfinder_icon_email_211660__1_;
			this.pictureBox1.Location = new System.Drawing.Point(221, 143);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(784, 430);
			this.Controls.Add(this.loading);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.passwordInput);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.emailInput);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exam System - LoginPage";
			this.Load += new System.EventHandler(this.LoginPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox passwordInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox emailInput;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox loading;
	}
}