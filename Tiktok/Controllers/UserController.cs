using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tiktok.Model;
using Tiktok.Service.UserService;

namespace Tiktok.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var result = await _service.GetUsers();
            if (result == null)
            {
                return BadRequest("Empty List");
            }
            return Ok(Result.Success(result));
        }

        [HttpGet]
        public async Task<IActionResult> GetProfile(int id)
        {
            var result = await _service.GetProfile(id);
            if (result == null)
            {
                return BadRequest("Empty List");
            }
            return Ok(Result.Success(result));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVideos()
        {
            var result = await _service.GetAllVideos();
            if (result == null)
            {
                return BadRequest("Empty List");
            }
            return Ok(Result.Success(result));
        }

    }
}
