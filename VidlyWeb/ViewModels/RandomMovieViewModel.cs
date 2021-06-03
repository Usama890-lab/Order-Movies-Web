using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyWeb.Models;

namespace VidlyWeb.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
