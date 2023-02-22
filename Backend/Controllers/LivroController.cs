using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Data;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<List<Livro>>> ListarLivros(){

           return Ok (await _context.Livros.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> Busca (int id){

            var livro = await _context.Livros.FirstOrDefaultAsync(x => x.IdLivro == id);

            if(livro == null){
                NotFound();
            }

            return Ok(livro);

        }

        [HttpPost]
        public async Task<ActionResult<Livro>> Cadastrar(Livro livro){

                var novoLivro = new Livro {

                    Titulo = livro.Titulo,
                    Subtitulo = livro.Subtitulo,
                    Resumo = livro.Resumo,
                    QuantPaginas = livro.QuantPaginas,
                    DataPublicacao = livro.DataPublicacao,
                    Editora = livro.Editora,
                    Edicao = livro.Edicao,
                    QuantLivros = livro.QuantLivros

                };

                try{
                    await _context.Livros.AddAsync(novoLivro);
                    await _context.SaveChangesAsync();
                   // return Created($"v1/livros/{novoLivro.IdLivro}", novoLivro);

                   return Ok();
                }
                catch (Exception){
                    return BadRequest();
                }

               // return Created($"v1/livros/{livro.IdLivro}", livro);


        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Livro>> Atualizar ([FromBody] Livro livroAtualizacao, int id){

            if(!ModelState.IsValid){
                return BadRequest();
            }

            var livro = await _context.Livros.FirstOrDefaultAsync(x => x.IdLivro == id);

            if(livro == null){
                return NotFound();
            }

            try{
                livro.Titulo = livroAtualizacao.Titulo;
                livro.Subtitulo = livroAtualizacao.Subtitulo;
                livro.Resumo = livroAtualizacao.Resumo;
                livro.QuantPaginas = livroAtualizacao.QuantPaginas;
                livro.DataPublicacao = livroAtualizacao.DataPublicacao;
                livro.Editora = livroAtualizacao.Editora;
                livro.Edicao = livroAtualizacao.Edicao;
                livro.QuantLivros = livroAtualizacao.QuantLivros;
               // livro.Autores = livroAtualizacao.Autores;


                _context.Livros.Update(livro);
                await _context.SaveChangesAsync();
                return Ok(livro);
            }
            catch(Exception e){
                return BadRequest();
            }


        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Livro>> Apagar(int id){

            var livro = await _context.Livros.FirstOrDefaultAsync(x => x.IdLivro == id);

            if(livro == null){
                return NotFound();
            }

            try{
            
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();

            return Ok();

            }
            catch(Exception e){
                return BadRequest();
            }

        }

    }
}