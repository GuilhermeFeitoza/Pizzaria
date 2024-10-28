
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
    public class ClientesController : Controller
    {
        private readonly IClienteRepository repository;
        public ClientesController(IClienteRepository _context)
        {
            repository = _context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbCliente>>> GetClientes()
        {
            var Clientes = await repository.GetAll();
            if (Clientes == null)
            {
                return BadRequest();
            }
            return Ok(Clientes.Select(d => new
            {
                d.IdCliente,
                d.Nome,
                d.Cpf,
                d.DataNascimento
            }

            ).ToList());
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbCliente>> GetCliente(int id)
        {
            var Cliente = await repository.GetById(id);
            if (Cliente == null)
            {
                return NotFound("Cliente não encontrado pelo id informado");
            }
            return Ok(Cliente);
        }
        // POST api/<controller>  
        [HttpPost]
        public async Task<IActionResult> PostCliente([FromBody] TbCliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest("Cliente é null");
            }
            await repository.Insert(cliente);
            return CreatedAtAction(nameof(GetCliente), new { Id = cliente.IdCliente }, cliente);
        }
        [HttpPut]
        public async Task<IActionResult> PutCliente(TbCliente cliente)
        {
           
            try
            {
                await repository.Update(cliente);
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok("Atualização do produto realizada com sucesso");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbCliente>> DeleteCliente(int id)
        {
            var cliente = await repository.GetById(id);
            if (cliente == null)
            {
                return NotFound($"Cliente de {id} foi não encontrado");
            }
            await repository.Delete(id);
            return Ok(cliente);
        }
    }



}