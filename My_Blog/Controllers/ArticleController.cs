using My_Blog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_Blog.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

        [HttpGet]
        public ActionResult Recent(string body)
        {
            if (body == null)
            {
                body = "My first body";
            }
            var readers = new NewDataReaders();
            return View(readers.ShowComments(body));
        }

    }
}
