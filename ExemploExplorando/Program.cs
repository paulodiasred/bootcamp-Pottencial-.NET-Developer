using ExemploExplorando.Models;
using System.Globalization;
using System.Net.Mail;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")}");
}






















//serializando um objeto ***********
// DateTime dataAtual = DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00m, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00m, dataAtual);
// Venda v3 = new Venda(3, "CDKEY Steam", 59.90m, dataAtual);
// Venda v4 = new Venda(4, "Jogo Bomberman 64", 76.50m, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);
// listaVendas.Add(v3);
// listaVendas.Add(v4);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);


















// int numero = 15;
// bool ehPar = false;

// // IF Ternário
// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));




// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//         Console.WriteLine($"O número {numero} é ímpar");
// }




















// // * construtor
// Pessoa p1 = new Pessoa("Paulo", "Dias");

// // * desconstrutor 
// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");
















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }

















// // outro exemplo de Tupla
// ValueTuple<int, string, string, decimal> outroExemploTupla = (7, "Thassia", "Corrade", 1.56m);
// // outro exemplo de Tupla
// var maisUmExemploTupla = Tuple.Create(3, "Mohamed", "Abdalah", 1.80m);

// // atraves de uma tupla podemos representar em uma unica variável diferentes tipos de dados.
// // é uma alternativa a criação de classe
// // tupla no caso abaixo é o nome da variável
// (int, string, string, decimal) tupla = (37, "Paulo", "Dias", 1.75m);
// // acima o metodo mais recomendado

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");


















//Dictionary
// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");

// //acessando valor do dictionary
// Console.WriteLine(estados["MG"]);



// foreach (KeyValuePair<string, string> item in estados)
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// Console.WriteLine("------------");
//estados.Remove("BA");
// estados["SP"] = "São Paulo - Valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento:{chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }













//* pilha
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");

// pilha.Push(20);
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }







//* fila
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
















//new ExemploExcecao().Metodo1();











//leitura de arquivos
// try
// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_leitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretorio do arquivo não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally // Bloco "finally" executa ocorrendo ou não uma exeção
// {
//     Console.WriteLine("Chegou ate aqui!");
// }











// string dataString = "2024-12-17 22:00";
// //DateTime data = DateTime.Now;
// //DateTime data = DateTime.Parse("13/07/2025 19:00");

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida!");
//}
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

//Console.WriteLine(data.ToShortDateString());

//Console.WriteLine(data.ToShortTimeString());









// //alterando "localização" do codigo
// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// //formatando valores monetarios
// decimal valorMonetario = 1582.40M;

// //alterando localização da cultura
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //resul: $1,582.40
// //Console.WriteLine($"{valorMonetario:C}");

// Console.WriteLine(valorMonetario.ToString("C2")); //resul: R$ 1.582,40

// Console.WriteLine(valorMonetario.ToString("N3")); // resul: 1.582,400

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));















// //com construtor
// Pessoa p1 = new Pessoa(nome:"Paulo", sobrenome:"Dias"); //pra ficar mais claro podemos colocar nome: e sobrenome:

// //sem construtor
// Pessoa p2 = new Pessoa();
// p2.Nome = "Thassia";
// p2.Sobrenome = "Corrade";

// //com construtor
// Pessoa p3 = new Pessoa("Mohamed", "Abdalah");
// Pessoa p4 = new Pessoa("Augusto", "Neves");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.AdicionarAluno(p4);
// cursoDeIngles.ListarAlunos();