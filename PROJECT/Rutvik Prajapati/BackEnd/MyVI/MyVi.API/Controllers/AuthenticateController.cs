﻿using MyVi.API.Authentication;
using MyVi.API.IRepository;
using MyVi.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyVi.API.Controllers
{
    [Route("api/myvi/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IUser users;
        private readonly IAdmin admins;
        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> userManager;

        public AuthenticateController(IUser user, IAdmin admin, IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            users = user;
            admins = admin;
            _configuration = configuration;
            this.userManager = userManager;
        }

        // POST: api/myvi/authenticate/login
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var username = "";
            var pass = "";
            var role = "";

            if (users.FindName(model.Username) != null)
            {
                username = model.Username;
                pass = model.Password;
                role = "User";
            }
            else if (admins.FindName(model.Username) != null)
            {
                username = model.Username;
                //pass = admins.FindName(model.Username).Password;
                pass = model.Password;
                role = "Admin";
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Incorrect Username or Password!" });
            }

            var newToken = await users.LoginUser(username, pass);

            return Ok(new
            {
                role = role,
                username = username,
                token = newToken
            });

        }

        // POST: api/myvi/authenticate/register
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (users.FindName(model.Username) != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            }

            if (users.FindContact(model.PhoneNumber) != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Contact No. already exists!" });
            }

            var result = await users.RegisterUser(model);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            //users.CreateUser(model);

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });

        }

        // POST: api/myvi/authenticate/register-admin
        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            if (admins.FindName(model.Username) != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Admin already exists!" });
            }

            if (admins.FindContact(model.PhoneNumber) != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Contact no. already exists!" });
            }

            var result = await admins.RegisterAdmin(model);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Admin creation failed! Please check admin details and try again." });

            admins.CreateAdmin(model);

            return Ok(new Response { Status = "Success", Message = "Admin created successfully!" });
        }
    }
}
