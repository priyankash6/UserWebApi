using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserWebApi.Model;
using UserWebApi.Repositories;

namespace UserWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userRepository.Get();
        }
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            var newUser = await _userRepository.Create(user);
            return CreatedAtAction(nameof(GetUsers), new { id = newUser.ID }, newUser);
        }
    }
}
