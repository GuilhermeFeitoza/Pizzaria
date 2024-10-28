
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebAPI.ViewModel;
using Pizzaria.Domain.Models;
using Pizzaria.Domain.Repositories;
using System;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BebidasController : Controller
    {
        private readonly IBebidasRepository _repository;
        private readonly IMapper _mapper;
        public BebidasController(IBebidasRepository context, IMapper mapper)
        {
            _repository = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbBebida>>> GetBebidas()
        {
            var bebidas = await _repository.GetAll();
            if (bebidas == null)
            {
                return BadRequest();
            }
            return Ok(bebidas.ToList());
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbBebida>> GetBebida([FromRoute] int id)
        {
            var bebida = await _repository.GetById(id);
            if (bebida == null)
            {
                return NotFound("Cliente não encontrado pelo id informado");
            }
            return Ok(bebida);
        }
        // POST api/<controller>  
        [HttpPost]
        public async Task<IActionResult> PostBebida([FromBody] TbBebida bebida)
        {


            if (bebida == null)
            {
                return BadRequest("Bebida é null");
            }

            var bebidaModel = _mapper.Map<TbBebida>(bebida);
            await _repository.Insert(bebidaModel);
            return CreatedAtAction(nameof(GetBebida), new { Id = bebida.IdBebida }, bebida);
        }
        [HttpPut]
        public async Task<IActionResult> PutBebida([FromBody] TbBebida bebida)
        {

            try
            {


                await _repository.Update(bebida);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok("Atualização do produto realizada com sucesso");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbBebida>> DeleteBebida(int id)
        {
            var bebida = await _repository.GetById(id);
            if (bebida == null)
            {
                return NotFound($"bebida de {id} foi não encontrado");
            }
            await _repository.Delete(id);
            return Ok(bebida);
        }
    }



}