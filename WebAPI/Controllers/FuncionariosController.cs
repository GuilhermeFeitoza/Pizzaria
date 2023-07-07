
using WebAPI.Models;
using WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : Controller
    {
        private readonly IFuncionarioRepository repository;
        public FuncionariosController(IFuncionarioRepository _context)
        {
            repository = _context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbFuncionario>>> GetFuncionarios()
        {
            var funcionarios = await repository.GetAll();
            if (funcionarios == null)
            {
                return BadRequest();
            }
            return Ok(funcionarios.ToList());
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbFuncionario>> GetFuncionario(int id)
        {
            var funcionario = await repository.GetById(id);
            if (funcionario == null)
            {
                return NotFound("Cliente não encontrado pelo id informado");
            }
            return Ok(funcionario);
        }
        // POST api/<controller>  
        [HttpPost]
        public async Task<IActionResult> PostFuncionario([FromBody]TbFuncionario funcionario)
        {
            if (funcionario == null)
            {
                return BadRequest("Cliente é null");
            }            
            await repository.Insert(funcionario);
            return CreatedAtAction(nameof(GetFuncionario), new { Id = funcionario.Id }, funcionario);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuncionario(int id, TbFuncionario funcionario)
        {
            if (id != funcionario.Id)
            {
                return BadRequest($"O código do produto {id} não confere");
            }
            try
            {
                await repository.Update(id, funcionario);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return Ok("Atualização do produto realizada com sucesso");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbFuncionario>> DeleteFuncionario(int id)
        {
            var funcionario = await repository.GetById(id);
            if (funcionario == null)
            {
                return NotFound($"Produto de {id} foi não encontrado");
            }
            await repository.Delete(id);
            return Ok(funcionario);
        }
    }



}