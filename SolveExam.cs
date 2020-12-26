using Newtonsoft.Json;
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
	public partial class SolveExam : Form
	{
		List<Dictionary<int, ComboBox>> answersLists = new List<Dictionary<int, ComboBox>>();

		public SolveExam()
		{
			InitializeComponent();
		}

		private async void SolveExam_Load(object sender, EventArgs e)
		{
			this.MaximizeBox = false;
			var result = await ExamSystemAPI.GetInstance().GetExam(HomePage.selectedExamId);
			int index = 0;


			foreach (var item in result) {
				Panel panel = new Panel();
				panel.Size = new Size(751, 73);
				panel.Location = new Point(4, (index * 80) + 90);
				panel.BackColor = Color.FromKnownColor(KnownColor.ButtonHighlight);


				Label questionTitle = new Label();
				questionTitle.Text = item["question"];
				questionTitle.Location = new Point(8, 7);
				questionTitle.Font = new Font(new FontFamily("Cascadia Code"), 12f, FontStyle.Regular);
				questionTitle.Size = new Size(600, 21);
				questionTitle.Visible = true;
				panel.Controls.Add(questionTitle);


				Label marksLabel = new Label();
				marksLabel.Text = item["marks"] + " Marks";
				marksLabel.Location = new Point(649, 7);
				marksLabel.Font = new Font(new FontFamily("Cascadia Code"), 12f, FontStyle.Regular);
				marksLabel.Size = new Size(83, 21);
				marksLabel.Visible = true;
				panel.Controls.Add(marksLabel);


				Label answerLabel = new Label();
				answerLabel.Text = "Your Answer: ";
				answerLabel.Location = new Point(8, 43);
				answerLabel.Font = new Font(new FontFamily("Cascadia Code"), 9f, FontStyle.Regular);
				answerLabel.Size = new Size(114, 17);
				answerLabel.Visible = true;
				panel.Controls.Add(answerLabel);

				ComboBox answersList = new ComboBox();
				answersList.Size = new Size(254, 23);
				answersList.Location = new Point(147, 40);
				answersList.Font = new Font(new FontFamily("Cascadia Code"), 12f, FontStyle.Regular);
				answersList.Visible = true;
				panel.Controls.Add(answersList);

				var options = JsonConvert.DeserializeObject< List<string> >(item["options"]);
				foreach (var option in options) {
					answersList.Items.Add(option);
				}

				answersLists.Add(new Dictionary<int, ComboBox> {
					{ int.Parse(item["id"]), answersList }
				});



				panel.Visible = true;

				questionsPanel.Controls.Add(panel);
				panel.Update();
				index++;

				questionsPanel.AutoScroll = false;
				questionsPanel.HorizontalScroll.Enabled = false;
				questionsPanel.HorizontalScroll.Visible = false;
				questionsPanel.HorizontalScroll.Maximum = 0;
				questionsPanel.AutoScroll = true;
			}
		}

		private async void submitAnswersButton_Click(object sender, EventArgs e)
		{
			int index = 0;
			foreach (var item in answersLists) {
				// MessageBox.Show(item.ElementAt(index).Value.SelectedItem.ToString());
				if (item.ElementAt(0).Value.SelectedIndex < 0) {
					MessageBox.Show("You need to select the answer for all the questions !!");
					return;
				}
				index++;
			}

			String jsonAnswers = "[";

			index = 0;
			foreach (var item in answersLists)
			{
				// MessageBox.Show(item.ElementAt(index).Value.SelectedItem.ToString());
				jsonAnswers += "{\"question_id\": " + item.ElementAt(0).Key + ",";
				jsonAnswers += "\"answer\": \"" + item.ElementAt(0).Value.SelectedItem.ToString() + "\"},";

				index++;
			}

			jsonAnswers = jsonAnswers.Remove(jsonAnswers.Length - 1);
			jsonAnswers += "]";

			var result = await ExamSystemAPI.GetInstance().SolveExam(HomePage.selectedExamId, jsonAnswers);

			if (result != -1) {
				MessageBox.Show("You answers Have been submitted, Your mark is :" + result.ToString());
				this.Hide();
			}
		}
	}
}
