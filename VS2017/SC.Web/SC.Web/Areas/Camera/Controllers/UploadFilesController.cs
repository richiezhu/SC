using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SC.Web.Areas.Camera.Controllers
{
    [Area("Camera")]
    public class UploadFilesController : Controller
    {
        public IActionResult iframe()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult upload(string fname)
        {
            
            //string Pic_Path = Request.MapPath("MyPicture.png");
            //using (FileStream fs = new FileStream(Pic_Path, FileMode.Create))
            //{
            //    using (BinaryWriter bw = new BinaryWriter(fs))
            //    {
            //        byte[] data = Convert.FromBase64String(imageData);
            //        bw.Write(data);
            //        bw.Close();
            //    }
            //}

            return Json(new { result = true, msg = "tt" });
        }
    }
}