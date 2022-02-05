using AliaksandrWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaksandrWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AuthenticationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public AuthenticationResult Authenticate([FromBody] AuthenticationRequest model)
        {
            try
            {
                var usr = _context.Users.FirstOrDefault(x => x.Email == model.Username);
                if(usr==null||usr.Password!=model.Password)
                {
                    return AuthenticationResult.AuthenticationFailed;
                }
                return AuthenticationResult.AuthenticationSucceeded;
            }
            catch(Exception e)
            {
                return new AuthenticationResult()
                {
                    Result = "An error has occured. Please retry later"
                };
            }
        }

        [HttpPost]
        public string Register([FromBody] UserModel model)
        {
            try
            {
                var usr = _context.Users.FirstOrDefault(x => x.Email == model.Email);
                if (usr !=null)
                {
                    return "User already exists";
                }
                _context.Users.Add(new Models.User()
                {
                    Email = model.Email,
                    Password = model.Password
                });
                _context.SaveChanges();
                return "Success";
            }
            catch (DbUpdateException e)
            {
                return e.InnerException.Message;
            }
        }
    }

    public class AuthenticationResult
    {
        public bool Succeeded { get; set; }
        public string Result { get; set; }

        public static AuthenticationResult AuthenticationSucceeded
        {
            get
            {
                return new AuthenticationResult()
                {
                    Succeeded = true,
                    Result = "Success"
                };
            }
        }
        public static AuthenticationResult AuthenticationFailed
        {
            get
            {
                return new AuthenticationResult()
                {
                    Result = "Invalid username/password"
                };
            }
        }
    }

    public class AuthenticationRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

     public class UserModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
