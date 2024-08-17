using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoApiPagamentos.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Vendedor Vendedor { get; set; }
        public DateTime Data { get; set; }
        public string PedidoId { get; set; }
        public List<Item> Itens { get; set; }
        public StatusVenda Status { get; set; }
    }
}