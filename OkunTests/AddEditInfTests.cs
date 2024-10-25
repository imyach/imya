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
    public class AddEditInfTests
    {
        [TestMethod()]
        public void CheckInformationNameTest()
        {
            Information inf = new Information { Name = "Блок питания", Type = "asd", Category = "c", Prise = 3 };
            bool expected = true;
            bool actual = AddEditInf.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckInformationTypeTest()
        {
            Information inf = new Information { Name = "Блок питания", Type = "", Category = "c", Prise = 0 };
            bool expected = false;
            bool actual = AddEditInf.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckInformationCategoryTest()
        {
            Information inf = new Information { Name = "Блок питания", Type = "asd", Category = "", Prise = 3 };
            bool expected = false;
            bool actual = AddEditInf.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckInformationPriseTest()
        {
            Information inf = new Information { Name = "Блок питания", Type = "asd", Category = "c", Prise = -3 };
            bool expected = false;
            bool actual = AddEditInf.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CheckInformationPriseCategoryTest()
        {
            Information inf = new Information { Name = "Блок питания", Type = "asd", Category = "", Prise = -3 };
            bool expected = false;
            bool actual = AddEditInf.CheckInformation(inf);
            Assert.AreEqual(expected, actual);
        }

    }
}