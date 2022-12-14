using Contentful.Core.Models;
using System;

namespace code.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Runtime { get; set; }
        public float IMDBRating { get; set; }
        public string RTRating { get; set; }
        public Asset Poster { get; set; }
    }
}