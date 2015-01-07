using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Blog.Models
{
    public class RecentDataItemModel:ArticleModel
    {
        public RecentDataItemModel()
        {
            Text = "Linc";
            URL = "https://www.google.by/";
            Date = DateTime.Now.AddDays(-1);
            ID = 777;
        }
        public string Text { get; set; }
        public string URL { get; set; }
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public ICollection<ArticleModel> Items;

    }
}