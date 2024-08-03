using ExemploExplorando.Models;

//com construtor
Pessoa p1 = new Pessoa(nome:"Paulo", sobrenome:"Dias"); //pra ficar mais claro podemos colocar nome: e sobrenome:

//sem construtor
Pessoa p2 = new Pessoa();
p2.Nome = "Thassia";
p2.Sobrenome = "Corrade";

//com construtor
Pessoa p3 = new Pessoa("Mohamed", "Abudalah");
Pessoa p4 = new Pessoa("Augusto", "Neves");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);
cursoDeIngles.ListarAlunos();