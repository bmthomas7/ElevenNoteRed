using ElevenNote.Models;
using ElevenNote.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            var userid = Guid.Parse(User.Identity.GetUserId());
            var service = new NoteService(userid);
            var model = new NoteListItem[0];
            return View(model);
        }

        // add method here vvvv
        // get

        public ActionResult Create()
        {
            return View();
        }

        // add code here vvvv

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NoteCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());

            var service = new NoteService(userId);


            service.CreateNote(model);


            return RedirectToAction("Index");
        }
    }
}