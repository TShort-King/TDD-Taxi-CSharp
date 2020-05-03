using NUnit.Framework;
using TDD_Taxi_CSharp;

namespace TDD_Taxi_CSharp_Test
{
    public class TestTaxiPriceManage
    {

        TaxiPriceManage taxiManage;

        [SetUp]
        public void Setup()
        {
            taxiManage = new TaxiPriceManage();
        }


        [Test]
        public void Test_Normal_First()
        {
            Assert.AreEqual(taxiManage.Get_Price("1公里,等待0分钟"), "收费6元");
        }

        [Test]
        public void Test_Normal_Second()
        {
            Assert.AreEqual(taxiManage.Get_Price("3公里,等待0分钟"), "收费7元");
        }

        [Test]
        public void Test_Normal_Third()
        {
            Assert.AreEqual(taxiManage.Get_Price("10公里,等待0分钟"), "收费13元");
        }

        [Test]
        public void Test_Normal_Fourth()
        {
            Assert.AreEqual(taxiManage.Get_Price("2公里,等待3分钟"), "收费7元");
        }

        [Test]
        public void Test_Normal_Fifth()
        {
            Assert.AreEqual(taxiManage.Get_Price("0公里,等待0分钟"), "收费0元");
        }

        [Test]
        public void Test_Normal_Sixth()
        {
            Assert.AreEqual(taxiManage.Get_Price("0公里,等待3分钟"), "收费1元");
        }
    }
}