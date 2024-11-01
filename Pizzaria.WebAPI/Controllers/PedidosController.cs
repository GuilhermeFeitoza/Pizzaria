
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pizzaria.Domain.Models;
using Pizzaria.Domain.Repositories;
using System;
using Pizzaria.WebAPI.ViewModel;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : Controller
    {
        private readonly IPedidoRepository repository;
        private readonly IPedidoProdutoRepository _pedidoProdutoRepository;
        private readonly IPizzaRepository _pizzaRepository;

        public PedidosController(IPedidoRepository repo, IPedidoProdutoRepository pedidoProdutoRepository, IPizzaRepository pizzaRepository)
        {
            repository = repo;
            _pedidoProdutoRepository = pedidoProdutoRepository;
            _pizzaRepository = pizzaRepository;
        }


        [HttpGet("getMostOrdered")]

        public async Task<ActionResult<IEnumerable<TbPedido>>> GetMaisPedidos()
        {

            var top5PizzasMaisPedidas = _pedidoProdutoRepository.Query()
                .Where(a => a.IdPizza != null)
                .Join(
                    _pizzaRepository.Query(),
                    pedidoProduto => pedidoProduto.IdPizza,
                    pizza => pizza.IdPizza,
                    (pedidoProduto, pizza) => new { pizza.Nome }
                )
                .GroupBy(x => x.Nome)
                .Select(g => new
                {
                    Nome = g.Key,
                    NumeroDeVendas = g.Count()
                })
                .OrderByDescending(x => x.NumeroDeVendas)
                .Take(5)
                .ToList();
            return Ok(top5PizzasMaisPedidas);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbPedido>>> GetPedidos()
        {
            var Pedidos = await repository.GetAll();
            if (Pedidos == null)
            {
                return BadRequest();
            }
            return Ok(Pedidos.Select(d => new
            {
                d.IdPedido,
                d.DataPedido,
                d.Endereco,
                d.FormaPagamentoPedido,
                d.StatusPedido,
                d.ValorPedido,
                d.TipoPedido
            }

            ).ToList());
        }

        [HttpGet("getLast")]
        public async Task<ActionResult<IEnumerable<TbPedido>>> GetPedidos([FromQuery] int top)
        {
            var Pedidos = await repository.GetAll();
            if (Pedidos == null)
            {
                return BadRequest();
            }
            return Ok(Pedidos.Select(d => new
            {
                d.IdPedido,
                d.DataPedido,
                d.Endereco,
                d.FormaPagamentoPedido,
                d.StatusPedido,
                d.ValorPedido,
                d.TipoPedido
            }

            ).ToList().Take(top).OrderByDescending(d => d.StatusPedido).ThenByDescending(d => d.DataPedido));
        }
        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbPedido>> GetPedido(int id)
        {
            var Pedido = await repository.GetById(id);
            if (Pedido == null)
            {
                return NotFound("Pedido não encontrado pelo id informado");
            }
            return Ok(Pedido);
        }
        // POST api/<controller>  
        [HttpPost]
        public async Task<IActionResult> PostPedido([FromBody] PedidoViewModel pedido)
        {
            if (pedido == null)
            {
                return BadRequest("Pedido é null");
            }

            var pedidoDb = new TbPedido()
            {
                Endereco = pedido.Endereco,
                DataPedido = DateTime.Now,
                FormaPagamentoPedido = pedido.FormaPagamentoPedido,
                TipoPedido = pedido.TipoPedido,
                StatusPedido = pedido.StatusPedido,
                ValorPedido = pedido.ValorPedido,

            };

            var inserted = await repository.Insert(pedidoDb);
            foreach (var item in pedido.ItensPedidos)
            {
                TbPedidoProduto itenPedido = null;

                if (item.tipoProduto == "B")
                {
                    itenPedido = new TbPedidoProduto()
                    {
                        IdBebida = item.id,
                        IdPizza = null,
                        IdPedido = inserted.IdPedido,
                    };
                }
                else
                {
                    itenPedido = new TbPedidoProduto()
                    {
                        IdBebida = null,
                        IdPizza = item.id,
                        IdPedido = inserted.IdPedido,
                    };
                }
                await _pedidoProdutoRepository.Insert(itenPedido);
            }

            return CreatedAtAction(nameof(GetPedido), new { Id = pedido.IdPedido }, pedido);
        }
        [HttpPut]
        public async Task<IActionResult> PutPedido(TbPedido pedido)
        {

            try
            {
                await repository.Update(pedido);
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok("Atualização do produto realizada com sucesso");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<TbPedido>> DeletePedido(int id)
        {
            var pedido = await repository.GetById(id);
            if (pedido == null)
            {
                return NotFound($"Pedido de {id} foi não encontrado");
            }
            await repository.Delete(id);
            return Ok(pedido);
        }


        [HttpPut("cancelOrder/{id}")]
        public async Task<ActionResult<TbPedido>> CancelPedido(int id)
        {
            var pedido = await repository.GetById(id);
            if (pedido != null)
            {
                pedido.StatusPedido = "C";
                await repository.Update(pedido);

            }
            return Ok();

        }
    }



}