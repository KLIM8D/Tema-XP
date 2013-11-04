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

        public void Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public void Disable(int value)
        {
            User rUser = GetUserById(value);

            if (rUser == null)
                return;

            rUser.Active = false;
            db.SaveChanges();
        }
    }
}