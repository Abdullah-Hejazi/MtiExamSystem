using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtiExamSystem
{
	public partial class NewExam : Form
	{
		int examId = 0;

		public NewExam()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
			{
				MessageBox.Show("Only numbers are allowed !");
				textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
			}
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			if (nameInput.Text.Length == 0 || textBox1.Text.Length == 0) {
				MessageBox.Show("Can't add questions until you fill in the exam data !");
				return;
			}

			var startTime = startsAtTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
			var result = await ExamSystemAPI.GetInstance().NewExam(nameInput.Text, int.Parse(textBox1.Text), startTime);

			if (result == -1) {
				MessageBox.Show("Error adding new exam !");
				return;
			}

			examId = result;

			panel1.Hide();
			panel2.Visible = true;
		}

		private void truefalseButton_CheckedChanged(object sender, EventArgs e)
		{
			bool isChecked = truefalseButton.Checked;
			if (isChecked)
			{
				optionsList.Items.Clear();
				optionsList.Items.Add("true");
				optionsList.Items.Add("false");
				addChoiceButton.Hide();
				choiceInput.Hide();
			}
			else {
				optionsList.Items.Clear();
				addChoiceButton.Show();
				choiceInput.Show();
			}
		}

		private void addChoiceButton_Click(object sender, EventArgs e)
		{
			if (choiceInput.Text.Length == 0) {
				MessageBox.Show("Please fill in the choice input");
				return;
			}

			optionsList.Items.Add(choiceInput.Text);
			choiceInput.Text = "";
		}

		private async void newQuestionButton_Click(object sender, EventArgs e)
		{
			if (marksInput.Text.Length == 0)
			{
				MessageBox.Show("Please enter the marks for this question");
			}
			if (questionInput.Text.Length == 0)
			{
				MessageBox.Show("Enter the question title !");
				return;
			}
			if (optionsList.Items.Count == 0)
			{
				MessageBox.Show("There needs to be choices !");
				return;
			}

			if (optionsList.SelectedIndex < 0)
			{
				MessageBox.Show("You need to select an answer !");
				return;
			}

			String options = "[";

			foreach (var item in optionsList.Items)
			{
				options += '"' + item.ToString() + '"' + ",";
			}


			options = options.Remove(options.Length - 1);
			options += "]";

			String type = truefalseButton.Checked ? "truefalse" : "multichoice";
			var addQuestion = await ExamSystemAPI.GetInstance().AddQuestion(examId, questionInput.Text, optionsList.SelectedItem.ToString(), options, type, marksInput.Text);
			if (addQuestion)
			{
				MessageBox.Show("Question added successfully");
			}
			else
			{
				MessageBox.Show("Something went wrong when adding the question !");
			}
		}

		private void NewExam_Load(object sender, EventArgs e)
		{
			startsAtTime.Format = DateTimePickerFormat.Custom;
			startsAtTime.CustomFormat = "yyyy-MM-dd hh:mm:ss";
		}

		private void marksInput_TextChanged(object sender, EventArgs e)
		{
			if (System.Text.RegularExpressions.Regex.IsMatch(marksInput.Text, "[^0-9]"))
			{
				MessageBox.Show("Only numbers are allowed !");
				marksInput.Text = marksInput.Text.Remove(marksInput.Text.Length - 1);
			}
		}
	}
}
