using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetCustomersAPI_XZX.Models
{
    public class Customer
    {
        [JsonProperty("CustomerID")]
        public string IdCustomer { get; set; }
        [JsonProperty("CompanyName")]
        public string Company { get; set; }
        [JsonProperty("ContactName")]
        public string Contact { get; set; }
        [JsonProperty("Address")]
        public string Address { get; set; }
        [JsonProperty("City")]
        public string City { get; set; }
    }

}
