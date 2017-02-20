using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Smarsy.Configuration;
using SmarsyEntities;
using NLog;


namespace Smarsy.Logic
{
    public class ApiLogic
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private static T ExecRequest<T>(string url)
        {
            var client = new HttpClient { BaseAddress = new Uri(ApiConfig.ApiUrl) };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode) return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);

            Logger.Error(new NullReferenceException(), "No response from service");

            throw new NullReferenceException();
        }

        public Student GetStudentByLogin(string login)
        {
            return ExecRequest<Student>($"api/Students?login={login}");
        }
    }
}
