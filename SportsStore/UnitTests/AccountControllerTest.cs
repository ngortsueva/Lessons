using System;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using WebUI.Controllers;
using WebUI.Infrastructure.Abstract;
using WebUI.Models;

namespace UnitTests
{
    [TestFixture]
    public class AccountControllerTest
    {
        [Test]
        public void Can_Login_with_Valid_Credentials()
        {
            Mock<IAuthProvider> mock = new Mock<IAuthProvider>();

            mock.Setup(m => m.Authenticate("admin", "12345")).Returns(true);

            LogOnViewModel model = new LogOnViewModel {
                UserName = "admin",
                Password = "12345"
            };

            AccountController target = new AccountController(mock.Object);

            ActionResult result = target.LogOn(model, "/MyUrl");

            Assert.IsInstanceOf(typeof(RedirectResult), result);
            Assert.AreEqual("/MyUrl", ((RedirectResult)result).Url);
        }

        [Test]
        public void Cannot_Login_with_Invalid_Credentials()
        {
            Mock<IAuthProvider> mock = new Mock<IAuthProvider>();

            mock.Setup(m => m.Authenticate("badUser", "badPassword")).Returns(false);

            LogOnViewModel model = new LogOnViewModel
            {
                UserName = "badUser",
                Password = "badPassword"
            };

            AccountController target = new AccountController(mock.Object);

            ActionResult result = target.LogOn(model, "/MyUrl");

            Assert.IsInstanceOf(typeof(ViewResult), result);

            Assert.IsFalse(((ViewResult)result).ViewData.ModelState.IsValid);
        }
    }
}
