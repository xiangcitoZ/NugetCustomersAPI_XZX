using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetCustomersAPI_XZX.Models
{
    public class Order
    {
        [JsonProperty("OrderID")]
        public string IdOrder { get; set; }

        [JsonProperty("CustomerID")]
        public string IdCustomer { get; set; }

        [JsonProperty("ShippedDate")]
        public DateTime ShipDate { get; set; }

        [JsonProperty("ShipName")]
        public string ShipName { get; set; }

        [JsonProperty("ShipAddress")]
        public string ShipAddress { get; set; }

        [JsonProperty("ShipCity")]
        public string ShipCity { get; set; }

        [JsonProperty("ShipCountry")]
        public string ShipCountry { get; set; }
    }
}
