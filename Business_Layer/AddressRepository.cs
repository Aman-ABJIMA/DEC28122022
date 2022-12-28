using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class AddressRepository
    {

        public IEnumerable<Address> AccessCustomerViaID(int customerID) 
        {
           var obj = new List<Address>();
          
                Address obj1 = new Address(1);
                obj1.AddressType = 1;
                obj1.StreetLine1 = "CHHANIYAPURA";
                obj1.StreetLine2 = "RANIMAHEL";
                obj1.City = "JHANSI";
                obj1.State = "UP";
                obj1.Country = "INDIA";
                obj1.PostalCode = "284002";

                obj.Add(obj1);
           
                obj1 = new Address(2);
                obj1.AddressType = 2;
                obj1.StreetLine1 = "CHITRAKOOT";
                obj1.StreetLine2 = "AKSHARDHAM";
                obj1.City = "JAIPUR";
                obj1.State = "RAJASTHAN";
                obj1.Country = "INDIA";
                obj1.PostalCode = "302001";

                obj.Add(obj1);
           
            return obj;
        }

        public bool Save(Address obj)
        {
            return true;
        }
        
    }
}
