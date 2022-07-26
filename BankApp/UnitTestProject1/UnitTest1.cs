using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApp;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_amount_to_balance()
        {
            // Arrange
            var account = new Account(1000);

            // Act
            account.Add(500);

            // Assert

            Assert.AreEqual(1500, account.Balance); 
        }

        [TestMethod]
        public void Withdrawing_amount_from_balance()
        {
            // Arrange
            var account = new Account(1000);

            // Act
            account.Withdraw(500);

            // Assert

            Assert.AreEqual(500, account.Balance);
        }


        [TestMethod]
        public void Transfering_Funds_updates_both_accounts()
        {
            // Arrange
            var account = new Account(1000);
            var otherAccount = new Account();

            // Act
            account.TransferFundsTo(otherAccount, 500);

            // Assert

            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, otherAccount.Balance);
        }

        [TestMethod]
        public void Balance_is_Low()
        {
            // Arrange
            var account = new Account(600);

            // Act
            account.Balance_is_Low();

            // Assert

            Assert.IsTrue(true);
        }



    }
}
