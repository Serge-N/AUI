using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AUI.Shared.Classes.User;
using Newtonsoft.Json;
namespace AUI.Shared.Classes.General
{
    public static class Deseliaze
    {
        public static List<Users> Users(string json)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = false
            };
            return JsonConvert.DeserializeObject<List<Users>>(json);
        }
    }
}
