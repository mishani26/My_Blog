//using My_Blog.Repository;
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Web;

//namespace My_Blog.Models
//{
//    public class ArticleModel
//    {
//        public ArticleModel()
//        {
//            Title = "Hello How are you?";
//            Body = "<p>Nunc tincidunt laoreet est, imperdiet elementum tellus dignissim eu. Nunc at sapien dolor. Nam ultrices ultricies turpis a placerat. Fusce aliquam justo a viverra ornare. Fusce eu consequat nisi. Duis vel bibendum metus. Nunc laoreet auctor tortor nec venenatis.</p>";
//            Date = DateTime.Now;
//            Likes = new Collection<LikeModel>();
//           // Comments = new Collection<CommentItemModel>();
//        }
//        public string Title { get; set; }
//        public string Body { get; set; }
//        public DateTime Date { get; set; }
//        public ICollection<LikeModel> Likes { get; set; }
//        //public ICollection<CommentItemModel> Comments { get; set; }
//        public ICollection<string> Comments 
//        {
//            get
//            {
//                return CommentsRepsitory.Comments;

//            }
//        }
//        public AddCommentModel NewComment { get; set; }
//    }
//}
using My_Blog.Repository;
using System;
using System.Collections.Generic;

namespace My_Blog.Models
{
    public class ArticleModel
    {
        private readonly PostModel post;
        private readonly ICollection<string> comments;

        public ArticleModel()
        {
            post = new PostModel(
                "This is an article title",
                "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec dignissim orci dolor, sed sodales nibh molestie nec. In hac habitasse platea dictumst. Integer commodo mi mi, et dapibus nisi mattis eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque tristique ligula a sem molestie pretium. Quisque dolor justo, placerat eu tincidunt in, aliquam at velit. Aenean a tincidunt ipsum. Fusce finibus vel risus quis pulvinar. Vestibulum condimentum vel massa sit amet vestibulum. Suspendisse ante elit, pulvinar eu elit sed, condimentum rhoncus justo. Curabitur auctor, velit vitae posuere efficitur, felis orci fringilla nunc, eget auctor sem quam sed magna. Aenean tristique dui lacinia mauris euismod, at hendrerit nisl volutpat. Sed gravida eleifend ex, eu ultricies nisi convallis vel.</p>",
                DateTime.Now);

        }

        public ArticleModel(PostModel post, ICollection<string> comments)
        {
            this.post = post;
            this.comments = comments;
        }

        public PostModel Post
        {
            get
            {
                return post;
            }
        }

        public ICollection<string> Comments
        {
            get
            {
                return comments;
            }
        }

        public AddCommentModel NewComment { get; set; }
    }
}