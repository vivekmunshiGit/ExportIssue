using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExportMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void Export()
        {
            Response.Clear();

            Response.Buffer = true;

            Response.AddHeader("content-disposition",

            "attachment;filename=GridViewExport.doc");

            Response.Charset = "";

            Response.ContentType = "application/vnd.ms-word ";

            Response.Output.Write("Hello I am Vivek!");

            Response.Flush();

            Response.End();
          //return Json("Hello", JsonRequestBehavior.AllowGet);
        }

        public void ExportNew()
        {
            var stream = new MemoryStream();
                var writer = new StreamWriter(stream);
                writer.Write("Don");
                writer.Flush();
                stream.Position = 0;
            Session["str"] = stream;

        }

        public ActionResult DummmyExportNew()
        {
            Stream stream = (Stream)Session["str"];
            return File(stream, "application/vnd.ms-word", "Abc.pdf");
        }

        public void DummmyExport()
        {
            
        }

    }
}