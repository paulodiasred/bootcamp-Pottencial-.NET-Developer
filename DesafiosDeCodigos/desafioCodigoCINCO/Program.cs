using System; 

class minhaClasse { 

  static void Main(string[] args) {  

    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 

//TODO: Complete os espaços em branco com uma possível solução para o problema:
   
    

    if(salario < 0) { 
      return; 

    } else if (salario <= 400.00) {
      percentual = 15;
      reajuste = salario * 0.15; 
      novoSalario = salario + reajuste; 


    } else if (salario <= 800.00) { 
      percentual = 12; 
      reajuste = salario * 0.12;         
      novoSalario = salario + reajuste; 

    } else if (salario <= 1200.00) { 
      percentual = 10; 
      reajuste = salario * 0.10; 
      novoSalario = salario + reajuste; 

    } else if (salario <= 2000.00) { 
      percentual = 7; 
      reajuste = salario * 0.07; 
      novoSalario = salario + reajuste; 

    } else { 
      percentual = 4; 
      reajuste = salario * 0.04; 
      novoSalario = salario + reajuste; 

    } 

    Console.WriteLine("Novo salario: {0:0.00}", novoSalario); 
    Console.WriteLine("Reajuste ganho: {0:0.00}",reajuste); 
    Console.WriteLine("Em percentual: {0} %", percentual); 

  } 
}