using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WFPAPITest.Models
{


    public partial class Users
    {
        [JsonProperty("IdUser")]
        public long IdUser { get; set; }

        [JsonProperty("FName")]
        public string FName { get; set; }

        [JsonProperty("LName")]
        public string LName { get; set; }

        [JsonProperty("Sale")]
        public long Sale { get; set; }

        [JsonProperty("Type")]
        public long Type { get; set; }
    }

    public partial class Users
    {
        public static Users FromJson(string json) => JsonConvert.DeserializeObject<Users>(json, WFPAPITest.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Users self) => JsonConvert.SerializeObject(self, WFPAPITest.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
