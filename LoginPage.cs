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

			var examSystemAPI = ExamSystemAPI.GetInstance();
			var result = await examSystemAPI.Login(emailInput.Text, passwordInput.Text);

			if (result["case"] == "true")
			{
				MessageBox.Show(result["token"]);
			}
			else
			{
				MessageBox.Show("Invalid data !");
			}
		}
	}
}
