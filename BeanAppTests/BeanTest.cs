using BeanieApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeanAppTests
{
    /// <summary>
    /// Summary description for BeanTest
    /// </summary>
    [TestClass]
    public class BeanTest
    {

        [TestMethod]
        public void CreationTest()
        {
            var bean = new Bean();
            Assert.IsNotNull(bean);
        }

        [TestMethod]
        public void ColorFlavorMatchingTest()
        {
            var bean = new Bean();
            var isColorFlavorMatching = (int)bean.Color == (int)bean.Flavor;
            Assert.IsTrue(isColorFlavorMatching);
        }
    }
}
