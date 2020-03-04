using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using AddressApp.API.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AddressApp.API.Controllers
{
    //http:localhost:5000/api/address
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly DataContext _context;
        public AddressController(DataContext context)
        {
            _context = context;

        }
        // GET api/address
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Addresses.ToListAsync();

            return Ok(values);
        }

        // GET api/address/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        // POST api/address
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/address/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/address/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}