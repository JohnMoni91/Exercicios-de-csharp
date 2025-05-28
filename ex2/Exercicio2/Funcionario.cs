using System;


namespace Exercicio2
{
    internal class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto += salarioBruto * (porcentagem / 100);
        }

        public override string ToString()
        {
            return $"{nome}, $ {SalarioLiquido():F2}";
        }

    }
}
