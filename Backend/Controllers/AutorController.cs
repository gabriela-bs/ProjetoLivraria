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
        public async Task<ActionResult<List<AutorModel>>> ListarAutores(){

            return Ok (await _context.Autores.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AutorModel>> BuscaAutor(int id){

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
        public async Task<ActionResult<AutorModel>> Cadastrar([FromBody] AutorModel model){

            
            var autor = new AutorModel {

                NomeAutor = model.NomeAutor,
                LivroID = model.LivroID

            };

            try
            {
                await _context.Autores.AddAsync(autor);
                await _context.SaveChangesAsync();
                return Ok();
            }

            catch(Exception){
                return BadRequest();
            }
        }



        [HttpPut("{id}")]
        public async Task<ActionResult<AutorModel>> Atualizar ([FromBody] AutorModel model, int id){

            if(!ModelState.IsValid){
                return BadRequest();
            }

            var autor= await _context.Autores.FirstOrDefaultAsync(x => x.IdAutor == id);

            if (autor == null){
                return NotFound();
            }

            try
            {
                autor.NomeAutor = model.NomeAutor;

                _context.Autores.Update(autor);
                await _context.SaveChangesAsync();
                return Ok(autor);
            }
            catch(Exception){
                return BadRequest();
            }

           
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult<AutorModel>> Apagar(int id){
          
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
          catch(Exception){

            return BadRequest();
          }

        }



    }
}