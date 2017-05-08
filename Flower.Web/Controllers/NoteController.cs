using Flower.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flower.Web.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
      //      var model = new NoteListItemModel[0];
            var model = new NoteListItem[0];

            return View(model);
        }

        // CREATE: Note
        
        public ActionResult Create()
        {
            return View();
        }
    }
}
