using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Models;
using Repository.Resources;

namespace UnitTestProject
{
    [TestClass]
    public class UserTests
    {
        private UserRepository _userRepository;
        private User _user;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void UserTestInitialize()
        {
            Console.Out.Write("UserTestInitialize called...");
            _userRepository = new UserRepository();
            _user = new User();
        }

        [TestCleanup]
        public void UserTestCleanup()
        {
            Console.Out.Write("UserTestCleanup called...");
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("Repository, Users")]
        public void CreateUser()
        {
            _user.FirstName = "John";
            _user.SurName = "Doe";
            _user.Address = "Sofiendalsvej 60";
            _user.ZipCode = 9200;
            _user.Email = "unit@testing.io";
            _user.Active = true;
            _userRepository.InsertUser(_user);
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Users")]
        public void GetAllUsers()
        {
            Assert.IsNotNull(_userRepository.GetAllUsers().ToList());
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Users")]
        public void GetUserById()
        {
            Assert.IsNotNull(_userRepository.GetUserById(_userRepository.GetUserByEMail("unit@testing.io").Id));
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("Repository, Users")]
        public void GetUserByEmail()
        {
            Assert.IsNotNull(_userRepository.GetUserByEMail("unit@testing.io"));
        }

        [TestMethod]
        [Priority(3)]
        [TestCategory("Repository, Users")]
        public void DisableUser()
        {
            _userRepository.DisableUser(_userRepository.GetUserByEMail("unit@testing.io"));
        }

        [TestMethod]
        [Priority(4)]
        [TestCategory("Repository, Users")]
        public void RemoveUser()
        {
            _userRepository.DeleteUser(_userRepository.GetUserByEMail("unit@testing.io"));
        }
    }
}