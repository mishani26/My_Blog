using My_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace My_Blog.Controllers
{
    public class CommentController : Controller
    {
        //
        // GET: /Comment/
        public ContentResult Index()
        {
            return new ContentResult()
            {
                Content = "Why you so series?"
            };
        }
        public ActionResult Recent()
        {
            var model = new RecentDataModel();
            return View(model);
        }

    }
}
