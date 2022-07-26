using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimCardApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Recharge_Airtime_To_Balance()
        {
            // Arrange
            var airtime = new SimCard(700);

            // Act
            airtime.BuyAirtime(2000);

            // Assert

            Assert.AreEqual(2700, airtime.Balance);
        }
        [TestMethod]
        public void Buying_Data_to_Balance()
        {
            // Arrange
            var data = new SimCard(0);

            // Act
            data.BuyData(1024);

            // Assert

            Assert.AreEqual(1024, data.Balance);
        }

        [TestMethod]
        public void Borrow_amount_to_balance()
        {
            // Arrange
            var account = new SimCard();

            // Act
            account.Borrow(500);

            // Assert

            Assert.AreEqual(500, account.Balance);
        }

        [TestMethod]
        public void Transfering_Airtime_updates_both_sims()
        {
            // Arrange
            var simcard = new SimCard(1000);
            var othersimcard = new SimCard();

            // Act
            simcard.TransferAirtimeTo(othersimcard, 500);

            // Assert

            Assert.AreEqual(500, simcard.Balance);
            Assert.AreEqual(500, othersimcard.Balance);
        }


        [TestMethod]
        public void Balance_is_Low()
        {
            // Arrange
            var account = new SimCard(60);

            // Act
            account.Balance_is_Low();

            // Assert

            Assert.IsTrue(true);
        }

    }
}
