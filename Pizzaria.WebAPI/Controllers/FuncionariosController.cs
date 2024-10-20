
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
    public class FuncionariosController : Controller
    {
        private readonly IFuncionarioRepository _repository;
        private readonly IMapper _mapper;
        public FuncionariosController(IFuncionarioRepository context, IMapper mapper)
        {
            _repository = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbFuncionario>>> GetFuncionarios()
        {
            var funcionarios = await _repository.GetAll();
            if (funcionarios == null)
            {
                return BadRequest();
            }
            return Ok(funcionarios.ToList());
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbFuncionario>> GetFuncionario([FromRoute] int id)
        {
            var funcionario = await _repository.GetById(id);
            if (funcionario == null)
            {
                return NotFound("Cliente não encontrado pelo id informado");
            }
            return Ok(funcionario);
        }
        // POST api/<controller>  
        [HttpPost]
        public async Task<IActionResult> PostFuncionario([FromBody] FuncionarioViewModel funcionario)
        {


            if (funcionario == null)
            {
                return BadRequest("Funcionario é null");
            }

            var funcionarioModel = _mapper.Map<TbFuncionario>(funcionario);
            await _repository.Insert(funcionarioModel);
            return CreatedAtAction(nameof(GetFuncionario), new { Id = funcionario.Id }, funcionario);
        }
        [HttpPut]
        public async Task<IActionResult> PutFuncionario([FromBody] FuncionarioViewModel funcionario)
        {

            try
            {
                var func = new TbFuncionario()
                {
                    Id = funcionario.Id,
                    Nome = funcionario.Nome,
                    Senha = funcionario.Senha,
                    Usuario = funcionario.Usuario,
                    Ativo = funcionario.Ativo,
                    DataAdmissao = DateTime.ParseExact(funcionario.DataAdmissao, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture),
                    DataNascimento = DateTime.ParseExact(funcionario.DataNascimento, "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture)
                };

                await _repository.Update(func);
            }
            catch (Exception)
            {
                throw;
            }
            return Ok("Atualização do produto realizada com sucesso");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbFuncionario>> DeleteFuncionario(int id)
        {
            var funcionario = await _repository.GetById(id);
            if (funcionario == null)
            {
                return NotFound($"funcionario de {id} foi não encontrado");
            }
            await _repository.Delete(id);
            return Ok(funcionario);
        }
    }



}