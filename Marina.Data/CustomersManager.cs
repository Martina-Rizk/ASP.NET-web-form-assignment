using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marina.Data
{
    public class CustomersManager
    {
        // check user for log in 
        public static CustomerDTO Authenticate(string FirstName, string LastName)
        {
            CustomerDTO cust = null;
            var db = new MarinaEntities();
            var auth = db.Customers.
                SingleOrDefault(a => a.FirstName == FirstName && a.LastName == LastName);
            if (auth != null) // authentication passsed
            {
                cust = new CustomerDTO
                {
                    ID = auth.ID,
                    FullName = $"{auth.FirstName} {auth.LastName}"
                };
            }
            return cust;
        }


        public static Customer Find(int CustomerId)
        {
            var db = new MarinaEntities();
            var auth = db.Customers.SingleOrDefault(a => a.ID == CustomerId);
            return auth;
        }

        public static void Add(Customer cust)
        {
            var db = new MarinaEntities();
            db.Customers.Add(cust);
            db.SaveChanges();
        }
    }
}
