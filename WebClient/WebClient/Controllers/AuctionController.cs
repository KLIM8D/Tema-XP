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
            viewModel.Expires = DateTime.Now.AddHours(3);
            
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateAuction(AuctionViewModel model)
        {
            if (ModelState.IsValid)
            {
                var repo = new AuctionRepository();
                Auction auction = model.ConvertToBusinessModel();
                auction.Active = true;
                repo.InsertAuction(auction);
            }
            model.Artworks = new ArtworkRepository().GetAllArtworks().ToList();
            return View(model);
        }

        public ActionResult ViewAuctionDetails(int id)
        {
            var repo = new AuctionRepository();
            var model = repo.GetAuctionById(id).ConvertToViewModel();
            model.Bid = repo.GetHighestBid(id) ?? new Bid(){Price = model.MinPrice};
            return View(model);
        }

        [HttpPost]
        public ActionResult ViewAuctionDetails(AuctionViewModel model)
        {
            var bidRepo = new BidRepository();
            var aucRepo = new AuctionRepository();
            var userRepo = new UserRepository();
            var auction = aucRepo.GetAuctionById(model.Id);
            model.Bid = aucRepo.GetHighestBid(model.Id);
            var returnModel = auction.ConvertToViewModel();
            if (model.NextBid.Price > (auction.MinPrice + auction.Interval) && model.NextBid.Price > model.Bid.Price)
            {
                model.NextBid.Auction = auction;
                model.NextBid.Active = true;
                model.NextBid.Date = DateTime.Now;
                model.NextBid.User = userRepo.GetUserById(1);
                bidRepo.InsertBid(model.NextBid);

                auction.Bids.Add(model.NextBid);
                returnModel.Bid = model.NextBid;
                returnModel.ErrorMessage = "Bud på auktionen er godkendt!";
            }
            else
            {
                returnModel.Bid = model.Bid;
                returnModel.ErrorMessage = "Bud for lavt!";
            }

            return View(returnModel);
        }
    }
}
