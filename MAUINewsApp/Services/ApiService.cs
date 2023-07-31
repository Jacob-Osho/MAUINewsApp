using MAUINewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINewsApp.Services
{
    public class ApiService
    {
        public ApiService()
        {

        }
        public async Task<RootObject> GetNews(string categoryName)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?category={categoryName.ToLower()}&lang=en&apikey=d8320efa2d12a2eaffc7a6349b0808a4");
            return JsonConvert.DeserializeObject<RootObject>(response);

        }
    }
}
