
namespace MtiExamSystem
{
	partial class NewExam
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewExam));
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.nameInput = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.startsAtTime = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.marksInput = new System.Windows.Forms.TextBox();
			this.addChoiceButton = new System.Windows.Forms.Button();
			this.choiceInput = new System.Windows.Forms.TextBox();
			this.optionsList = new System.Windows.Forms.ComboBox();
			this.multichoiceButton = new System.Windows.Forms.RadioButton();
			this.truefalseButton = new System.Windows.Forms.RadioButton();
			this.questionInput = new System.Windows.Forms.TextBox();
			this.newQuestionButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cascadia Code", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(209, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 46);
			this.label1.TabIndex = 6;
			this.label1.Text = "New Exam";
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(137, 403);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(365, 63);
			this.button1.TabIndex = 8;
			this.button1.Text = "Add Questions";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// nameInput
			// 
			this.nameInput.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nameInput.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameInput.Location = new System.Drawing.Point(179, 148);
			this.nameInput.Multiline = true;
			this.nameInput.Name = "nameInput";
			this.nameInput.Size = new System.Drawing.Size(323, 53);
			this.nameInput.TabIndex = 7;
			this.nameInput.Text = "Exam Name";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(179, 238);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(323, 53);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "45";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(74, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 32);
			this.label2.TabIndex = 10;
			this.label2.Text = "Name: ";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 241);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 32);
			this.label3.TabIndex = 11;
			this.label3.Text = "Duration:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.startsAtTime);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.nameInput);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(83, 14);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(591, 487);
			this.panel1.TabIndex = 12;
			// 
			// startsAtTime
			// 
			this.startsAtTime.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startsAtTime.Location = new System.Drawing.Point(179, 338);
			this.startsAtTime.Name = "startsAtTime";
			this.startsAtTime.Size = new System.Drawing.Size(323, 26);
			this.startsAtTime.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 334);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 32);
			this.label4.TabIndex = 13;
			this.label4.Text = "Starts At:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.questionInput);
			this.panel2.Controls.Add(this.newQuestionButton);
			this.panel2.Location = new System.Drawing.Point(12, 14);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(760, 504);
			this.panel2.TabIndex = 13;
			this.panel2.Visible = false;
			// 
			// panel4
			// 
			this.panel4.AutoScroll = true;
			this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
			this.panel4.Location = new System.Drawing.Point(20, 186);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(727, 301);
			this.panel4.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel3.Controls.Add(this.marksInput);
			this.panel3.Controls.Add(this.addChoiceButton);
			this.panel3.Controls.Add(this.choiceInput);
			this.panel3.Controls.Add(this.optionsList);
			this.panel3.Controls.Add(this.multichoiceButton);
			this.panel3.Controls.Add(this.truefalseButton);
			this.panel3.Location = new System.Drawing.Point(20, 63);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(727, 57);
			this.panel3.TabIndex = 6;
			// 
			// marksInput
			// 
			this.marksInput.BackColor = System.Drawing.SystemColors.Menu;
			this.marksInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.marksInput.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.marksInput.Location = new System.Drawing.Point(194, 15);
			this.marksInput.Multiline = true;
			this.marksInput.Name = "marksInput";
			this.marksInput.Size = new System.Drawing.Size(54, 23);
			this.marksInput.TabIndex = 8;
			this.marksInput.Text = "5";
			this.marksInput.TextChanged += new System.EventHandler(this.marksInput_TextChanged);
			// 
			// addChoiceButton
			// 
			this.addChoiceButton.BackColor = System.Drawing.Color.RoyalBlue;
			this.addChoiceButton.FlatAppearance.BorderSize = 0;
			this.addChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addChoiceButton.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addChoiceButton.ForeColor = System.Drawing.Color.White;
			this.addChoiceButton.Location = new System.Drawing.Point(443, 14);
			this.addChoiceButton.Name = "addChoiceButton";
			this.addChoiceButton.Size = new System.Drawing.Size(79, 23);
			this.addChoiceButton.TabIndex = 7;
			this.addChoiceButton.Text = "Add";
			this.addChoiceButton.UseVisualStyleBackColor = false;
			this.addChoiceButton.Click += new System.EventHandler(this.addChoiceButton_Click);
			// 
			// choiceInput
			// 
			this.choiceInput.BackColor = System.Drawing.SystemColors.Menu;
			this.choiceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.choiceInput.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.choiceInput.Location = new System.Drawing.Point(254, 15);
			this.choiceInput.Multiline = true;
			this.choiceInput.Name = "choiceInput";
			this.choiceInput.Size = new System.Drawing.Size(183, 23);
			this.choiceInput.TabIndex = 7;
			this.choiceInput.Text = "Choice 1";
			// 
			// optionsList
			// 
			this.optionsList.FormattingEnabled = true;
			this.optionsList.Location = new System.Drawing.Point(540, 15);
			this.optionsList.Name = "optionsList";
			this.optionsList.Size = new System.Drawing.Size(171, 23);
			this.optionsList.TabIndex = 6;
			this.optionsList.Text = "Answer";
			// 
			// multichoiceButton
			// 
			this.multichoiceButton.AutoSize = true;
			this.multichoiceButton.Checked = true;
			this.multichoiceButton.Location = new System.Drawing.Point(3, 17);
			this.multichoiceButton.Name = "multichoiceButton";
			this.multichoiceButton.Size = new System.Drawing.Size(91, 19);
			this.multichoiceButton.TabIndex = 4;
			this.multichoiceButton.TabStop = true;
			this.multichoiceButton.Text = "Multichoice";
			this.multichoiceButton.UseVisualStyleBackColor = true;
			// 
			// truefalseButton
			// 
			this.truefalseButton.AutoSize = true;
			this.truefalseButton.Location = new System.Drawing.Point(109, 17);
			this.truefalseButton.Name = "truefalseButton";
			this.truefalseButton.Size = new System.Drawing.Size(79, 19);
			this.truefalseButton.TabIndex = 5;
			this.truefalseButton.Text = "TrueFalse";
			this.truefalseButton.UseVisualStyleBackColor = true;
			this.truefalseButton.CheckedChanged += new System.EventHandler(this.truefalseButton_CheckedChanged);
			// 
			// questionInput
			// 
			this.questionInput.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.questionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
			this.questionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.questionInput.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.questionInput.Location = new System.Drawing.Point(20, 13);
			this.questionInput.Multiline = true;
			this.questionInput.Name = "questionInput";
			this.questionInput.Size = new System.Drawing.Size(727, 44);
			this.questionInput.TabIndex = 3;
			this.questionInput.Text = "Question title";
			// 
			// newQuestionButton
			// 
			this.newQuestionButton.BackColor = System.Drawing.Color.RoyalBlue;
			this.newQuestionButton.FlatAppearance.BorderSize = 0;
			this.newQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newQuestionButton.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newQuestionButton.ForeColor = System.Drawing.Color.White;
			this.newQuestionButton.Location = new System.Drawing.Point(250, 126);
			this.newQuestionButton.Name = "newQuestionButton";
			this.newQuestionButton.Size = new System.Drawing.Size(270, 44);
			this.newQuestionButton.TabIndex = 2;
			this.newQuestionButton.Text = "Add Question";
			this.newQuestionButton.UseVisualStyleBackColor = false;
			this.newQuestionButton.Click += new System.EventHandler(this.newQuestionButton_Click);
			// 
			// NewExam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 532);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NewExam";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewExam";
			this.Load += new System.EventHandler(this.NewExam_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox nameInput;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button newQuestionButton;
		private System.Windows.Forms.TextBox questionInput;
		private System.Windows.Forms.RadioButton truefalseButton;
		private System.Windows.Forms.RadioButton multichoiceButton;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox choiceInput;
		private System.Windows.Forms.ComboBox optionsList;
		private System.Windows.Forms.Button addChoiceButton;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DateTimePicker startsAtTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox marksInput;
	}
}