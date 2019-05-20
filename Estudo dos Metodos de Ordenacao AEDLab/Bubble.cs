using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    class Bubble
    {
        public int Comparacoes { get; set; }
        public int Trocas { get; set; }

        public static void Sort(int[] arr)
        {
            int repos = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - (i + 1); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        repos = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = repos;
                    }
                }
            }
        }
    }
}
