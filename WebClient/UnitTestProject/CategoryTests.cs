using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Models;
using Repository.Resources;

namespace UnitTestProject
{
    [TestClass]
    public class CategoryTests
    {
        private CategoryRepository _categoryRepository;
        private Category _category;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void CategoryTestInitialize()
        {
            Console.Out.Write("CategoryTestInitialize called...");
            _categoryRepository = new CategoryRepository();
            _category = new Category();
        }

        [TestCleanup]
        public void CategoryTestCleanup()
        {
            Console.Out.Write("CategoryTestCleanup called...");
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("Repository, Category")]
        public void CreateCategory()
        {
            _category.Title = "Unit Test";
            _category.Active = true;
            _categoryRepository.InsertCategory(_category);
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Category")]
        public void GetAllCategories()
        {
            Assert.IsNotNull(_categoryRepository.GetAllCategories().ToList());
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Category")]
        public void GetCategoryById()
        {
            Assert.IsNotNull(_categoryRepository.GetCategoryById(_categoryRepository.GetCategoryByTitle("Unit Test").Id));
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Category")]
        public void GetCategoryByTitle()
        {
            Assert.IsNotNull(_categoryRepository.GetCategoryByTitle("Unit Test"));
        }

        /*[TestMethod]
        [Priority(3)]
        [TestCategory("Repository, Category")]
        public void DisableCategory()
        {
            _categoryRepository.DisableCategory(_categoryRepository.GetCategoryByTitle("Unit Test"));
        }*/

        /*[TestMethod]
        [Priority(4)]
        [TestCategory("Repository, Category")]
        public void DeleteCategory()
        {
            _categoryRepository.DeleteCategory(_categoryRepository.GetCategoryByTitle("Unit Test"));
        }*/
    }
}