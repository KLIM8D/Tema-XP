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
            List<Artwork> artworks = new ArtworkRepository().GetAllArtworks();
            return View(artworks);
        }

        public ActionResult CreateArtwork()
        {
            var viewModel = new ArtworkViewModel();
            viewModel.Artists = new ArtistRepository().GetAllArtist().ToList().ConvertToViewModel();
            viewModel.Categories = new CategoryRepository().GetAllCategories().ToList().ConvertToViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateArtwork(ArtworkViewModel model)
        {
            if (ModelState.IsValid)
            {
                var repo = new ArtworkRepository();
                Artwork artwork = model.ConvertToBusinessModel();
                artwork.Active = true;
                artwork.Date = DateTime.Now;
                repo.InsertArtwork(artwork);
            }
            model.Artists = new ArtistRepository().GetAllArtist().ToList().ConvertToViewModel();
            model.Categories = new CategoryRepository().GetAllCategories().ToList().ConvertToViewModel();

            return View(model);
        }
    }
}
