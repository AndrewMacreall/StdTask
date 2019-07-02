using Newtonsoft.Json;

namespace StdTask.Data
{
    class ContentData
    {
        [JsonProperty("contents")]
        public string[] Values { get; set; }
    }
}
