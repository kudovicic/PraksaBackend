using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_praksa.Services;
using api_praksa.Services.UserService;
using api_praksa.Services.PostService;
using Microsoft.AspNetCore.Mvc;


namespace api_praksa.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _userService;
        
        //konstruktor
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

      
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _userService.GetUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }


        // GET: api/values
        [HttpGet("/admin/listofusers")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Post 1", "Post 2" };
        }

        // GET api/values/5
        [HttpGet("/admin/listofuser/{id}")]
        public string Get(int id)
        {
            return "Post by ID-1";
        }



        // POST api/values
        [HttpPost("/register")]
        public void Register([FromBody] string value)
        {

        }

        // GET api/values/5
        [HttpGet("/login")]
        public string Login(int id)
        {
            return "Post by ID-1";
        }


        // DELETE api/values/5
        [HttpDelete("/admin/listofusers/{id}")]
        public void Delete(int id)
        {
        }
    }
}

