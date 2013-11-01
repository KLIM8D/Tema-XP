using Repository.Models;

namespace DBInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BPDbContext())
            {
                /* context.Database.Create(); */
                context.Database.Initialize(force: true);
            }
        }
    }
}