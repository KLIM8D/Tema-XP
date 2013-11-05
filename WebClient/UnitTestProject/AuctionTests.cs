using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Models;
using Repository.Resources;

namespace UnitTestProject
{
    [TestClass]
    public class AuctionTests
    {
        private AuctionRepository _auctionRepository;
        private ArtworkRepository _artworkRepository;
        private BidRepository _bidRepository;
        private Auction _auction;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void AuctionTestInitialize()
        {
            Console.Out.Write("AuctionTestInitialize called...");
            _auctionRepository = new AuctionRepository();
            _artworkRepository = new ArtworkRepository();
            _bidRepository = new BidRepository();
            _auction = new Auction();
        }

        [TestCleanup]
        public void AuctionTestCleanup()
        {
            Console.Out.Write("AuctionTestCleanup called...");
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("Repository, Auction")]
        public void CreateAuction()
        {
            _auction.MinPrice = 1000000;
            _auction.Interval = 10;
            _auction.Expires = Convert.ToDateTime("2014-11-05 00:00:00");
            _auction.Active = true;
            _auction.Artwork = _artworkRepository.GetArtworkByTitle("Unit Testing");
            _auction.Bids = _bidRepository.GetAllBidsByAuction(_auctionRepository.GetAuctionById(1)).ToList();
            _auctionRepository.InsertAuction(_auction);
        }


        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Auction")]
        public void GetAllAuctions()
        {
            Assert.IsNotNull(_auctionRepository.GetAllAuctions().ToList());
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Auction")]
        public void GetAuctionById()
        {
            Assert.IsNotNull(_auctionRepository.GetAuctionById(1));
        }

        [TestMethod]
        [Priority(3)]
        [TestCategory("Repository, Auction")]
        public void DisableAuction()
        {
            _auctionRepository.DisableAuction(_auctionRepository.GetAuctionById(1));
        }

        /*[TestMethod]
        [Priority(4)]
        [TestCategory("Repository, Auction")]
        public void DeleteAuction()
        {
            _auctionRepository.DeleteAuction(_auctionRepository.GetAuctionById(1));
        }*/
    }
}