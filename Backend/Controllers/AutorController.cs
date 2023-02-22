using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Backend.Models;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Backend.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase {

        private readonly ApiDbContext _context;

        public AutorController(ApiDbContext context){

            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> ListarAutores(){

            return Ok (await _context.Autores.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Autor>> BuscaAutor(int id){

            var autor = await _context.Autores
            .Include(x => x.Livro)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.IdAutor == id);

            if (autor == null)
            {
                NotFound();
            }

           return Ok(autor);

        }

        [HttpPost]
        public async Task<ActionResult<Autor>> Cadastrar(Autor autor){

            try
            {
                await _context.Autores.AddAsync(autor);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch(Exception e){
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Autor>> Atualizar ([FromBody] Autor autor, int id){

            if(!ModelState.IsValid){
                return BadRequest();
            }

            var autorAtualizado = await _context.Autores.FirstOrDefaultAsync(x => x.IdAutor == id);

            if (autorAtualizado == null){
                return NotFound();
            }

            try
            {
                autorAtualizado.NomeAutor = autor.NomeAutor;

                _context.Autores.Update(autorAtualizado);
                await _context.SaveChangesAsync();
                return Ok(autorAtualizado);
            }
            catch(Exception e){
                return BadRequest();
            }

           
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult<Autor>> Apagar(int id){
          
          var autor = await _context.Autores.FirstOrDefaultAsync(x => x.IdAutor == id);
          
          if(autor == null){
            return NotFound();
          }  

          try
          {
            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();
            return Ok();
          }
          catch(Exception e){

            return BadRequest();
          }

        }



    }
}