using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using Domain.Abstract;
using Domain.Entities;
using WebUI.Controllers;
using WebUI.Models;
using Microsoft.CSharp.RuntimeBinder;

namespace UnitTests
{
    [TestFixture]
    public class NavControllerTest
    {
        [Test]
        public void Menu_Can_Create_Categories()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> {
                new Product { ProductID=1, Name="P1", Category="Apples" },
                new Product { ProductID=2, Name="P2", Category="Apples" },
                new Product { ProductID=3, Name="P3", Category="Plums" },
                new Product { ProductID=4, Name="P4", Category="Oranges" }                
            }.AsQueryable());

            NavController controller = new NavController(mock.Object);
            
            string[] result = ((IEnumerable<string>)controller.Menu().Model).ToArray();

            Assert.AreEqual(result.Length, 3);
            Assert.AreEqual(result[0], "Apples");
            Assert.AreEqual(result[1], "Oranges");
            Assert.AreEqual(result[2], "Plums");
        }

        [Test]
        public void Menu_Indicate_Selected_Category()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> {
                new Product { ProductID=1, Name="P1", Category="Apples" },                
                new Product { ProductID=4, Name="P4", Category="Oranges" }
            }.AsQueryable());

            NavController controller = new NavController(mock.Object);

            string categorySelected = "Apples";

            string result = controller.Menu(categorySelected).ViewBag.SelectedCategory;

            Assert.AreEqual(categorySelected, result);
        }
    }
}
