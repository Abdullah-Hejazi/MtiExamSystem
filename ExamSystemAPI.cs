using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtiExamSystem
{
	class ExamSystemAPI
	{
		private static readonly ExamSystemAPI _instance = new ExamSystemAPI();
		private static readonly HttpClient client = new HttpClient();
		private String apiEndpoint = "http://35.198.117.174";
		private String token = "";
		public String name = "";
		public String role = "";

		private ExamSystemAPI()
		{
		}

		public static ExamSystemAPI GetInstance()
		{
			return _instance;
		}

		public async Task<Dictionary<string, string>> Login(String email, String password)
		{
			var values = new Dictionary<string, string>
			{
				{ "email", email},
				{ "password", password }
			};

			var content = new FormUrlEncodedContent(values);
			HttpResponseMessage response = await client.PostAsync(apiEndpoint + "/login", content);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{

				var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content.ReadAsStringAsync().Result);
				this.token = result["token"];

				String endPointSuffix = "";

				role = result["role"];

				if (role == "student") {
					endPointSuffix = "students";
				} else if (role == "professor")
				{
					endPointSuffix = "professors";
				}

				this.name = result["name"];

				this.apiEndpoint = this.apiEndpoint + "/" + endPointSuffix;

				return new Dictionary<string, string> {
					{"success", "true" },
					{"role", endPointSuffix }
				};
			}
			else
			{
				return new Dictionary<string, string> {
					{"success", "false" }
				};
			}
		}

		public async Task<List<Dictionary<string, string>>> Home() {
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
			HttpResponseMessage response = await client.GetAsync(apiEndpoint + "/home");

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var result = JsonConvert.DeserializeObject< Dictionary<string, List <Dictionary<string, string>>>>(response.Content.ReadAsStringAsync().Result);

				return result["exams"];
			}
			else
			{
				return null;
			}
		}

		public async Task<int> NewExam(String examName, int duration, String startsAt)
		{
			var values = new Dictionary<string, string>
			{
				{ "name", examName},
				{ "duration", duration.ToString() },
				{ "starts_at", startsAt }
			};

			var content = new FormUrlEncodedContent(values);
			HttpResponseMessage response = await client.PostAsync(apiEndpoint + "/exam/new", content);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{

				var result = JsonConvert.DeserializeObject<Dictionary<string, int>>(response.Content.ReadAsStringAsync().Result);

				return result["id"];
			}
			else
			{
				return -1;
			}
		}

		public async Task<bool> AddQuestion(int id, String question, String answer, String options, String type, String marks)
		{
			var values = new Dictionary<string, string>
			{
				{ "question", question},
				{ "answer", answer },
				{ "options", options },
				{ "type", type },
				{ "marks", marks }
			};

			var content = new FormUrlEncodedContent(values);
			HttpResponseMessage response = await client.PostAsync(apiEndpoint + "/exam/" + id.ToString() + "/questions/add", content);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public async Task<List<Dictionary<string, string>>> GetExam(int id)
		{
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
			HttpResponseMessage response = await client.GetAsync(apiEndpoint + "/exam/" + id.ToString());

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var result = JsonConvert.DeserializeObject<Dictionary<string, List<Dictionary<string, string>>>>(response.Content.ReadAsStringAsync().Result);

				return result["questions"];
			}
			else
			{
				return null;
			}
		}

		public async Task<int> SolveExam(int id, String answers)
		{
			var values = new Dictionary<string, string>
			{
				{ "answers", answers }
			};

			var content = new FormUrlEncodedContent(values);
			HttpResponseMessage response = await client.PostAsync(apiEndpoint + "/exam/" + id.ToString() + "/answer", content);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				var result = JsonConvert.DeserializeObject<Dictionary<string, int>>(response.Content.ReadAsStringAsync().Result);
				return result["marks"];
			}
			else
			{
				var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content.ReadAsStringAsync().Result);
				MessageBox.Show(result["message"]);
				return -1;
			}
		}

	}
}
