using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Shared
{
    public static class RestHelper
    {
        private static readonly string _baseUrl = "https://localhost:44395/api/";
        public static async Task<string> GetAll()
        {
            using(HttpClient client = new HttpClient())
            {
                using(HttpResponseMessage res = await client.GetAsync(_baseUrl + "cars/getall"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data =await content.ReadAsStringAsync();
                        if(data != null)
                        {
                            return data;
                        }
                    }
                }

            }
            return string.Empty;
        }

        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(_baseUrl + "cars/getbyid?id=" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }

            }
            return string.Empty;
        }

        public static async Task<string> Post(string name, string job)
        {
            using (HttpClient client = new HttpClient())
            {
                var inputData = new Dictionary<string, string>
                {
                    {"name", name},
                    { "job", job}
                };
                var input = new FormUrlEncodedContent(inputData);
                using (HttpResponseMessage res = await client.PostAsync("https://reqres.in/api/users",input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> CarPost(string brandId,string colorId,string modelYear,string dailyPrice, string description, Uri _baseUrl2)
        {
            var response = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                var inputData = new Dictionary<string, string>
                {
                  {"brandId", brandId},
                  {"colorId", colorId},
                  {"modelYear", modelYear},
                  {"dailyPrice", dailyPrice},
                  {"description", description}
                };
                var input = new FormUrlEncodedContent(inputData);
                HttpRequestMessage requestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = _baseUrl2,
                    Content = input
                };

                HttpResponseMessage result = await client.SendAsync(requestMessage);
                if (result.IsSuccessStatusCode)
                {
                    response = result.StatusCode.ToString();
                    MessageBox.Show(response);
                }

                using (HttpResponseMessage res = await client.PostAsync(_baseUrl + "cars/add", input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }

            }
            return string.Empty;
        }

        public static async Task<string> Put(string id,string name, string job)
        {
            using (HttpClient client = new HttpClient())
            {
                var inputData = new Dictionary<string, string>
                {
                    {"name", name},
                    { "job", job}
                };
                var input = new FormUrlEncodedContent(inputData);
                using (HttpResponseMessage res = await client.PutAsync(_baseUrl + "users/" + id, input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }

            }
            return string.Empty;
        }
    }
}
