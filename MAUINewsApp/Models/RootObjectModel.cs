using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUINewsApp.Models
{
    public class RootObject
    {
        [JsonProperty("totalArticles")]
        public int TotalArticles { get; set; }
        [JsonProperty("articles")]
        public List<Article> Articles { get; set; }
    }
}
