using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MtiExamSystem
{
	class ExamSystemAPI
	{
		private static readonly ExamSystemAPI _instance = new ExamSystemAPI();
		private static readonly HttpClient client = new HttpClient();
		private String apiEndpoint = "http://localhost:3333";
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
	}
}
