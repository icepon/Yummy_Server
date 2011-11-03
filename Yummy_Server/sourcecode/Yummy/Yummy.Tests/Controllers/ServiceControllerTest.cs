using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yummy;
using Yummy.Controllers;

namespace Yummy.Tests.Controllers
{
    [TestClass()]
    public class ServiceControllerTest
    {
        [TestMethod]
        public void It_should_return_JsonResult_when_UploadPhoto()
        {
            ServiceController serviceController = new ServiceController();
            ActionResult result = serviceController.UploadPhoto(@"C:\Users\Vee\Documents\Visual Studio 2010\Projects\Yummy\Yummy_Server\sourcecode\Yummy\Yummy\Content\images\coffee_cup.png");
            Assert.IsInstanceOfType(result, typeof(JsonResult));
        }
    }
}
