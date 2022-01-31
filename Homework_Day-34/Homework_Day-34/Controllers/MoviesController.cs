using Microsoft.AspNetCore.Mvc;
using MoviesService;
using MoviesService.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Day_34.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase

    {

        private readonly ISingletonMovieService _movieservice;

        public MoviesController(ISingletonMovieService movieservice)
        {
            _movieservice = movieservice;
        }

        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetAll()
        {
            return Ok(await _movieservice.GetAllMovies());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            return Ok(await _movieservice.GetMovieAsync(id));
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Movie movie)
        {
            await _movieservice.AddMovieAsync(movie);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _movieservice.DeleteMovie(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id,[FromBody]Movie movie)
        {
            await _movieservice.PutMovie(id, movie);
            return Ok();
        }
    }
}
