using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace WFPAPITest.Models
{
    public partial class Types
    {
        [JsonProperty("IdType")]
        public long IdType { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }
    }

    public partial class Types
    {
        public static Types FromJson(string json) => JsonConvert.DeserializeObject<Types>(json, WFPAPITest.Models.Converter.Settings);
    }
}
