using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.DOMAIN;
using LMS.MANAGER;
using LMS.MANAGER.Model;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserManager _userManager;
        //public ValuesController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        public ValuesController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        // GET api/values
        //[HttpGet]
        //public async Task<ICollection<User>> Get()
        //{
        //     //return await _userService.GetUser();

        //    return null;
        //}

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            return _userManager.GetUsers();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
