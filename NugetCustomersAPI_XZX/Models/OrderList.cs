using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetCustomersAPI_XZX.Models
{
    public class OrderList
    {
        [JsonProperty("value")]
        public List<Order> Orders { get; set; }
    }
}
