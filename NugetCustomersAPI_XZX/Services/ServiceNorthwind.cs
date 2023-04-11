using Newtonsoft.Json;
using NugetCustomersAPI_XZX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NugetCustomersAPI_XZX.Services
{
    public class ServiceNorthwind
    {
        public async Task<CustomersList> GetCustomersListAsync()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            string url =
                "https://services.odata.org/V4/Northwind/Northwind.svc/Customers";
            string dataJson =
                await client.DownloadStringTaskAsync(url);
            CustomersList customers =
                JsonConvert.DeserializeObject<CustomersList>(dataJson);
            return customers;
        }

        public async Task<Customer> FindCustomerAsync(string id)
        {
            CustomersList customersList =
                await this.GetCustomersListAsync();
            Customer customer =
                customersList.Customers.FirstOrDefault
                (x => x.IdCustomer == id);
            return customer;
        }


        public async Task<OrderList> GetOrdersListAsync()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            string url = "https://services.odata.org/V4/Northwind/Northwind.svc/Orders";
            string dataJson = await client.DownloadStringTaskAsync(url);
            OrderList orders = JsonConvert.DeserializeObject<OrderList>(dataJson);
            return orders;
        }

        public async Task<List<Order>> GetOrdersByCustomer(string id)
        {
            OrderList ordersList =
                await this.GetOrdersListAsync();

            List<Order> ordersCustomer =
                ordersList.Orders.Where(x => x.IdCustomer == id).ToList();
            return ordersCustomer;
        }

    }

}
