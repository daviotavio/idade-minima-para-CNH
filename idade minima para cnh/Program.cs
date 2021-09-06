using System;

namespace idade_minima_para_cnh
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Por favor, informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.Write("parabéns, você ja pode tirar a sua CNH.");
            }
            else
            {
                Console.Write("Desculpe, a idade mínima para tirar a CNH é de 18 anos.");
            }
        }
    }
}
