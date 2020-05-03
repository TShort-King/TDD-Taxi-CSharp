using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDD_Taxi_CSharp;

namespace TDD_Taxi_CSharp_Test
{
   
    public class TestMain
    {
        private ReadFileManage readManage;

        [SetUp]
        public void Setup()
        {
            readManage = new ReadFileManage();
        }

        [Test]
        public void Test_Normal_First()
        {
            Assert.AreEqual(readManage.Get_Results("",""), null);
        }

        [Test]
        public void Test_Normal_Second()
        {
            Assert.AreEqual(readManage.Get_Results(AppDomain.CurrentDomain.BaseDirectory.Replace("TDD-Taxi-CSharp-Test\\bin\\Debug\\netcoreapp3.1\\", ""), "testData.txt"), new List<string> {
                "收费6元",
                "收费7元",
                "收费13元",
                "收费7元"
            });
        }
    }
}
