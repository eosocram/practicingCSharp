using System;
using System.Security.AccessControl;
using Microsoft.VisualBasic;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos começar fazendo um tour pela calculadora!");
            // string frase2 = "Digite o primeiro valor:";
            // Console.ReadLine(frase2);
            Console.WriteLine("Digite o primeiro número:");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int v2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escolha uma operação:");
            string operador = Console.ReadLine();
        
            if (operador == "+")
            {
                Console.WriteLine($"A soma entre os dois números é: {v1+v2}");
            }
            else if (operador == "-")
            {
                Console.WriteLine($"A subtração entre os dois números é: {v2-v1}");
            }
            else if (operador == "*"){
                Console.WriteLine($"A multiplicação entre os dois números é: {v1*v2}");
            }
            else if (operador == "/")
            {
                Console.WriteLine($"A divisão entre os dois números é: {v1/v2}");
            }
        
        }
    }

}

