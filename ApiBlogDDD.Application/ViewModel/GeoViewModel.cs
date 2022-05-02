using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.DTO
{
    public class GeoViewModel
    {
        [JsonProperty(PropertyName = "lat")]
        public string Lat { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public string Lng { get; set; }
    }
}
