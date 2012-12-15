using System;
using System.Collections.Generic;
using System.Text;
using NovaV8.Modelle;
namespace NovaV8.Dienste
{
    public class CustomerService

    {


        public static List<Customer> AllCustomers()
        {
            return Simplifier.FindAll<Customer>();
        }
    }
}
