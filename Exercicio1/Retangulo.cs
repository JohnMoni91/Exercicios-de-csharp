using System;
using System.Formats.Asn1;

namespace Exercicio1
{
    internal class Retangulo
    {
        public double largura;
        public double altura;

        public double CalcularArea()
        {
            return largura * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (largura + altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }
    }
}
