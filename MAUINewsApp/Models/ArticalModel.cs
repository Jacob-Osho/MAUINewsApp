using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAUINewsApp.Models
{
    public class Article
    {
        public Article()
        {
                
        }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("publishedAt")]
        public DateTime PublishedAt { get; set; }
        [JsonProperty("source")]
        public Source Source { get; set; }
    }
}
