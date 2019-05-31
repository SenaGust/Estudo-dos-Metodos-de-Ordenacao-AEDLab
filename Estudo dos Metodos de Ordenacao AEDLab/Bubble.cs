using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    class Bubble : Ordenacao
    {
        public Bubble() : base()
        {

        }

        public override void Sort(int[] vetor)
        {
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = 0; j < vetor.Length - (i + 1); j++)
                {
                    base.Comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                        base.Trocar(vetor, j, j+1);
                }
            }
        }
    }
}
