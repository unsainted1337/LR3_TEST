using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectTestExample;

namespace People_Test
{
    [TestClass]
    public class UnitTest1
    {
        People people = new People("gg", "1234", "gg@gmail.com", 70000000000);

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("gg", people.Login);
            
        }
        [TestMethod]
        public void GetEmailTest()
        {
            Assert.AreEqual("gg@gmail.com", people.Email);

        }

        [TestMethod]
        public void GetPhoneTest()
        {
            Assert.AreEqual(70000000000, people.Phone);

        }
        [TestMethod]
        public void GetPassTest()
        {
            Assert.AreEqual("1234", people.Pass);

        }
    }
}
