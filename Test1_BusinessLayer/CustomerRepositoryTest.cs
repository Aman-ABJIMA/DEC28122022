using Business_Layer;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_BusinessLayer
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void AccessTest()
        {
            CustomerRepository obj1 = new CustomerRepository();

            Customer obj2 = new Customer(1);
            
            obj2.FirstName = "AMAN";
            obj2.LastName = "SINGH";
            obj2.Email = "asinghcnb7355@gmail.com";

            var actual = obj1.Access(1);

            Assert.AreEqual(obj2.FirstName, actual.FirstName);
            Assert.AreEqual(obj2.LastName, actual.LastName);
            Assert.AreEqual(obj2.Email, actual.Email);     
        }

        


    }
}
