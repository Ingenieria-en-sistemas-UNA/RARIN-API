using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rarin_Technologies_API.Contexts;
using Rarin_Technologies_API.Entities;
using Rarin_Technologies_API.Models;

namespace Rarin_Technologies_API.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Member")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ClientsController(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;
        }

        // GET: api/Client
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OutClientDTO>>> GetClients()
        {
            var clients = await _context.Clients.Include(x => x.Person).ToListAsync();
            return _mapper.Map<List<OutClientDTO>>(clients);

        }

        // GET: api/Client/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OutClientDTO>> GetClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            client.Person = await _context.People.FindAsync(client.PersonId);

            if (client == null)
            {
                return NotFound();
            }

            return _mapper.Map<OutClientDTO>(client);
        }

        // PUT: api/Client/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, InClientDTO inclientDTO)
        {
            var client = _mapper.Map<Client>(inclientDTO);
            if (id != client.Id)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Client
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(InClientDTO inclientDTO)
        {
            var client = _mapper.Map<Client>(inclientDTO);
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClient", new { id = client.Id }, client);
        }

        // DELETE: api/Client/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OutClientDTO>> DeleteClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();

            return _mapper.Map<OutClientDTO>(client); ;
        }

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }
    }
}
