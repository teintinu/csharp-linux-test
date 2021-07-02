using Microsoft.VisualStudio.TestTools.UnitTesting;
using lib;

namespace testlib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Matematica.soma(2, 1));            
        }
    }
}
