using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TargetInvestimentos.Api.Helpers;

namespace TargetInvestimentos.Domain.Entities
{
    public partial class State
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("sigla")]
        public string Sigla { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

    }
    public partial class State
    {
        public static State FromJson(string json) => JsonConvert.DeserializeObject<State>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this State self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    
}
