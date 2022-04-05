using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetInvestimentos.Api.Helpers;

namespace TargetInvestimentos.Domain.Entities.Helpers
{
    public static class Serialize
    {
        public static string ToJson(this Object self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
