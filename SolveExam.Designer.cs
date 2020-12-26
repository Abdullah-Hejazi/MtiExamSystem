
namespace MtiExamSystem
{
	partial class SolveExam
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolveExam));
			this.questionsPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.submitAnswersButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// questionsPanel
			// 
			this.questionsPanel.Location = new System.Drawing.Point(12, 50);
			this.questionsPanel.Name = "questionsPanel";
			this.questionsPanel.Size = new System.Drawing.Size(760, 399);
			this.questionsPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Questions";
			// 
			// submitAnswersButton
			// 
			this.submitAnswersButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.submitAnswersButton.BackColor = System.Drawing.Color.RoyalBlue;
			this.submitAnswersButton.FlatAppearance.BorderSize = 0;
			this.submitAnswersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.submitAnswersButton.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitAnswersButton.ForeColor = System.Drawing.Color.White;
			this.submitAnswersButton.Location = new System.Drawing.Point(660, 9);
			this.submitAnswersButton.Name = "submitAnswersButton";
			this.submitAnswersButton.Size = new System.Drawing.Size(112, 32);
			this.submitAnswersButton.TabIndex = 6;
			this.submitAnswersButton.Text = "Submit Answers";
			this.submitAnswersButton.UseVisualStyleBackColor = false;
			this.submitAnswersButton.Click += new System.EventHandler(this.submitAnswersButton_Click);
			// 
			// SolveExam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 461);
			this.Controls.Add(this.submitAnswersButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.questionsPanel);
			this.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SolveExam";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SolveExam";
			this.Load += new System.EventHandler(this.SolveExam_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel questionsPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button submitAnswersButton;
	}
}