using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace SC.WebEF.Areas.Camera.Controllers
{
    public class UploadFilesController : Controller
    {
        // GET: Camera/UploadFiles
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult iframe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult upload(string img, string fname)
        {

            string pth = Request.MapPath("/attachment/temp/");
            if (!Directory.Exists(pth)) Directory.CreateDirectory(pth);

            if (string.IsNullOrWhiteSpace(fname)) fname = DateTime.Now.ToString("yyyyMMddHHmmssfff");

            string filePath = pth + fname;
            string msgstr = "";
            bool result = true;

            try
            {

                if (Request.Files!=null && Request.Files.Count>0)
                {
                    HttpPostedFileBase file = Request.Files[0];
                    if (file != null)
                    {
                        if (System.IO.File.Exists(filePath)) System.IO.File.Delete(filePath);
                        file.SaveAs(filePath);
                    }
                }

            }
            catch
            {
                result = false;
                msgstr = "Upload error.";
            }



            return Json(new { result = result, msg = msgstr });
        }

    }
}