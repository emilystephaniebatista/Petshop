using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petshop.Server;
using PetshopOA.Shared;

namespace Petshop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastrarPetshopsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CadastrarPetshopsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CadastrarPetshops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CadastrarPetshop>>> GetCadastrarPetshop()
        {
            return await _context.CadastrarPetshop.ToListAsync();
        }

        // GET: api/CadastrarPetshops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CadastrarPetshop>> GetCadastrarPetshop(int id)
        {
            var cadastrarPetshop = await _context.CadastrarPetshop.FindAsync(id);

            if (cadastrarPetshop == null)
            {
                return NotFound();
            }

            return cadastrarPetshop;
        }

        // PUT: api/CadastrarPetshops/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCadastrarPetshop(int id, CadastrarPetshop cadastrarPetshop)
        {
            if (id != cadastrarPetshop.Id)
            {
                return BadRequest();
            }

            _context.Entry(cadastrarPetshop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CadastrarPetshopExists(id))
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

        // POST: api/CadastrarPetshops
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CadastrarPetshop>> PostCadastrarPetshop(CadastrarPetshop cadastrarPetshop)
        {
            _context.CadastrarPetshop.Add(cadastrarPetshop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCadastrarPetshop", new { id = cadastrarPetshop.Id }, cadastrarPetshop);
        }

        // DELETE: api/CadastrarPetshops/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CadastrarPetshop>> DeleteCadastrarPetshop(int id)
        {
            var cadastrarPetshop = await _context.CadastrarPetshop.FindAsync(id);
            if (cadastrarPetshop == null)
            {
                return NotFound();
            }

            _context.CadastrarPetshop.Remove(cadastrarPetshop);
            await _context.SaveChangesAsync();

            return cadastrarPetshop;
        }

        private bool CadastrarPetshopExists(int id)
        {
            return _context.CadastrarPetshop.Any(e => e.Id == id);
        }
    }
}
