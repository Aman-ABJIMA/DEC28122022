using Business_Layer;
using System.Diagnostics.CodeAnalysis;

namespace Test1_BusinessLayer
{
    [TestClass]
    public class CustomerTest
    {

        /*************************************************************************/

        [TestMethod]
        public void FullNameTest()
        {
            Customer obj = new Customer();
            obj.FirstName = "AMAN";
            obj.LastName = "SINGH";

            Assert.AreEqual("AMAN,SINGH", obj.FullName);
        }

        /*************************************************************************/

        [TestMethod]
        public void StaticTest1()
        {
            Customer obj1 = new Customer();
            obj1.FirstName = "AMAN";
            Customer.ObjectCount++;


            Customer obj2 = new Customer();
            obj2.FirstName = "KULDEEP";
            Customer.ObjectCount++;


            Customer obj3 = new Customer();
            obj3.FirstName = "ISHANSHI";
            Customer.ObjectCount++;

            Assert.AreEqual(3, Customer.ObjectCount);
        }

        /*************************************************************************/

        [TestMethod]
        public void StaticTest2()
        {
            Customer obj1 = new Customer();
            obj1.FirstName = "AMAN";

            Customer obj2 = new Customer();
            obj2 = obj1;
            obj2.FirstName = "KULDEEP";

            Customer obj3 = new Customer();
            obj3 = obj2;
            obj3.FirstName = "ISHANSHI";

            Assert.AreNotEqual("AMAN", obj1.FirstName);
            //object is reference type!!!
        }
        /*************************************************************************/
        [TestMethod]
        public void VerifyTest1()
        {
            Customer obj = new Customer();
            obj.LastName = "AMAN";
            obj.Email = "asinghcnb7355@gmail.com";

            Assert.AreEqual(true, obj.Verify());
        }
        /*************************************************************************/
        [TestMethod]
        public void VerifyTest2()
        {
            Customer obj = new Customer();

            obj.Email = "asinghcnb7355@gmail.com";

            Assert.AreEqual(false, obj.Verify());
        }
    }
}