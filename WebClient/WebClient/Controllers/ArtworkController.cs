using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Models;


namespace WebClient.Controllers
{
    public class ArtworkController : Controller
    {
        //
        // GET: /Artwork/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            List<Artwork> a = new List<Artwork>();
            return View(a);
        }
    }
}
