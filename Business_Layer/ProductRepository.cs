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
            return obj;

     }
        public bool Save(Product obj)
        {
            return true;
        }

    }
}
