using My_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using My_Blog.Repository;

namespace My_Blog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index(string title)
        {
            if (title == null)
            {
                title = "My first title";
            }
            var readers = new NewDataReaders();
            return View(readers.GetArticleModel(title));
        }
        
        [HttpPost]
        public ActionResult Index(ArticleModel model)
        {

            var title = "My first title";

            if (model.NewComment != null && ModelState.IsValid)
            {
                var readers = new NewDataReaders();
                readers.AddComment(title, model.NewComment.Comment);
                //CommentsRepsitory.Comments.Add(model.NewComment.Comment);
                ModelState.Clear();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
