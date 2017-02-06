using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class LaskuTests
    {

        [TestMethod()]
        public void BillTest()
        {
            Lasku lasku = new Lasku();
            float expected = (0.75f * 3) + (0.90f * 4) + 3.95f + 1.20f;

            lasku.Tuotteet.Add(new Product("Makkara", 0.75f), 3);
            lasku.Tuotteet.Add(new Product("Kalja", 0.90f), 4);
            lasku.Tuotteet.Add(new Product("Kahvi", 3.95f), 1);
            lasku.Tuotteet.Add(new Product("Sipsi", 1.20f), 1);
            lasku.Bill();

            float actual = lasku.Kokonaishinta;
            Assert.AreEqual(expected, actual);
        }
    }
}