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
		public SolveExam()
		{
			InitializeComponent();
		}

		private async void SolveExam_Load(object sender, EventArgs e)
		{
			var result = await ExamSystemAPI.GetInstance().GetExam(HomePage.selectedExamId);

			foreach (var item in result) {
				MessageBox.Show(item["question"]);
			}
		}
	}
}
