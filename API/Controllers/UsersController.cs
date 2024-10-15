using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UsersController(IUnitOfWork unitOfWork) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await unitOfWork.UserRepository.GetUsersAsync();

            return Ok(users);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await unitOfWork.UserRepository.GetUserByIdAsnyc(id);

            if (user == null) return NotFound();

            return Ok(user);
        }

    }
}
