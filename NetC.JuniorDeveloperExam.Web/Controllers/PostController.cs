using Model;
using Model.Models;
using NetC.JuniorDeveloperExam.Web.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class PostController : Controller
    {
        public PostController()
        {

        }
        private readonly IJsonService js;
        public PostController(IJsonService js)
        {
            this.js = js;
        }

        // GET: Post
     
        public ActionResult Index()
        {

            return View(js.ReturnJsonAll()); ;
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
          var Post= js.GetById(id);
            return View(Post);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
            Random random = new Random();

                post.Id = random.Next(1000);
                post.date = DateTime.Now;
                js.Post(post);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public Comment AddComment(Comment Comment)
        {
            Random random = new Random();
            Comment.Id= random.Next(1000);
            Comment.date = DateTime.Now;
         
              
            js.AddComment(Comment);
            return Comment;
        }
        [HttpPost]
        public Replay AddReplay(Replay Replay)
        {
            Random random = new Random();
            Replay.Id = random.Next(1000);
            Replay.date = DateTime.Now;


            js.AddReplay(Replay);
            return Replay;
        }
        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
