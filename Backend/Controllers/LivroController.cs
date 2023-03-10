using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Controllers.LivroController
{

    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase 
    {

        private readonly ApiDbContext _context;

        public LivroController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<LivroModel>>> ListarLivros(){

           return Ok (await _context.Livros.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LivroModel>> BuscaPersonalizada(int id, [FromQuery] string? livroDigitado){
            //falta testar ainda
            var livro = _context.Livros
            .Where(c => c.IdLivro == id && (c.Titulo == livroDigitado || c.Subtitulo == livroDigitado
            || c.Editora == livroDigitado)).FirstOrDefault();


            if (livro == null)
            {
                NotFound();
            }

           return Ok(livro);

        }


        [HttpPost]
        public async Task<ActionResult<LivroModel>> Cadastrar(LivroModel model){

                var livro = new LivroModel {

                    Titulo = model.Titulo,
                    Subtitulo = model.Subtitulo,
                    Resumo = model.Resumo,
                    QuantPaginas = model.QuantPaginas,
                    DataPublicacao = model.DataPublicacao,
                    Editora = model.Editora,
                    Edicao = model.Edicao,
                    QuantLivros = model.QuantLivros

                };

                try{
                    
                    await _context.Livros.AddAsync(livro);
                    await _context.SaveChangesAsync();

                   return Ok();
                }
                catch (Exception){
                    return BadRequest();
                }


        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LivroModel>> Atualizar ([FromBody] LivroModel model, int id){

            if(!ModelState.IsValid){
                return BadRequest();
            }

            var livro = await _context.Livros.FirstOrDefaultAsync(x => x.IdLivro == id);

            if(livro == null){
                return NotFound();
            }

            try{
                livro.Titulo = model.Titulo;
                livro.Subtitulo = model.Subtitulo;
                livro.Resumo = model.Resumo;
                livro.QuantPaginas = model.QuantPaginas;
                livro.DataPublicacao = model.DataPublicacao;
                livro.Editora = model.Editora;
                livro.Edicao = model.Edicao;
                livro.QuantLivros = model.QuantLivros;


                _context.Livros.Update(livro);
                await _context.SaveChangesAsync();
                return Ok(livro);
            }
            catch(Exception){
                return BadRequest();
            }


        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<LivroModel>> Apagar(int id){

            var livro = await _context.Livros.FirstOrDefaultAsync(x => x.IdLivro == id);

            if(livro == null){
                return NotFound();
            }

            try{
            
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();

            return Ok();

            }
            catch(Exception){
                return BadRequest();
            }

        }

    }

 
/*        [HttpGet("{id}")]
        public async Task<ActionResult<LivroModel>> Busca (int id){

            var livro = await _context.Livros.FirstOrDefaultAsync(x => x.IdLivro == id);

            if(livro == null){
                NotFound();
            }

            return Ok(livro);

        }*/   
}