using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlickrNet;

namespace Yummy.Controllers
{
    public class ServiceController : Controller
    {
        public ServiceController()
        {
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UploadPhoto(string fileName)
        {
            return new JsonResult() { Data = "Upload Successed" };
        }
    }
}
