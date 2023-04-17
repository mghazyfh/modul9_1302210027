using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Reflection;
using modul9_1302210027;

namespace modul9_1302210027.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : ControllerBase
    {
        private static List<Movie> data = new List<Movie>
        {
            new Movie()
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new[]{"Tim Robbins", "Morgan Freeman", "Bob Gunton"},
                Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."
            },
             new Movie()
             {
                 Title = "The Godfather",
                  Director = "Francis Ford Coppola",
                 Stars = new[]{"Marlon Brando", "Al Pacino", "James Caan"},
                 Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."
             },
             new Movie()
             {
                 Title = "The Dark Knight",
                 Director = "Christopher Nolan",
                 Stars = new[]{"Christian Bale", "Heath Ledger", "Aaron eckhart"},
                 Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."
             }
        };

        public static List<Movie> Data { get => data; set => data = value; }

        // GET: api/<Movies>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return Data;
        }

        // GET api/<Movies>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            if (id < 0 || id >= Data.Count)
            {
                NotFound();
            }
            return Data[id];
        }

        // POST api/<Movies>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            Data.Add(value);
        }
        // DELETE api/<Movies>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= Data.Count)
            {
                NotFound();
            }
            Data.RemoveAt(id);
        }
    }
}
