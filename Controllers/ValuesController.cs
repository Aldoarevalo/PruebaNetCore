using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaNetCore.Model;
using PruebaNetCore.Models;

namespace BancoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancosTransferenciaController : ControllerBase
    {
        private readonly TransferBancoContext _context;

        public BancosTransferenciaController(TransferBancoContext context)
        {
            _context = context;
        }

        // GET: api/Obtener Transferencias de Bancos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransferBanco>>> GetBancos()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/Obtener un banco/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransferBanco>> GetBanco(long id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        

        // PUT: api/put banco/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBanco(long id, TransferBanco book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
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

        // POST: api/Registrar Banco       
        [HttpPost]
        public async Task<ActionResult<TransferBanco>> PostBanco(string Banco_de_Origen, string Banco_de_destino, string Cuenta_de_origen, string Cuenta_de_destino, string Fecha_operacion , string Monto_Operacion, string estado, TransferBanco book)
        {
            if (Banco_de_Origen == book.Banco_de_destino)
            {
                return BadRequest("el banco de origen no puede ser igual al de destino");
            }

           

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBanco", new { id = book.Id }, book);
        }

        // DELETE: api/eliminar Banco/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBanco(long id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(long id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
