using LK_API.Data.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LK_API.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("login/{username}/{password}")]

        public IHttpActionResult Login(string username, string passWord)
        {
            var l = new UserDAO().LoginAsync(username, passWord);
            
            return Ok();
        }
    }
}
