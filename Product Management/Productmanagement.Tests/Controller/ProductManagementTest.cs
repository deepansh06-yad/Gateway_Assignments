using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Http;
using ProductManagement.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Models;
using ProductManagement;

namespace Productmanagement.Tests.Controllers
{
    [TestClass]
    class ProductManagementTest
    {
        [TestMethod]
        public void Index()
        {
            productController product = new productController();

            //Act
            var pc = product.Index(1,"Mi 9 pro");

            Assert.IsNotNull(pc);
        }
        [TestMethod]
        public void ProductList()
        {
            ProductdbEntities db = new ProductdbEntities();

            //Act
            var result = db.Productslists.ToList();

            //Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CreateorEdit(int id)
        {
            productController pro = new productController();

            //Act
            pro.CreateorEdit(0);

            //Assert
            
        }
    }
}
