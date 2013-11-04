using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository.Models;
using Repository.Resources;
using WebClient.Models;
using WebClient.Helpers;


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

        public ActionResult CreateArtwork()
        {
            var viewModel = new ArtworkViewModel();
            viewModel.Artists = new ArtistRepository().GetAllArtist().ToList().ConvertToViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateArtwork(ArtworkViewModel model)
        {
            return View(model);
        }
    }
}
