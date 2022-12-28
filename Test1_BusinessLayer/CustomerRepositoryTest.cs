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



        [TestMethod] 
        public void AccessCustomerViaIdTest() 
        {
//**********************************************************************************//            
            #region Correct Data
            CustomerRepository obj1 = new CustomerRepository();

            Customer expected = new Customer(1);
            expected.FirstName = "AMAN";
            expected.LastName = "SINGH";
            expected.Email = "asinghcnb7355@gmail.com";
            expected.AddressList = new List<Address>()
            {
                new Address()
                {
                    AddressType=1,
                    StreetLine1 = "CHHANIYAPURA",
                    StreetLine2 = "RANIMAHEL",
                    City = "JHANSI",
                    State = "UP",
                    Country = "INDIA",
                    PostalCode = "284002"
                },
                new Address()
                {
                    AddressType =2,
                    StreetLine1 = "CHITRAKOOT",
                    StreetLine2 = "AKSHARDHAM",
                    City = "JAIPUR",
                    State = "RAJASTHAN",
                    Country = "INDIA",
                    PostalCode = "302001"        
                
                }
            };
            #endregion

//******************************************************************//
            #region Call Target Method

            var actual = obj1.Access(1);

            #endregion

//*******************************************************************//
           #region Let's Test

            Assert.AreEqual (expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);

            for(int i =0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
            #endregion

        }
    }
}
