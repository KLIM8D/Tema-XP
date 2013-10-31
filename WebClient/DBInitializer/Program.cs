using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Models;

namespace DBInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BPDbContext())
            {
                var dbtmp = new Artwork { Title = "tmp" };
                db.Artworks.Add(dbtmp);
                db.SaveChanges();

                Console.WriteLine("done!");
            }
        }
    }
}
