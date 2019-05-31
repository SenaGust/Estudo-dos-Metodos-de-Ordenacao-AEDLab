using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    class Insertion : Ordenacao
    {
        public Insertion() : base()
        {

        }

        public override void Sort(int[] vetor)
        {
            int n = vetor.Length, i, j, val, flag;
            for (i = 1; i < n; i++)
            {
                val = vetor[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    base.Comparacoes++;
                    if (val < vetor[j])
                    {
                        base.Trocas++;
                        vetor[j + 1] = vetor[j];
                        j--;
                        vetor[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }
            }
        }
    }
}
