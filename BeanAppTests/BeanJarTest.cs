using BeanieApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeanAppTests
{
    [TestClass]
    public class BeanJarTest
    {
        [TestMethod]
        public void CreationTest()
        {
            var jar = new BeanJar
            {
                Capacity = BeanJar.MAX_CAPACITY
            };
            Assert.IsNotNull(jar);
        }

        [TestMethod]
        public void AddBeanTest()
        {
            var jar = new BeanJar { Capacity = BeanJar.MAX_CAPACITY };

            var bean = new Bean();
            jar.AddBean(bean);

            Assert.IsTrue(jar.TotalBeanCount == 1);
        }

        [TestMethod]
        public void GetStatisticsTest()
        {
            var jar = new BeanJar { Capacity = BeanJar.MAX_CAPACITY };

            var bean = new Bean();
            jar.AddBean(bean);

            Assert.IsFalse(string.IsNullOrEmpty(jar.GetStatistics()));
        }
    }
}
