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
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			if (emailInput.Text.Length == 0 || passwordInput.Text.Length == 0) {
				MessageBox.Show("Please fill in the email and password !");
				return;
			}
			loading.Visible = true;


			var examSystemAPI = ExamSystemAPI.GetInstance();
			var result = await examSystemAPI.Login(emailInput.Text, passwordInput.Text);

			if (result["success"] == "true")
			{
				this.Hide();
				var homePage = new HomePage();
				homePage.Closed += (s, args) => this.Close();
				homePage.Show();
			}
			else
			{
				MessageBox.Show("Invalid data !");
			}

			loading.Visible = false;
		}

		private void LoginPage_Load(object sender, EventArgs e)
		{
			this.MaximizeBox = false;
		}
	}
}
