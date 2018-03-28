using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormsBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsBank.Tests
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
            Assert.Fail();
        }

        [TestMethod()]
        public void TransferFunds1Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TransferFunds2Test()
        {
            Assert.Fail();
        }
    }
}