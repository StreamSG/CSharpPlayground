using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API4SQL.Models;

namespace API4SQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly MyDbContext _context;

        public CustomerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerClass>>> GetCustomer()
        {
            return await _context.Customer.ToListAsync();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerClass>> GetCustomerClass(int id)
        {
            var customerClass = await _context.Customer.FindAsync(id);

            if (customerClass == null)
            {
                return NotFound();
            }

            return customerClass;
        }

        // PUT: api/Customer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerClass(int id, CustomerClass customerClass)
        {
            if (id != customerClass.ARSMAST_NO)
            {
                return BadRequest();
            }

            _context.Entry(customerClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerClassExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Customer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerClass>> PostCustomerClass(CustomerClass customerClass)
        {
            _context.Customer.Add(customerClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerClass", new { id = customerClass.ARSMAST_NO }, customerClass);
        }

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerClass(int id)
        {
            var customerClass = await _context.Customer.FindAsync(id);
            if (customerClass == null)
            {
                return NotFound();
            }

            _context.Customer.Remove(customerClass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerClassExists(int id)
        {
            return _context.Customer.Any(e => e.ARSMAST_NO == id);
        }
    }
}
