using System;
using System.Web;
using System.Web.Mvc;
using NUnit.Framework;
using WebUI.HtmlHelpers;
using WebUI.Models;

namespace UnitTests
{
    [TestFixture]
    public class PagingHelperTest
    {
        [Test]
        public void PageLinks_Can_Generate_Page_Links()
        {
            HtmlHelper myHelper = null;

            PagingInfo pagingInfo = new PagingInfo { CurrentPage = 2, TotalItems = 28, ItemsPerPage = 10 };

            Func<int, string> pageUrlDelegate = i => "Page" + i;

            MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegate);

            Assert.AreEqual(result.ToString(), @"<a href=""Page1"">1</a><a class=""selected"" href=""Page2"">2</a><a href=""Page3"">3</a>");
        }
    }
}
