using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Shell shell = new Shell();


            int[] vetor = GerarVetor(10);
            ExibirVetor(vetor);

            shell.Sort(vetor);
            ExibirVetor(vetor);

            Console.WriteLine(shell.ToString());

            //Fim
            Console.Write("\n\nPressione qualquer tecla para continuar..");
            Console.ReadKey();
        }

        #region Vetor
        static int[] GerarVetor(int tamanho)
        {
            int[] vetorGerado = new int[tamanho];
            Random random = new Random();

            for (int pos = 0; pos < tamanho; pos++)
            {
                vetorGerado[pos] = random.Next(tamanho);

            }

            return vetorGerado;
        }

        static void ExibirVetor(int[] vetor)
        {
            for (int pos = 0; pos < vetor.Length; pos++)
                Console.Write(vetor[pos] + " ");

            Console.WriteLine();
        }
        #endregion
    }
}
