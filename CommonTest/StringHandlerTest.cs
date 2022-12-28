using Common;

namespace CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTest1()
        {
            
            var source = "IntexHometheater";
            var expected = "Intex Hometheater";
            

            var actual = source.InserSpaces();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void InsertSpaceTest2()
        {
           
            var source = "Intex Hometheater";
            var expected = "Intex Hometheater";


            var actual = source.InserSpaces();

            Assert.AreEqual(expected, actual);

        }
    }
}