using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace WebClient.Models
{
    public class ArtistViewModel : Artist
    {
        public string FullName { get { return base.FirstName + " " + base.SurName; } }
    }
}