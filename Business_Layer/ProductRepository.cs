using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ProductRepository
    {
     public Product Access(int productID)
     {
            Product obj = new Product(productID);
            if(productID==2)
            {
                obj.ProductName = "AMUL";
                obj.ProductDescription = "AMUL MILK RAGE IS OUT OF STOCK!!!";
                obj.CurrentPrice=12;
            }
            Object myObject = new Object();
            Console.WriteLine($"Object:{myObject.ToString()}");
            Console.WriteLine($"Product:{obj.ToString()}");
            return obj; 

     }
     public bool Save(Product obj)
        {
            var success = true;
            if(obj.HasChanges)
            {
                if(obj.IsValid)
                {
                    if(obj.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
=======
            return obj;

     }
        public bool Save(Product obj)
        {
            return true;
>>>>>>> 5ab85e9ee45c70f217b0d53b1af77c2cab8d2682
        }

    }
}
