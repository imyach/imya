using Microsoft.VisualStudio.TestTools.UnitTesting;
using Okun.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Okun.AppData;

namespace Okun.Pages.Tests
{
    [TestClass()]
    public class AddEditAccTests
    {
        [TestMethod()]
        public void CheckAccountingFIOTest()
        {
            AppData.Accounting acc = new AppData.Accounting {FIO = "" ,  DateOfReceipt = DateTime.Now, QuantityProduct = 2 };
            bool expected = false;
            bool actual = AddEditAcc.CheckAccounting(acc);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckNullAccountingQuantityProductTest()
        {
            AppData.Accounting acc = new AppData.Accounting { FIO = "Иван", DateOfReceipt = DateTime.Now, QuantityProduct = -2 };
            bool expected = false;
            bool actual = AddEditAcc.CheckAccounting(acc);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckDigitAccountingQuantityProductFIOTest()
        {
            AppData.Accounting acc = new AppData.Accounting { FIO = "", DateOfReceipt = DateTime.Now, QuantityProduct = -2 };
            bool expected = false;
            bool actual = AddEditAcc.CheckAccounting(acc);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckDigitAccountingDateFIOTest()
        {
            AppData.Accounting acc = new AppData.Accounting { FIO = "", DateOfReceipt = new DateTime(2020, 2, 1), QuantityProduct = -2 };
            bool expected = false;
            bool actual = AddEditAcc.CheckAccounting(acc);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void CheckDigitAccountingDateQuantityProductTest()
        {
            AppData.Accounting acc = new AppData.Accounting { FIO = "Иван", DateOfReceipt = new DateTime(2000, 2, 1), QuantityProduct = -2 };
            bool expected = false;
            bool actual = AddEditAcc.CheckAccounting(acc);
            Assert.AreEqual(expected, actual);
        }
    }
}