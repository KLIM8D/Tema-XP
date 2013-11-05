using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Models;
using Repository.Resources;

namespace UnitTestProject
{
    [TestClass]
    public class ArtworkTests
    {
        private ArtworkRepository _artworkRepository;
        private ArtistRepository _artistRepository;
        private CategoryRepository _categoryRepository;
        private Artwork _artwork;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void ArtworkTestInitialize()
        {
            Console.Out.Write("ArtworkTestInitialize called...");
            _artworkRepository = new ArtworkRepository();
            _artistRepository = new ArtistRepository();
            _categoryRepository = new CategoryRepository();
            _artwork = new Artwork();
        }

        [TestCleanup]
        public void ArtworkTestCleanup()
        {
            Console.Out.Write("ArtworkTestCleanup called...");
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("Repository, Artwork")]
        public void CreateArtwork()
        {
            _artwork.Title = "Unit Testing";
            _artwork.Description = "N/A";
            _artwork.Price = 1000;
            _artwork.SizeHeight = 25;
            _artwork.SizeWidth = 25;
            _artwork.Date = Convert.ToDateTime("2013-11-05 00:00:00");
            _artwork.ImgFileName = "none.png";
            _artwork.Artist = _artistRepository.GetArtistById(_artistRepository.GetArtistByFullName("Unit Test").Id);
            _artwork.Category = _categoryRepository.GetCategoryById(_categoryRepository.GetCategoryByTitle("Unit Test").Id);
            _artwork.Active = true;
            _artworkRepository.InsertArtwork(_artwork);
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Artwork")]
        public void GetAllArtworks()
        {
            Assert.IsNotNull(_artworkRepository.GetAllArtworks());
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Artwork")]
        public void GetArtistsById()
        {
            Assert.IsNotNull(_artworkRepository.GetArtworkById(_artworkRepository.GetArtworkByTitle("Unit Testing").Id));
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Artwork")]
        public void GetArtistsByTitle()
        {
            Assert.IsNotNull(_artworkRepository.GetArtworkByTitle("Unit Testing"));
        }

        /*[TestMethod]
        [Priority(3)]
        [TestCategory("Repository, Artwork")]
        public void DisableArtwork()
        {
            _artworkRepository.DisableArtwork(_artworkRepository.GetArtworkByTitle("Unit Testing"));
        }*/

        /*[TestMethod]
        [Priority(4)]
        [TestCategory("Repository, Artwork")]
        public void DeleteArtwork()
        {
            _artworkRepository.DeleteArtwork(_artworkRepository.GetArtworkByTitle("Unit Testing"));
        }*/
    }
}