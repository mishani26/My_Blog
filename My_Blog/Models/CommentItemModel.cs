using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Blog.Models
{
    public class CommentItemModel
    {
        public CommentItemModel()
        {
            Username = "Micheal";
            Body = "Your comments";
            Date = DateTime.Now;
        }
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }

    }
}