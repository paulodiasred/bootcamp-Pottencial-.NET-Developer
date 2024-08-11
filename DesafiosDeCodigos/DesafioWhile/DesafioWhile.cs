using System;

namespace desafio_while
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("player 1 informe um numero de 0 a 9:");
            int n1 = int.Parse(Console.ReadLine());

            while(n1 < 0 || n1 > 9) {
                Console.WriteLine("Numero invalido,digite navamente!");
                n1 = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine("player 2 tente acertar o numero de 0 a 9:");
            int n2 = int.Parse(Console.ReadLine());

            while (n2 < 0 || n2 > 9)
            {
                Console.WriteLine("Numero invalido,digite novamente!");
                n2 = int.Parse(Console.ReadLine());
            }        
           
            while (n1 != n2)
            {
                Console.WriteLine("Numero errado! Tente de novo:");
                n2 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acertou, otimo trabalho Player 2!");

            Console.ReadLine();
        
            
        }
    }
}