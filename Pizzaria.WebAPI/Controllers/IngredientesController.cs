using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.Repositories;
using AutoMapper;
using System.Threading.Tasks;
using System.Linq;
using Pizzaria.Domain.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientesController : Controller
    {
        private IIngredientesRepository _ingredientesRepository { get; set; }
        public IngredientesController(IIngredientesRepository ingredientesRepository)
        {
            _ingredientesRepository = ingredientesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {

            var ingredientes = await _ingredientesRepository.GetAll();
            var serializerSettings = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var json = JsonConvert.SerializeObject(ingredientes, serializerSettings);
            return Ok(json);

        }
        [HttpPost]
        public async Task<IActionResult> Create(TbIngrediente ingrediente)
        {
            await _ingredientesRepository.Insert(ingrediente);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(TbIngrediente ingrediente)
        {
            await _ingredientesRepository.Update(ingrediente);
            return Ok();

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            await _ingredientesRepository.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ingrediente = await _ingredientesRepository.GetById(id);
            return Ok(ingrediente);
        }


    }


}