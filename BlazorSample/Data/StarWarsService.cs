using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorSample.Data
{
    public class StarWarsApiService
    {
        private readonly HttpClient _httpClient;

        public StarWarsApiService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<Result>> GetContactsAsync()
        {
            var response = await _httpClient.GetAsync("/api/people");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsStringAsync();
            var result =  JsonConvert.DeserializeObject<RootObject>(responseContent);
            return result.results;
        }

    }


    public class Result
    {
        public string name { get; set; }
        public string height { get; set; }
        public string mass { get; set; }
        public string hair_color { get; set; }
        public string skin_color { get; set; }
        public string eye_color { get; set; }
        public string birth_year { get; set; }
        public string gender { get; set; }
        public string homeworld { get; set; }
        public List<string> films { get; set; }
        public List<string> species { get; set; }
        public List<object> vehicles { get; set; }
        public List<object> starships { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    }

    public class RootObject
    {
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Result> results { get; set; }
    }
}
