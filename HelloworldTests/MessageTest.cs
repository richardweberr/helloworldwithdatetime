using Helloworld;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloworldTests
{
    [TestClass]
    public class MessageTest
    {
        [TestMethod]
        public void LaNuitLeMatinTest()
        {
            //init
            FakeDate fakeDate = new FakeDate(DayOfWeek.Monday, 7);
            FakeUserName fakeUserName = new FakeUserName();
            Message target = new Message(fakeUserName, fakeDate);
            //action
            string result = target.GetHelloMessage();
            //assertion
            Assert.AreEqual("Bonsoir, Toto", result);
        }

        [TestMethod]
        public void BonjourTest()
        {
            FakeDate fakeDate = new FakeDate(DayOfWeek.Monday, 9);
            FakeUserName fakeUserName = new FakeUserName();
            Message target = new Message(fakeUserName, fakeDate);
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bonjour, Toto", result);
        }

        [TestMethod]
        public void BonApresMidiTest()
        {
            FakeDate fakeDate = new FakeDate(DayOfWeek.Monday, 13);
            FakeUserName fakeUserName = new FakeUserName();
            Message target = new Message(fakeUserName, fakeDate);
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bon après-midi, Toto", result);
        }

        [TestMethod]
        public void BonsoirTest()
        {
            FakeDate fakeDate = new FakeDate(DayOfWeek.Monday, 18);
            FakeUserName fakeUserName = new FakeUserName();
            Message target = new Message(fakeUserName, fakeDate);
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bonsoir, Toto", result);
        }

        [TestMethod]
        public void BonWETest()
        {
            FakeDate fakeDate = new FakeDate(DayOfWeek.Saturday, 12);
            FakeUserName fakeUserName = new FakeUserName();
            Message target = new Message(fakeUserName, fakeDate);
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bon W.-E. Toto", result);
        }

        [TestMethod]
        public void VendrediSoirTest()
        {
            FakeDate fakeDate = new FakeDate(DayOfWeek.Friday, 18);
            FakeUserName fakeUserName = new FakeUserName();
            Message target = new Message(fakeUserName, fakeDate);
            string result = target.GetHelloMessage();
            Assert.AreEqual("Bon W.-E. Toto", result);
        }
    }
}
