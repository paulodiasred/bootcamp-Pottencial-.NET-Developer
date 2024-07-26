using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundamentosTeste.Common.Models

{
 /// <summary>
 /// Representa uma pessoa fisica
 /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

/// <summary>
/// Faz a pessoa se apresentar, dizendo seu nome e idade
/// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}