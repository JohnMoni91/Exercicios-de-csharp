using System;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definindo a classe Retangulo
            Retangulo retangulo = new Retangulo();


            // Solicitando ao usuário a largura do retângulo
            Console.Write("Digite a largura do retângulo: ");
            retangulo.largura = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            // Solicitando ao usuário a altura do retângulo
            Console.Write("Digite a altura do retângulo: ");
            retangulo.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Mensagem de sucesso
            Console.WriteLine("Retângulo criado com sucesso!");

            // Calculando a área do retângulo
            double area = retangulo.CalcularArea();
            Console.WriteLine($"Área: {area.ToString("F2", CultureInfo.InvariantCulture)}");

            // Calculando o perímetro do retângulo
            double perimetro = retangulo.CalcularPerimetro();
            Console.WriteLine($"Perímetro: {perimetro.ToString("F2", CultureInfo.InvariantCulture)}");

            // Calculando a diagonal do retângulo
            double diagonal = retangulo.CalcularDiagonal();
            Console.WriteLine($"Diagonal: {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");

            // Mensagem de encerramento
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}