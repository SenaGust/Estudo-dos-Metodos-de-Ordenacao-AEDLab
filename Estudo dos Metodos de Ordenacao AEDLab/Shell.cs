using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    class Shell : Ordenacao
    {
        public Shell() : base()
        {

        }
        public void Sort(int[] vetor)
        {
            int h = 1;
            int n = vetor.Length;
            while (h < n)
            {
                h = h * 3 + 1;
            }
            h = h / 3;
            int c, j;
            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    j = i;
                    while (j >= h && vetor[j - h] > c)
                    {
                        vetor[j] = vetor[j - h];
                        j = j - h;
                        base.Trocas++;
                        base.Comparacoes++;
                    }
                    vetor[j] = c;
                    base.Trocas++;
                }
                h = h / 2;
            }
        }
    }
}
