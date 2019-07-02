using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace StdTask.Data
{
    class ReportData
    {
        [JsonProperty("headers")]
        public HeaderData[] Headers { get; set; }
        [JsonProperty("contents")]
        public List<object[]> Contents { get; set; }
    }
}
