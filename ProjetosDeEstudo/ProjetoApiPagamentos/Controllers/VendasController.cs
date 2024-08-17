using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using ProjetoApiPagamentos.Models;
using ProjetoApiPagamentos.Models.Helpers;

namespace ProjetoApiPagamentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private static readonly List<Venda> Vendas = new List<Venda>();
        private static int contadorIdVenda = 1;

        [HttpPost("registrar")]
        public IActionResult RegistrarVenda([FromBody] Venda venda)
        {
            if (venda == null)
            {
                return BadRequest("O corpo da requisição não pode ser nulo.");
            }

            if (venda.Itens == null || venda.Itens.Count == 0)
            {
                return BadRequest("É necessário incluir pelo menos um item.");
            }

            venda.Id = contadorIdVenda++;
            venda.Status = StatusVenda.AguardandoPagamento;
            Vendas.Add(venda);
            return CreatedAtAction(nameof(ObterVenda), new { id = venda.Id }, venda);
        }

        [HttpGet("{id}")]
        public IActionResult ObterVenda(int id)
        {
            var venda = Vendas.FirstOrDefault(v => v.Id == id);
            if (venda == null)
            {
                return NotFound();
            }
            return Ok(venda);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarStatusVenda(int id, [FromBody] StatusVenda novoStatus)
        {
            var venda = Vendas.FirstOrDefault(v => v.Id == id);
            if (venda == null)
            {
                return NotFound();
            }

            if (TransicoesPermitidas.MapaTransicoes.TryGetValue(venda.Status, out var statusPermitidos) &&
                statusPermitidos.Contains(novoStatus))
            {
                venda.Status = novoStatus;
                return NoContent();
            }

            return BadRequest("Transição de status inválida.");
        }
    }
}