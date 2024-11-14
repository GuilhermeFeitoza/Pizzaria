
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
    public class AvaliacoesController : Controller
    {
        private readonly IAvaliacaoRepository _repository;
        private readonly IMapper _mapper;
        public AvaliacoesController(IAvaliacaoRepository context, IMapper mapper)
        {
            _repository = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbAvaliacao>>> GetAvaliacoes()
        {
            var avaliacaos = await _repository.GetAll();
            if (avaliacaos == null)
            {
                return BadRequest();
            }
            return Ok(avaliacaos.ToList());
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbAvaliacao>> GetAvaliacao([FromRoute] int id)
        {
            var avaliacao = await _repository.GetById(id);
            if (avaliacao == null)
            {
                return NotFound("Cliente não encontrado pelo id informado");
            }
            return Ok(avaliacao);
        }
        // POST api/<controller>  
        [HttpPost]
        public async Task<IActionResult> PostAvaliacao([FromBody] TbAvaliacao avaliacao)
        {


            if (avaliacao == null)
            {
                return BadRequest("Avaliacao é null");
            }

            var avaliacaoModel = _mapper.Map<TbAvaliacao>(avaliacao);
            await _repository.Insert(avaliacaoModel);
            return CreatedAtAction(nameof(GetAvaliacao), new { Id = avaliacao.IdAvaliacao }, avaliacao);
        }
        [HttpPut]
        public async Task<IActionResult> PutAvaliacao([FromBody] TbAvaliacao avaliacao)
        {

            try
            {


                await _repository.Update(avaliacao);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok("Atualização do produto realizada com sucesso");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbAvaliacao>> DeleteAvaliacao(int id)
        {
            var avaliacao = await _repository.GetById(id);
            if (avaliacao == null)
            {
                return NotFound($"avaliacao de {id} foi não encontrado");
            }
            await _repository.Delete(id);
            return Ok(avaliacao);
        }
    }



}