using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.SingleResponsiblity
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class CustomerRepository
    {
        public void SaveCustomer(Customer customer)
        {
            Console.WriteLine($"Customer:{customer.Name} {customer.Address}");
        }
    }
    public class EmailService
    {
        public void SendWelcomeEmail(Customer customer)
        {
            Console.WriteLine($"Sending welcome email to {customer.Name} at {customer.Address}");
        }

    }
}
