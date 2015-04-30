using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace GnuggisWebApi.Models
{
    public class UsersViewModel
    {
        public int Count { get; set; }
        public List<ApplicationUser> Users { get; set; }
    }
}