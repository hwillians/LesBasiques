using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MesClasses.Exos.Tests
{
    [TestClass()]
    public class ExosExceptionsTests
    {
        [TestMethod()]
        public void DiviserTest()
        {
            int i = 10;
            int j = 2;

            var r = ExosExceptions.Diviser(i, j);

            Assert.AreEqual(5, r);
        }
    }
}