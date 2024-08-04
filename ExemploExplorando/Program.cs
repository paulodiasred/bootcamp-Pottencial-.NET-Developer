using ExemploExplorando.Models;
using System.Globalization;

//alterando "localização" do codigo
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//formatando valores monetarios
decimal valorMonetario = 1582.40M;

//alterando localização da cultura
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
//Console.WriteLine($"{valorMonetario:C}");

















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