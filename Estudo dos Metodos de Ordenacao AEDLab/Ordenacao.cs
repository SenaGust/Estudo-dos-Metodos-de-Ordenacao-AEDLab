using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    abstract class Ordenacao
    {
        public int Comparacoes { get; set; }
        public int Trocas { get; set; }

        public Ordenacao()
        {
            Comparacoes = 0;
            Trocas = 0;
        }

        public abstract void Sort(int[] vetor);

        /// <summary>
        /// Esse método troca duas posições que se encontram dentro do vetor
        /// </summary>
        /// <param name="vetor">Vetor onde será trocado</param>
        /// <param name="posA">Posição do primeiro valor a ser trocado</param>
        /// <param name="posB">Posição do segundo valor a ser trocado</param>
        public void Trocar(int[] vetor, int posA, int posB)
        {
            Trocas++;
            int aux = vetor[posA];
            vetor[posA] = vetor[posB];
            vetor[posB] = aux;
        }
        /// <summary>
        /// Exibe número de comparações e trocas, respectivamente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0};{1}", Comparacoes, Trocas);
        }
    }
}
