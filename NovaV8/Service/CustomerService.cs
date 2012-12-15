using System;
using System.Collections.Generic;
using System.Text;
namespace NovaV8
{
    public class CustomerService

    {


        public static List<Customer> AllCustomers()
        {
            return Simplifier.FindAll<Customer>();
        }
    }
}
