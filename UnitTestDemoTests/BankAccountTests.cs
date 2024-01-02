using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDemo;

namespace UnitTestDemoTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Deposit_GivesCorrectBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("aaa-111", "test-user");

            // Act
            account.Deposit(100);

            // Assert
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod]
        public void Deposit_MultipleDepositsGivesCorrectBalance()
        {
            // Arrange
            BankAccount account = new BankAccount("aaa-111", "test-user");

            // Act
            account.Deposit(100);
            account.Deposit(100);

            // Assert
            Assert.AreEqual(200, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Deposit_NegativeDepositGivesArgumentException()
        {
            // Arrange
            BankAccount account = new BankAccount("aaa-111", "test-user");

            // Act
            account.Deposit(-100);
        }
    }
}
