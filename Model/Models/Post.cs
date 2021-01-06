using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class Post
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string htmlContent { get; set; }
        public List<Comment> comments { get; set; }
    }
}
