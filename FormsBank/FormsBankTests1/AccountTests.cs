using FormsBank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormsBankTests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void DepostitTest()
        {
            Account a1 = new Account();
            var result = a1.Depostit(0);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void WithdrawTest()
        {
            Account a1 = new Account();
            a1.Depostit(100);
            var result = a1.Withdraw(100);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void TransferFunds1Test()
        {
            var a1 = new Account();
            var a2 = new Account();
            
            if (a1.Balance >= 0 || a1.Balance > 200)

            a1.Balance -= 100;
            a2.Balance += 100;

            var result = a1.TransferFunds1(a1, a2, 100);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void TransferFunds2Test()
        {
            var a1 = new Account();
            var a2 = new Account();
           
            if (a2.Balance >= 0 || a2.Balance > 200)

                a2.Balance -= 100;
            a1.Balance += 100;

            var result = a2.TransferFunds1(a2, a1, 100);
            Assert.IsFalse(result);
        }
    }
}