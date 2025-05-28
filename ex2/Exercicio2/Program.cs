using System;

namespace Exercicio2;

class Program
{
    static void Main(string[] args)
    {

        // Criação de um objeto Funcionario
        Funcionario funcionario = new Funcionario();

        // Leitura dos dados do funcionário

        // Nome
        Console.Write("Nome: ");
        funcionario.nome = Console.ReadLine();

        // Salário bruto
        Console.Write("Salário bruto: ");
        funcionario.salarioBruto = double.Parse(Console.ReadLine());

        // Imposto
        Console.Write("Imposto: ");
        funcionario.imposto = double.Parse(Console.ReadLine());

        // Exibir funcinario
        Console.WriteLine($"Funcionário: {funcionario}");

        // Aumento de salário
        Console.Write("Digite a porcentagem para aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine());
        funcionario.AumentarSalario(porcentagem);

        // Exibir funcinario após aumento
        Console.WriteLine($"Dados atualizados: {funcionario}");


        // Manter o console aberto
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}