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
	public partial class HomePage : Form
	{
		public static int selectedExamId = -1;
		public HomePage()
		{
			InitializeComponent();
		}

		private async void HomePage_Load(object sender, EventArgs e)
		{
			this.MaximizeBox = false;
			var examSystemApi = ExamSystemAPI.GetInstance();
			var result = await examSystemApi.Home();

			if (result == null) {
				MessageBox.Show("Something went wrong !!");
				return;
			}

			if (examSystemApi.role == "professor") {
				newExamButton.Visible = true;
			}

			welcomeLabel.Text = "Welcome, " + examSystemApi.name;


			int index = 0;

			foreach (var exam in result)
			{
				Panel panel = new Panel();
				panel.Size = new Size(764, 63);
				panel.Location = new Point(7, (index * 70) + 90);
				panel.BackColor = Color.FromKnownColor(KnownColor.Gainsboro);


				Label examName = new Label();
				examName.Text = exam["name"];
				examName.Location = new Point(6, 3);
				examName.Font = new Font(new FontFamily("Arial"), 20.25f, FontStyle.Regular);
				examName.Size = new Size(600, 35);
				examName.Visible = true;
				panel.Controls.Add(examName);


				Label startsAtLabel = new Label();
				startsAtLabel.Text = "Starts at: " + exam["starts_at"];
				startsAtLabel.Location = new Point(8, 39);
				startsAtLabel.Font = new Font(new FontFamily("Arial"), 8.25f, FontStyle.Regular);
				startsAtLabel.Visible = true;
				startsAtLabel.Size = new Size(600, 15);
				panel.Controls.Add(startsAtLabel);

				if (ExamSystemAPI.GetInstance().role == "student") {
					Button participateButton = new Button();
					participateButton.Text = "Participate";
					participateButton.UseVisualStyleBackColor = false;
					participateButton.FlatStyle = FlatStyle.Flat;
					participateButton.ForeColor = Color.FromKnownColor(KnownColor.White);
					participateButton.BackColor = Color.FromKnownColor(KnownColor.RoyalBlue);
					participateButton.FlatAppearance.BorderSize = 0;
					participateButton.Size = new Size(87, 56);
					participateButton.Location = new Point(672, 4);
					participateButton.Click += (object s, EventArgs ee) => { ParticipateInExam(s, ee, exam["id"]); };
					participateButton.Visible = true;
					panel.Controls.Add(participateButton);
				}

				panel.Visible = true;

				panel1.Controls.Add(panel);
				panel.Update();
				index++;
			}

			panel1.AutoScroll = false;
			panel1.HorizontalScroll.Enabled = false;
			panel1.HorizontalScroll.Visible = false;
			panel1.HorizontalScroll.Maximum = 0;
			panel1.AutoScroll = true;
		}

		private void ParticipateInExam(object sender, EventArgs e, string id)
		{
			selectedExamId = int.Parse(id);

			var solveExam = new SolveExam();
			solveExam.Show();
		}

		private void newExamButton_Click(object sender, EventArgs e)
		{
			var newExam = new NewExam();
			newExam.Show();
		}
	}
}
