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
            Assert.AreEqual(taxiManage.Get_Price("1����,�ȴ�0����"), "�շ�6Ԫ");
        }

        [Test]
        public void Test_Normal_Second()
        {
            Assert.AreEqual(taxiManage.Get_Price("3����,�ȴ�0����"), "�շ�7Ԫ");
        }

        [Test]
        public void Test_Normal_Third()
        {
            Assert.AreEqual(taxiManage.Get_Price("10����,�ȴ�0����"), "�շ�13Ԫ");
        }

        [Test]
        public void Test_Normal_Fourth()
        {
            Assert.AreEqual(taxiManage.Get_Price("2����,�ȴ�3����"), "�շ�7Ԫ");
        }

        [Test]
        public void Test_Normal_Fifth()
        {
            Assert.AreEqual(taxiManage.Get_Price("0����,�ȴ�0����"), "�շ�0Ԫ");
        }

        [Test]
        public void Test_Normal_Sixth()
        {
            Assert.AreEqual(taxiManage.Get_Price("0����,�ȴ�3����"), "�շ�1Ԫ");
        }
    }
}