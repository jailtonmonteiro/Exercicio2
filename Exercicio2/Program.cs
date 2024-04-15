using System;

//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//casas decimais conforme exemplos.

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio;
            double area;

            Console.WriteLine("Digite o valor do raio do circulo: ");
            raio = double.Parse(Console.ReadLine());

            area = pi * (raio * raio);

            Console.WriteLine(area.ToString("F4"));
        }
    }
}
