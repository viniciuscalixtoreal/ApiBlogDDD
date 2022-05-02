using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.DTO
{
    public class CompanyViewModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "catchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonProperty(PropertyName = "bs")]
        public string BS { get; set; }
    }
}
