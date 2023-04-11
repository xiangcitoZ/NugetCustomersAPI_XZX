using NugetCustomersAPI_XZX.Models;
using NugetCustomersAPI_XZX.Services;

namespace PruebaNugetCustomers
{
    public partial class Form1 : Form
    {
        ServiceNorthwind service;
        List<string> ListIdsCustomers;

        public Form1()
        {
            InitializeComponent();
            this.service = new ServiceNorthwind();
            this.ListIdsCustomers = new List<string>();
        }


        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            ServiceNorthwind service = new ServiceNorthwind();
            CustomersList customersList = await service.GetCustomersListAsync();
            foreach (Customer c in customersList.Customers)
            {
                this.listBox1.Items.Add(c.Contact);
                this.ListIdsCustomers.Add(c.IdCustomer);
            }

        }

        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            string idCustomer = this.ListIdsCustomers[index];
            Customer customer =
                await this.service.FindCustomerAsync(idCustomer);
            this.txtIdCliente.Text = idCustomer;
            this.txtCompany.Text = customer.Company;
            this.txtAddress.Text = customer.Address;
            this.txtCity.Text = customer.City;

        }
    }
}