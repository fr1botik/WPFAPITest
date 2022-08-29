    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

namespace WFPAPITest.Models
{
    public partial class Sales
    {
        [JsonProperty("IdSale")]
        public long IdSale { get; set; }

        [JsonProperty("Salee")]
        public string Salee { get; set; }
    }

    public partial class Sales
    {
        public static Sales FromJson(string json) => JsonConvert.DeserializeObject<Sales>(json, WFPAPITest.Models.Converter.Settings);
    }
}