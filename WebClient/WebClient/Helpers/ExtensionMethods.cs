using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;
using WebClient.Models;

namespace WebClient.Helpers
{
    public static class ExtensionMethods
    {
        public static List<ArtistViewModel> ConvertToViewModel(this List<Artist> artists)
        {
            var returnList = new List<ArtistViewModel>();
            artists.ForEach(x => returnList.Add(
                new ArtistViewModel
                                {
                                    Active = x.Active,
                                    FirstName = x.FirstName,
                                    SurName = x.SurName,
                                    Id = x.Id,
                                    Artworks = x.Artworks
                                }
                ));
            return returnList;
        }
    }
}