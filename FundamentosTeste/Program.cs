using System.Data.Common;
using FundamentosTeste.Models;

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(10, 50);
calc.Multiplicar(15, 45);
calc.Dividir(2, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9);




// int numero =10;

// Console.WriteLine(numero);

// Console.WriteLine("incrementando o 10");
// //numero = numero + 1;
// numero++;

// Console.WriteLine(numero);


// Operador NOT (!) inverte um valor booleano (falso / verdadeiro)
// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }



// Operador AND - todas condições devem ser verdadeiras //
// bool possuiPresencaMinima = true;
// double media = 6.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else{
//     Console.WriteLine("Reprovado");
// }







//** Operador OR - pelo menos uma condição deve ser verdadeira **//
// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada!");
// }



// Swicth Case é usado para dminuir a quantidade if e else no nosso codigo //
// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }








// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal");
// }





// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {    
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {    
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {    
//     Console.WriteLine("Vogal");
// }
// else{
//     Console.WriteLine("Nao é uma vogal");
// }







// int quantidadeEmEstoque = 10;
// Console.WriteLine("Qual a quantidade deseja comprar?");
// int quantidadeCompra = int.Parse(Console.ReadLine());
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0){

//     Console.WriteLine("Venda inválida!");
// }
// else if (quantidadeEmEstoque >= quantidadeCompra){
    
//     Console.WriteLine("Venda realizada.");
// }
// else {
//     Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
// }







// int a = int.Parse("5");

// Console.WriteLine(a);

/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Paulo";
pessoa1.Idade = 37;
pessoa1.Apresentar();*/

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// double altura = 1.75;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura);
// Console.WriteLine("Valor da variavel preço: " + preco);
// Console.WriteLine("Valor da variavel condição: " + condicao);

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));