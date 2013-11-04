using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace WebClient.Models
{
    public class CategoryViewModel : Category
    {
        public string CategoryTitle { get { return base.Title; } }
    }
}
