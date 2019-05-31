using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    class Heap : Ordenacao
    {
        public Heap() : base()
        {

        }
        public override void Sort(int[] vetor)
        {
            BuildMaxHeap(vetor);
            int n = vetor.Length;
            for (int i = vetor.Length - 1; i > 0; i--)
            {
                base.Trocar(vetor, i, 0);
                MaxHeapify(vetor, 0, --n);
            }
        }
        private void BuildMaxHeap(int[] v)
        {
            for (int i = v.Length / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(v, i, v.Length);
            }
        }
        private void MaxHeapify(int[] v, int pos, int n)
        {
            int max = 2 * pos + 1, right = max + 1;
            if (max < n)
            {
                if (right < n && v[max] < v[right])
                {
                    max = right;
                    base.Comparacoes++;
                }
                if (v[max] > v[pos])
                {
                    base.Comparacoes++;
                    base.Trocar(v, max, pos);
                    MaxHeapify(v, max, n);
                }
            }
        }
    }
}
