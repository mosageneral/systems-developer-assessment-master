
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetC.JuniorDeveloperExam.Web.Services
{
    public  class JsonService : IJsonService
    {


        string Path = "~/App_Data/Blog-Posts.json";

        public List<Post> ReturnJsonAll()
        {
           

            var json = System.IO.File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath(Path));
            List<Post> Posts = JsonConvert.DeserializeObject<List<Post>>(json);
            return Posts;
        }

        public Post GetById(int id)
        {
            Post Post = ReturnJsonAll().Find(a => a.Id == id);
            return Post;
        }

        public Post Post(Post post)
        {
            var AllPosts = ReturnJsonAll();
            AllPosts.Add(post);
            var Json = JsonConvert.SerializeObject(AllPosts);
            System.IO.File.WriteAllText(System.Web.HttpContext.Current.Server.MapPath(Path), Json);
            return post;
        }

        public Comment AddComment(Comment Comment)
        {
           
            var json = System.IO.File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath(Path));
            List<Post> Posts = JsonConvert.DeserializeObject<List<Post>>(json);
            foreach (var item in Posts)
            {
                if (item.Id==Comment.PostId)
                {
                    if (item.comments == null)
                    {
                        //It's null - create it
                        item.comments = new List<Comment>();
                    }

                    item.comments.Add(Comment);
                }
            }
            var allpost = Posts;
            var Json = JsonConvert.SerializeObject(Posts);
            System.IO.File.WriteAllText(System.Web.HttpContext.Current.Server.MapPath(Path), Json);
            return Comment;

        }

        public Replay AddReplay(Replay Replay)
        {

            var json = System.IO.File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath(Path));
            List<Post> Posts = JsonConvert.DeserializeObject<List<Post>>(json);
            foreach (var item in Posts)
            {
                if (item.Id == Replay.PostId)
                {
                    foreach (var Comment in item.comments)
                    {
                        if (Comment.Id==Replay.CommentId)
                        {
                            if (Comment.Replays == null)
                            {
                                //It's null - create it
                                Comment.Replays = new List<Replay>();
                            }

                            Comment.Replays.Add(Replay);
                        }
                    }
                }
            }
            var allpost = Posts;
            var Json = JsonConvert.SerializeObject(Posts);
            System.IO.File.WriteAllText(System.Web.HttpContext.Current.Server.MapPath(Path), Json);
            return Replay;

        }
    }
}