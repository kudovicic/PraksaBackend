using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_praksa.Controllers.Models;
using api_praksa.Services;
using api_praksa.Services.PostService;

namespace api_praksa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class PostController : ControllerBase
    {

        private readonly IPostService _postService;

        //konstruktor
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]

        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _postService.GetUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }





        //Get svih Postova
        [HttpGet("/admin/createpost")]
        public async Task<ActionResult<List<Post>>> GetAllPosts()
        {
            return _postService.GetAllPosts();
        }



        //Get pojedinog posta
        [HttpGet("/admin/createpost/{id}")]
        public async Task<ActionResult<Post>> GetSinglePost(int id)
        {
            var result = _postService.GetSinglePost(id);

            if (result is null)
                return NotFound("Ne postoji Post");


            return Ok(result);
        }


        //dodavanje Posta
        [HttpPost("/admin/createpost")]
        public async Task<ActionResult<List<Post>>> AddPost(Post postId)
        {
            var result = _postService.AddPost(postId);

            

            return Ok(result);
        }

        //Update Posta
        [HttpPut("/admin/createpost/{id}")]
        public async Task<ActionResult<List<Post>>> UpdatePost(int id,Post request)
        {
            var result = _postService.UpdatePost(id,request);

            if (result is null)
                return NotFound("Ne postoji Post");


            return Ok(result);
        }

        //Brisanje Posta
        [HttpDelete("/admin/createpost/{id}")]
        public async Task<ActionResult<List<Post>>> DeletePost(int id)
        {

            var result = _postService.DeletePost(id);

            if (result is null)
                return NotFound("Ne postoji Post");

            
            return Ok(result);
        }









    }
}

