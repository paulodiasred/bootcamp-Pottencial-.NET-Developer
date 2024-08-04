using ExemploExplorando.Models;
using System.Globalization;
using System.Net.Mail;

string dataString = "2024-12-17 22:00";
//DateTime data = DateTime.Now;
//DateTime data = DateTime.Parse("13/07/2025 19:00");

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida!");
}
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