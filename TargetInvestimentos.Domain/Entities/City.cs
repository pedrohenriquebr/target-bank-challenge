using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetInvestimentos.Api.Helpers;

namespace TargetInvestimentos.Domain.Entities
{

    public partial class City
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }
    }

    public partial class City
    {
        public static City FromJson(string json) => JsonConvert.DeserializeObject<City>(json, Converter.Settings);
    }
}
