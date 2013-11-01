using Repository.Models;

namespace DBInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BPDbContext();
            db.Database.Create();
        }
    }
}