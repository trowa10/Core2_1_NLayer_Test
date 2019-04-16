﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMS.DOMAIN;
using LMS.SERVICE;
using Microsoft.AspNetCore.Mvc;

namespace LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserService _userService;
        public ValuesController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/values
        [HttpGet]
        public async Task<ICollection<User>> Get()
        {
             return await _userService.GetUser();

            //return null;
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
