using Microsoft.AspNetCore.Mvc;
using Jwt.Constants;
using Jwt.Models;
using System.Collections.Generic;
using System.Linq;

namespace Jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet("activos")]
        public ActionResult<List<UserModel>> GetUsuariosActivos()
        {
            var usuariosActivos = UserConstants.Users
                .Where(u => u.IsActive)
                .ToList();

            return Ok(usuariosActivos);
        }
    }
}
