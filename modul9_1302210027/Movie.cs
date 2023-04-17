using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace modul9_1302210027
{
    public class Movie
    {

        public string Title { get;  set; }
        public string Director { get;  set; }
        public string[] Stars { get;  set; }
        public string Description { get;  set; }

        public Movie() { }
        public Movie (string title, string director, string[]  stars, string description) { this.Title = title; this.Director = director; this.Stars = stars; this.Description = description; }
    }
}
