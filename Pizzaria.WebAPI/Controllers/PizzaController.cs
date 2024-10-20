
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizzaria.Domain.Models;
using Pizzaria.Domain.Repositories;
using System;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository repository;
        public PizzaController(IPizzaRepository _context)
        {
            repository = _context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbPizza>>> GetPizza()
        {
            var Pizza = await repository.GetAll();
            if (Pizza == null)
            {
                return BadRequest();
            }
            return Ok(Pizza.ToList());
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbPizza>> GetPizza(int id)
        {
            var Pizza = await repository.GetById(id);
            if (Pizza == null)
            {
                return NotFound("Pizza não encontrada pelo id informado");
            }
            return Ok(Pizza);
        }
        // POST api/<controller>  
        [HttpPost]
        public async Task<IActionResult> PostPizza([FromBody]TbPizza Pizza)
        {
            if (Pizza == null)
            {
                return BadRequest("Pizza é null");
            }            
            await repository.Insert(Pizza);
            return CreatedAtAction(nameof(GetPizza), new { Id = Pizza.IdPizza }, Pizza);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPizza(int id, TbPizza Pizza)
        {
            if (id != Pizza.IdPizza)
            {
                return BadRequest($"O código do produto {id} não confere");
            }
            try
            {
                await repository.Update(Pizza);
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok("Atualização do produto realizada com sucesso");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbPizza>> DeletePizza(int id)
        {
            var Pizza = await repository.GetById(id);
            if (Pizza == null)
            {
                return NotFound($"Produto de {id} foi não encontrado");
            }
            await repository.Delete(id);
            return Ok(Pizza);
        }
    }



}