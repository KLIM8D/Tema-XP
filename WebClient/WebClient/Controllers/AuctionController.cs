﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult CreateAuction(AuctionViewModel model)
        {
            return View(model);
        }
    }
}