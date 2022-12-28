using Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_BusinessLayer
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void AccessTest()
        {
            ProductRepository obj1 = new ProductRepository();
            Product obj2 = new Product(2);
            obj2.ProductName = "AMUL";
            obj2.CurrentPrice = 12;
            obj2.ProductDescription = "AMUL MILK RAGE IS OUT OF STOCK!!!";
           
            var actual = obj1.Access(2);
            
            Assert.AreEqual(obj2.ProductName, actual.ProductName);
            Assert.AreEqual(obj2.ProductID, actual.ProductID);
            Assert.AreEqual(obj2.ProductDescription, actual.ProductDescription);
        }


    }
}
