using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DattingAppAPI.Data;
using Microsoft.AspNetCore.Mvc;



namespace DattingAppAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            //throw new Exception("test Exception");

            var values = _context.Resources.ToList();
            return Ok(values);
        }


        // GET api/valueById/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var valueById = _context.Resources.FirstOrDefault(x => x.Id == id );
            return Ok(valueById);
            

        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
