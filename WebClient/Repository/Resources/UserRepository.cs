using System.Linq;
using Repository.Models;

namespace Repository.Resources
{
    public class UserRepository
    {
        private BPDbContext db;

        public UserRepository()
        {
            db = new BPDbContext();
        }

        public IQueryable<User> GetAllUsers()
        {
            return db.Users;
        }

        public User GetUserById(int value)
        {
            return db.Users.FirstOrDefault(x => x.Id == value);
        }

        public User GetUserByEMail(string value)
        {
            return db.Users.FirstOrDefault(x => x.Email == value);
        }

        public void InsertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void DisableUser(User user)
        {
            db.Users.Add(user).Active = false;
            db.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}