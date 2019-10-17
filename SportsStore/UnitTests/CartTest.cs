using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Domain.Entities;

namespace UnitTests
{
    [TestFixture]
    public class CartTest
    {
        [Test]
        public void Cart_Add_New_Lines()
        {
            Product p1 = new Product { ProductID = 1, Name = "P1" };
            Product p2 = new Product { ProductID = 2, Name = "P2" };

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);

            CartLine[] result = target.Lines.ToArray();

            Assert.AreEqual(result.Length, 2);
            Assert.AreEqual(result[0].Product, p1);
            Assert.AreEqual(result[1].Product, p2);
        }

        [Test]
        public void Cart_Can_Add_Quantity_for_Existing_Lines()
        {
            Product p1 = new Product { ProductID = 1, Name = "P1" };
            Product p2 = new Product { ProductID = 2, Name = "P2" };

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 10);

            CartLine[] result = target.Lines.OrderBy(c=> c.Product.ProductID).ToArray();

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(11, result[0].Quantity );
            Assert.AreEqual(1, result[1].Quantity);
        }

        [Test]
        public void Cart_Can_Remove_Line()
        {
            Product p1 = new Product { ProductID = 1, Name = "P1" };
            Product p2 = new Product { ProductID = 2, Name = "P2" };
            Product p3 = new Product { ProductID = 3, Name = "P3" };

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 3);
            target.AddItem(p3, 5);
            target.AddItem(p2, 1);

            target.RemoveLine(p2);

            CartLine[] result = target.Lines.ToArray();
                        
            Assert.AreEqual(target.Lines.Where(c=> c.Product == p2).Count(),0);
            Assert.AreEqual(target.Lines.Count(), 2);
        }

        [Test]
        public void Cart_Calculate_Cart_Total()
        {
            Product p1 = new Product { ProductID = 1, Name = "P1", Price=100M };
            Product p2 = new Product { ProductID = 2, Name = "P2", Price=50M };
            

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 3);

            decimal result = target.ComputeTotalValue();
                        
            Assert.AreEqual(450M, result);
        }

        [Test]
        public void Cart_Clear_Contents()
        {
            Product p1 = new Product { ProductID = 1, Name = "P1" };
            Product p2 = new Product { ProductID = 2, Name = "P2" };
            
            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);

            target.Clear();

            Assert.AreEqual(target.Lines.Count(), 0);
        }
    }
}
