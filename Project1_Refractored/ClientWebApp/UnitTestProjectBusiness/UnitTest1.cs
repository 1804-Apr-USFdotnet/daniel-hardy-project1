using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UnitTestProjectBusiness
{
    [TestClass]
    public class UnitTest1
    {
        Models.Resturant r = new Models.Resturant()
        {
            Name = "Test",
            Address = "Test",
            City = "Test",
            State = "tS",
            FoodType = "Test"
        };
        [TestMethod]
        public void TestAddResturant()
        {
            BusinessLayer.BusinessLibrary bl = new BusinessLayer.BusinessLibrary();
            bl.addResturant(r);
            List<Models.Resturant> list = bl.getAllResturants();

            Assert.AreEqual(r.Name, list[list.Count - 1].Name);
        }

        [TestMethod]
        public void TestUpdateResturant()
        {
            BusinessLayer.BusinessLibrary bl = new BusinessLayer.BusinessLibrary();
            r.Name = "New";
            bl.updateResturant(r);
            List<Models.Resturant> list = bl.getAllResturants();

            Assert.AreEqual(r.Name, list[list.Count - 1].Name);
        }

        [TestMethod]
        public void DeleteResturant()
        {
            BusinessLayer.BusinessLibrary bl = new BusinessLayer.BusinessLibrary();
            r.Name = "New";
            //bl.updateResturant(r);
            List<Models.Resturant> list = bl.getAllResturants();
            int x = list.Count();
            bl.deleteResturant(r);
            List<Models.Resturant> list1 = bl.getAllResturants();
            Assert.AreNotEqual(x,list1.Count);
        }
    }
}
