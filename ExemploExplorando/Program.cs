using ExemploExplorando.Models;
using System.Globalization;
using System.Net.Mail;

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