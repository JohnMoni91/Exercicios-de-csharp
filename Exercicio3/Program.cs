using System;
using System.Globalization;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declarando oa classe
            SistemaEscolar sistema = new SistemaEscolar();

            // solicitando os dados do aluno 
            Console.Write("Digite o nome do aluno: ");
            sistema.aluno = Console.ReadLine();

            // Nota do aluno

            // nota 1
            Console.Write("Digite a nota 1: ");
            sistema.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // nota 2
            Console.Write("Digite a nota 2: ");
            sistema.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // nota 3
            Console.Write("Digite a nota 3: ");
            sistema.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // calculando a média e a situação do aluno
            double notaFinal = sistema.notaFinal();

            // Exibindo os resultados formatados e se caso o aluno foi reprovado, quantos pontos faltam
            if (sistema.SituacaoAluno())
            {
                Console.WriteLine($"A média final do aluno {sistema.aluno} é: {notaFinal.ToString("F2", CultureInfo.InvariantCulture)} pontos.");
            }
            else
            {
                double pontosFaltando = 60 - notaFinal;
                Console.WriteLine($"O aluno {sistema.aluno} precisa de {pontosFaltando.ToString("F2", CultureInfo.InvariantCulture)} pontos para ser aprovado.");
            }
        }
    }
}