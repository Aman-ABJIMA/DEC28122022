using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class CustomerRepository
    {
        public Customer Access(int customerId)
        {
            Customer obj1 = new Customer(customerId);
            if(customerId==1) 
            {
                obj1.Email = "asinghcnb7355@gmail.com";
                obj1.FirstName = "AMAN";
                obj1.LastName = "SINGH";
            }

            return obj1;
        }

        public bool Save(Customer obj1)
        {
            return true;
        }


    }
}
