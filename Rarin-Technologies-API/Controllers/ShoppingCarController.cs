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
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    [ApiController]
    public class ShoppingCarController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ShoppingCarController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            this._mapper = mapper;

        }

        // GET: api/ShoppingCar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OutShoppingCarDTO>>> GetShoppingCar()
        {
            var shoppingCar = await _context.ShoppingCars.ToListAsync();
            return _mapper.Map<List<OutShoppingCarDTO>>(shoppingCar);
        }

        // GET: api/ShoppingCar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OutShoppingCarDTO>> GetShoppingCar(int id)
        {
            var shoppingCar = await _context.ShoppingCars.FindAsync(id);

            if (shoppingCar == null)
            {
                return NotFound();
            }

            return _mapper.Map<OutShoppingCarDTO>(shoppingCar);
        }

        // PUT: api/ShoppingCar/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShoppingCar(int id, InShoppingCarDTO inShoppingCarDTO)
        {
            var shoppingCar = _mapper.Map<ShoppingCar>(inShoppingCarDTO);
            if (id != shoppingCar.Id)
            {
                return BadRequest();
            }

            _context.Entry(shoppingCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingCarExists(id))
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

        // POST: api/ShoppingCar
        [HttpPost]
        public async Task<ActionResult<OutShoppingCarDTO>> PostShoppingCar(InShoppingCarDTO inShoppingCarDTO)
        {
            var shoppingCar = _mapper.Map<ShoppingCar>(inShoppingCarDTO);
            _context.ShoppingCars.Add(shoppingCar);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetShoppingCar", new { id = shoppingCar.Id }, _mapper.Map<OutShoppingCarDTO>(shoppingCar));
        }

        // DELETE: api/ShoppingCar/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OutShoppingCarDTO>> DeleteShoppingCar(int id)
        {
            var shoppingCar = await _context.ShoppingCars.FindAsync(id);
            if (shoppingCar == null)
            {
                return NotFound();
            }

            _context.ShoppingCars.Remove(shoppingCar);
            await _context.SaveChangesAsync();

            return _mapper.Map<OutShoppingCarDTO>(shoppingCar);
        }

        private bool ShoppingCarExists(int id)
        {
            return _context.ShoppingCars.Any(e => e.Id == id);
        }
    }
}
