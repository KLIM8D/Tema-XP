using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Models;
using Repository.Resources;

namespace UnitTestProject
{
    [TestClass]
    public class ArtistTests
    {
        private ArtistRepository _artistRepository;
        private Artist _artist;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void ArtistTestInitialize()
        {
            Console.Out.Write("ArtistTestInitialize called...");
            _artistRepository = new ArtistRepository();
            _artist = new Artist();
        }

        [TestCleanup]
        public void ArtistTestCleanup()
        {
            Console.Out.Write("ArtistTestCleanup called...");
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("Repository, Artist")]
        public void CreateArtist()
        {
            _artist.FirstName = "Unit";
            _artist.SurName = "Test";
            _artist.Active = true;
            _artistRepository.InsertArtist(_artist);
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Artist")]
        public void GetAllArtists()
        {
            Assert.IsNotNull(_artistRepository.GetAllArtist().ToList());
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Artist")]
        public void GetArtistById()
        {
            Assert.IsNotNull(_artistRepository.GetArtistById(_artistRepository.GetArtistByFullName("Unit Test").Id));
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Artist")]
        public void GetArtistByFullName()
        {
            Assert.IsNotNull(_artistRepository.GetArtistByFullName("Unit Test"));
        }

        /*[TestMethod]
        [Priority(3)]
        [TestCategory("Repository, Artist")]
        public void DisableArtist()
        {
            _artistRepository.DisableArtist(_artistRepository.GetArtistByFullName("Unit Test"));
        }*/

        /*[TestMethod]
        [Priority(4)]
        [TestCategory("Repository, Artist")]
        public void DeleteArtist()
        {
            _artistRepository.DeleteArtist(_artistRepository.GetArtistByFullName("Unit Test"));
        }*/
    }
}