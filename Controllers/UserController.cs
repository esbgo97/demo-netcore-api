
using System;
using System.Threading.Tasks;
using crud_netcore.Business;
using crud_netcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_netcore.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _userService;
        public UserController(IUserBusiness userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _userService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] UserModel user)
        {
            try
            {
                return Ok(await _userService.Create(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UserModel user)
        {
            try
            {
                return Ok(await _userService.Update(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int  idUser)
        {
            try
            {
                return Ok(await _userService.Delete(idUser));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}