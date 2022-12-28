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



        [TestMethod]
        public void SaveTest1() 
        {
            ProductRepository obj1 = new ProductRepository();
            Product obj2 = new Product(2)
            {
                CurrentPrice = 12,
                ProductDescription = "AMUL MILK RANGE IS OUT OF STOCK!!!",
                ProductName = "AMUL",
                HasChanges = true 
            };
            var actual = obj1.Save(obj2);

            Assert.AreEqual(true,actual);
        }


        [TestMethod]
        public void SaveTest2()
        {
            ProductRepository obj1 = new ProductRepository();
            Product obj2 = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "AMUL MILK RANGE IS OUT OF STOCK!!!",
                ProductName = "AMUL",
                HasChanges = true
            };

            var actual = obj1.Save(obj2);

            Assert.AreEqual(false,actual);
        }


    }
}
