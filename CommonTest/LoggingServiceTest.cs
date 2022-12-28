using Business_Layer;
using Common;

namespace LoggingSeriveTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                Email = "asinghcnb7355@gmail.com",
                FirstName = "AMAN",
                LastName = "SINGH",
                AddressList = null
            };
            changedItems.Add(customer);
            var product = new Product(1)
            {
                ProductName = "AMUL",
                ProductDescription = "AMUL MILK RAGE IS OUT OF STOCK!!!",
                CurrentPrice = 12

            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);

        }
       
    }
}