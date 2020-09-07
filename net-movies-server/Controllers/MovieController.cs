using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchMovieServer.Models;
using SearchMovieServer.Service;

namespace SearchMovieServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService _movieService;
        Result result = new Result();

        public MovieController(MovieService service)
        {
            _movieService = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movies>>> GetAll()
        {
            try
            {
               var get_movies = await _movieService.GetAllAsync();
               return Ok(get_movies);
            }
            catch (Exception ex)
            {
                result.Message = "Error to get movies";
                result.Status = 404;
                result.Error = ex;
                return BadRequest(result);
            }
        }
        [HttpGet("categorys")]
        public async Task<ActionResult<IEnumerable<Movies>>> GetAllCategorys()
        {
            try
            {
                var get_moviesCategorys = await _movieService.GetAllCategorysAsync();
                
                if (get_moviesCategorys.Count != 0)
                    return Ok(get_moviesCategorys);

                result.Message = "No connect";
                return BadRequest(result);
            }
            catch (Exception ex)
            {

                result.Message = "Error to get Types";
                result.Status = 404;
                result.Error = ex;
                return BadRequest(result);
            }
        }

        public async Task<ActionResult<Movies>> GetById(string id)
        {
            var student = await _movieService.GetByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movies movies)
        {
            try
            {
                await _movieService.CreateAsync(movies);
            }
            catch (Exception ex)
            {
                result.Message = "Error create new movie";
                result.Status = 404;
                result.Error = ex;
                return BadRequest(result);
            }
            return Ok(movies);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Movies movies)
        {
            try
            {

                await _movieService.UpdateAsync(id, movies);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return NoContent();

        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            var student = await _movieService.GetByIdAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            await _movieService.DeleteAsync(id);
            return NoContent();
        }
    }
}