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

		private void button1_Click(object sender, EventArgs e)
		{
			if (nameInput.Text.Length == 0 || textBox1.Text.Length == 0) {
				MessageBox.Show("Can't add questions until you fill in the exam data !");
				return;
			}
			panel1.Hide();
			panel2.Visible = true;
		}

		private void truefalseButton_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
