using System;
using System.Data.Entity;
using Repository.Models;

namespace DBInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BPDbContext())
            {
                context.Database.Initialize(force: true);
                Console.WriteLine("Database initializer done! Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}