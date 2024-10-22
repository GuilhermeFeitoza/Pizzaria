
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizzaria.Domain.Models;
using Pizzaria.Domain.Repositories;
using System;
using WebAPI.ViewModel;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository repository;
        private readonly IIngredientesRepository ingredienteRepository;
        private readonly IPizzaIngredientesRepository pizzaIngredienteRepository;
        public PizzaController(IPizzaRepository _context, IIngredientesRepository _ingredientesRepository, IPizzaIngredientesRepository _pizzaIngredienteRepository)
        {
            repository = _context;
            ingredienteRepository = _ingredientesRepository;
            pizzaIngredienteRepository = _pizzaIngredienteRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaViewModel>>> GetPizza()
        {
            var pizza = await repository.GetAll();
            var listPizza = new List<PizzaViewModel>();
            foreach (var item in pizza)
            {
                var pizzaVm = new PizzaViewModel
                {
                    IdPizza = item.IdPizza,
                    Nome = item.Nome,
                    Preco = item.Preco,
                    Tamanho = item.Tamanho,
                    Ingredientes = new List<string>(),

                };
                var pizzaIngredientes = ingredienteRepository.Query()
                .Join(pizzaIngredienteRepository.Query().Where(d => d.IdPizza == item.IdPizza),
                ingrediente => ingrediente.IdIngrediente,
                pizza => pizza.IdIngrediente,
                (ingrediente, pizza) => ingrediente.Nome).Distinct().ToList();

                pizzaVm.Ingredientes = pizzaIngredientes;
                listPizza.Add(pizzaVm);

            }
            if (listPizza == null)
            {
                return BadRequest();
            }
            return Ok(listPizza);
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
        public async Task<IActionResult> PostPizza([FromBody] PostPizzaViewModel Pizza)
        {
            if (Pizza == null)
            {
                return BadRequest("Pizza é null");
            }

            var pizza = new TbPizza()
            {
                Nome = Pizza.Nome,
                Preco = Pizza.Preco,
                Tamanho = Pizza.Tamanho,
            };

            var insertedPizza = await repository.Insert(pizza);
            foreach (var item in Pizza.Ingredientes)
            {
                var pizzaIngredienteObj = new TbPizzaIngrediente
                {
                    IdPizza = insertedPizza.IdPizza,
                    IdIngrediente = item

                };

                await pizzaIngredienteRepository.Insert(pizzaIngredienteObj);

            }


            return CreatedAtAction(nameof(GetPizza), new { Id = insertedPizza.IdPizza }, insertedPizza);
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
            
            var pizzasIngredientes = pizzaIngredienteRepository.Query().Where(d=>d.IdPizza == id).ToList();
            foreach (var item in pizzasIngredientes)
            {
                await pizzaIngredienteRepository.Delete(item.IdPizzaIngrediente);
            }
           

            if (Pizza == null)
            {
                return NotFound($"Produto de {id} foi não encontrado");
            }
            await repository.Delete(id);
            return Ok(Pizza);
        }
    }



}