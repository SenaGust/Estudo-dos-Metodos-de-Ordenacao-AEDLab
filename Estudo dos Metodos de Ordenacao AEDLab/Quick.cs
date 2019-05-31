using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    class Quick : Ordenacao
    {
        public Quick():base()
        {

        }

        public void Sort(int[] arr)
        {
            Quicksort(arr, 0, arr.Length-1);
        }
        private void Quicksort(int[] v, int inicio, int fim)
        {
            int part;
            if (inicio < fim)
            {
                part = Particao(v, inicio, fim);
                Quicksort(v, inicio, part - 1);
                Quicksort(v, part + 1, fim);
            }
        }        private int Particao(int[] vetor, int inicio, int fim)
        {
            int pivot = vetor[fim];
            int part = inicio - 1;

            for (int pos = inicio; pos < fim; pos++)
            {
                base.Comparacoes++;
                if (vetor[pos] < pivot)
                {
                    part++;
                    //trocar v[part] com v[i]
                    base.Trocar(vetor, part, pos);
                    base.Trocas++;
                }
            }

            //trocar v[part+1] e v[fim];
            base.Trocas++;
            part++;            base.Trocar(vetor, part, fim);
            return part;
        }    }
}
