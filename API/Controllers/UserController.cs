using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DatingApp.API.Controllers
{ 
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : ControllerBase
    {
        private readonly IDatingRepository _repo;
        private readonly DataContext _context;
        public UserController(IDatingRepository repo, DataContext context )
        {
            _context = context;
            _repo = repo;
        }
        [HttpGet("test")]
        public ActionResult<IEnumerable<User>> GetUsersTest()
        {
            Console.WriteLine("test");
            var users = _context.Users.ToList();
            return users;
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            Console.WriteLine("zzzzzzzzzzzzzz");
            var users = await _repo.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);
            return Ok(user);
        }

    }
}