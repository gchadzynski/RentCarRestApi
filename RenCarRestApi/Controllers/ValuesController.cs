using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace RenCarRestApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ILoggerManager _logger;
        private IRentCarWrapper _repoWrapper;

        public ValuesController(IRentCarWrapper repoWrapper, ILoggerManager logger)
        {
            _repoWrapper = repoWrapper;
            _logger = logger;
        }

        //GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var owners = _repoWrapper.User.FindAll().ToList();

            return new string[] { "value1", "value2" };
        }

        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
