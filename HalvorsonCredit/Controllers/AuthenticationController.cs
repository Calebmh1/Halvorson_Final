using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HalvorsonCredit.Data;
using HalvorsonCredit.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace HalvorsonCredit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly HalvorsoncreditContext _context;


        private readonly JwtAuthenticationManager authManager;

        public AuthenticationController(HalvorsoncreditContext context, JwtAuthenticationManager authManager)
        {
            _context = context;
            this.authManager = authManager;
        }


        [AllowAnonymous]
        [HttpPost("Authorize")]
        public IActionResult AuthUser([FromBody] user usr)
        {

            var token = authManager.Authenticate(usr.username, usr.password);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }




    }
}