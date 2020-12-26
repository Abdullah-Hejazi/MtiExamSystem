using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

				if (result["role"] == "student") {
					endPointSuffix = "students";
				} else if (result["role"] == "professor")
				{
					endPointSuffix = "professors";
				}

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

	}
}
