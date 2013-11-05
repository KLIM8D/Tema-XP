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
    public class AuctionController : Controller
    {
        //
        // GET: /Auction/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateAuction()
        {
            //var artists = new ArtistRepository().GetAllArtist().ToList();
            //Artists = artists.ConvertToViewModel(
            var viewModel = new AuctionViewModel();
            viewModel.Artworks = new ArtworkRepository().GetAllArtworks().ToList();
            viewModel.Expires = DateTime.Now;
            
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateAuction(AuctionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var repo = new AuctionRepository();
                Auction auction = model.ConvertToBusinessModel();
                repo.InsertAuction(auction);
            }
            model.Artworks = new ArtworkRepository().GetAllArtworks().ToList();
            return View(model);
        }

        public ActionResult ViewAuctionDetails(int id)
        {
            var repo = new AuctionRepository();
            var model = repo.GetAuctionById(id).ConvertToViewModel();
            model.Bid = repo.GetHighestBid(model.ArtistId);
            return View(model);
        }

        [HttpPost]
        public ActionResult ViewAuctionDetails(AuctionViewModel model)
        {
            return View(model);
        }
    }
}
