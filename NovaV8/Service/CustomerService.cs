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

        public static T FindById<T>(long id)
        {
            return Simplifier.findById<T>(id);
        }

        public static List<Customer> FindAll()
        {
            return Simplifier.FindAll<Customer>();
        }

    }
}
