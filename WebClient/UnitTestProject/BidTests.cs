using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Models;
using Repository.Resources;

namespace UnitTestProject
{
    [TestClass]
    public class BidTests
    {
        private BidRepository _bidRepository;
        private AuctionRepository _auctionRepository;
        private UserRepository _userRepository;
        private Bid _bid;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void BidTestInitialize()
        {
            Console.Out.Write("BidTestInitialize called...");
            _bidRepository = new BidRepository();
            _auctionRepository = new AuctionRepository();
            _userRepository = new UserRepository();
            _bid = new Bid();
        }

        [TestCleanup]
        public void BidTestCleanup()
        {
            Console.Out.Write("BidTestCleanup called...");
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("Repository, Bid")]
        public void CreateBid()
        {
            _bid.Price = 30;
            _bid.Date = Convert.ToDateTime("2013-11-05 12:00:00");
            _bid.Active = true;
            _bid.Auction = _auctionRepository.GetAuctionById(1);
            _bid.User = _userRepository.GetUserById(_userRepository.GetUserByEMail("unit@testing.io").Id);
            _bidRepository.InsertBid(_bid);
        }


        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Bid")]
        public void GetAllBids()
        {
            Assert.IsNotNull(_bidRepository.GetAllBids().ToList());
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Bid")]
        public void GetAllBidsByAuction()
        {
            Assert.IsNotNull(_bidRepository.GetAllBidsByAuction(_auctionRepository.GetAuctionById(1)).ToList());
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Bid")]
        public void GetAllBidsByUser()
        {
            Assert.IsNotNull(_bidRepository.GetAllBidsByUser(_userRepository.GetUserByEMail("unit@testing.io")).ToList());
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Bid")]
        public void GetBidById()
        {
            Assert.IsNotNull(_bidRepository.GetBidById(1));
        }

        /*[TestMethod]
        [Priority(3)]
        [TestCategory("Repository, Bid")]
        public void DisableBid()
        {
            _bidRepository.DisableBid(_bidRepository.GetBidById(1));
        }*/

        /*[TestMethod]
        [Priority(4)]
        [TestCategory("Repository, Bid")]
        public void DeleteBid()
        {
            _bidRepository.DeleteBid(_bidRepository.GetBidById(1));
        }*/
    }
}
