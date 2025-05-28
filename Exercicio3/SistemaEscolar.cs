using System;

namespace Exercicio3
{
    internal class SistemaEscolar
    {
        public string aluno;
        public double nota1;
        public double nota2;
        public double nota3;

        public double notaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        // fazer a situação do aluno se ele reprovou, está de recuperação ou foi aprovado
        // tbm colocar quantos pontos faltam

        public bool SituacaoAluno()
        {
            if (notaFinal() < 60)
            {
                return false; // O aluno foi reprovado
            }
            else if (notaFinal() >= 60 && notaFinal() < 70)
            {
                return true; // O aluno está de recuperação
            }
            else
            {
                return true; // O aluno foi aprovado
            }
        }
    }
}