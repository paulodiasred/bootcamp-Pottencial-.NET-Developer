using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoApiPagamentos.Models.Helpers
{
    public static class TransicoesPermitidas
    {
        public static readonly Dictionary<StatusVenda, List<StatusVenda>> MapaTransicoes = new()
        {
            { StatusVenda.AguardandoPagamento, new List<StatusVenda> { StatusVenda.PagamentoAprovado, StatusVenda.Cancelada } },
            { StatusVenda.PagamentoAprovado, new List<StatusVenda> { StatusVenda.EnviadoParaTransportadora, StatusVenda.Cancelada } },
            { StatusVenda.EnviadoParaTransportadora, new List<StatusVenda> { StatusVenda.Entregue } }
        };
    }
}