using Microsoft.AspNetCore.Mvc;
using MovieRental.Data;
using MovieRental.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRental.Endpoint.Controllers
{
    [Route("controller")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        IMovieLogic logic;

        public MovieController(IMovieLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IEnumerable<Movie> ReadAll()
        {
            return this.logic.GetAllMovies();
        }

        [HttpGet("{id}")]
        public Movie Read(int id)
        {
            return this.logic.GetOneMovie(id);
        }

        [HttpPost]
        public void Create([FromBody] string title, string distributor, string category, string length, string language, int rentId)
        {
            this.logic.CreateMovie(title, distributor, category, length, language, rentId);
        }

        [HttpPut]
        public void UpdateTitle([FromBody] int id, string title)
        {
            this.logic.ChangeMovieTitle(id, title);
        }

        [HttpPut]
        public void UpdateDistributor([FromBody] int id, string distributor)
        {
            this.logic.ChangeMovieDistributor(id, distributor);
        }

        [HttpPut]
        public void UpdateCategory([FromBody] int id, string category)
        {
            this.logic.ChangeMovieCategory(id, category);
        }

        [HttpPut]
        public void UpdateLength([FromBody] int id, string length)
        {
            this.logic.ChangeMovieLength(id, length);
        }

        [HttpPut]
        public void UpdateLanguage([FromBody] int id, string language)
        {
            this.logic.ChangeMovieLanguage(id, language);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.logic.DeleteMovie(id);
        }
    }
}
