using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace Estudo_dos_Metodos_de_Ordenacao_AEDLab
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter gravacaoArquivo = new StreamWriter("dado.csv");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(10, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(20, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(30, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(40, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(50, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(60, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(70, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(80, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(90, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(100, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(800, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(900, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(1000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(1100, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(12000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(13000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(14000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(15000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(50000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(170000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(180000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(190000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.WriteLine(gerarRespostaConjunto(200000, true));
            gravacaoArquivo.WriteLine();
            Console.WriteLine("Terminou");

            gravacaoArquivo.Close();
            //Fim
            Console.Write("\n\nPressione qualquer tecla para continuar..");
            Console.ReadKey();
        }

        private static string gerarRespostaConjunto(int tamanhoConjunto, bool usarThread)
        {
            StringBuilder auxImpressao = new StringBuilder();
            int[] vetorBubble = new int[tamanhoConjunto], vetorInsertion = new int[tamanhoConjunto], vetorShell = new int[tamanhoConjunto], vetorHeap = new int[tamanhoConjunto], vetorQuick = new int[tamanhoConjunto];

            #region Aparentemente desnecessário
            ////Instaciando o Vetor
            //for (int pos = 0; pos < tamanhoConjunto; pos++)
            //{
            //    vetorQuick[pos] = new int();
            //    vetorHeap[pos] = new int();
            //    vetorShell[pos] = new int();
            //    vetorInsertion[pos] = new int();
            //    vetorBubble[pos] = new int();
            //}
            #endregion

            vetorBubble = GerarVetor(tamanhoConjunto);

            //Copiando Vetor
            for (int pos = 0; pos < tamanhoConjunto; pos++)
            {
                vetorQuick[pos] = vetorHeap[pos] = vetorShell[pos] = vetorInsertion[pos] = vetorBubble[pos];
            }

            // Instaciando objetos
            Bubble bubble = new Bubble();
            Insertion insertion = new Insertion();
            Shell shell = new Shell();
            Heap heap = new Heap();
            Quick quick = new Quick();

            Stopwatch stopWatch;
            if (usarThread)
            {
                #region Com Thread

                //Exemplo Thread threadFibonacci = new Thread(() => Fibonacci(respostaUsuario, ref resultadoFibo));
                Thread threadBubble = new Thread(() => bubble.Sort(vetorBubble));
                Thread threadInsertion = new Thread(() => insertion.Sort(vetorInsertion));
                Thread threadShell = new Thread(() => shell.Sort(vetorShell));
                Thread threadHeap = new Thread(() => heap.Sort(vetorHeap));
                Thread threadQuick = new Thread(() => quick.Sort(vetorQuick));

                stopWatch = Stopwatch.StartNew();
                //Iniciando threads
                threadBubble.Start();
                threadInsertion.Start();
                threadShell.Start();
                threadHeap.Start();
                threadQuick.Start();

                //Esperando todas acabarem
                threadQuick.Join();
                threadBubble.Join();
                threadInsertion.Join();
                threadShell.Join();
                threadHeap.Join();

                stopWatch.Stop();
                #endregion

            }
            else
            {
                stopWatch = Stopwatch.StartNew();
                //Iniciando ordenação
                bubble.Sort(vetorBubble);
                insertion.Sort(vetorInsertion);
                shell.Sort(vetorShell);
                heap.Sort(vetorHeap);
                quick.Sort(vetorQuick);

                stopWatch.Stop();
            }

            // Escrevendo resultados
            auxImpressao.AppendLine("Tamanho Conjunto: " + tamanhoConjunto);
            auxImpressao.AppendFormat("Bubble;{0};{1}\n", bubble.Comparacoes, bubble.Trocas);
            auxImpressao.AppendFormat("Insertion;{0};{1}\n", insertion.Comparacoes, insertion.Trocas);
            auxImpressao.AppendFormat("Shell;{0};{1}\n", shell.Comparacoes, shell.Trocas);
            auxImpressao.AppendFormat("Heap;{0};{1}\n", heap.Comparacoes, heap.Trocas);
            auxImpressao.AppendFormat("Quick;{0};{1}\n", quick.Comparacoes, quick.Trocas);
            auxImpressao.AppendFormat("Tempo: {0}\n", stopWatch.Elapsed);

            return auxImpressao.ToString();

            #region Usado para testar métodos
            ////Exibindo os resultados
            //Console.WriteLine("\tBubble");
            //ExibirVetor(vetorBubble);
            //bubble.Sort(vetorBubble);
            //ExibirVetor(vetorBubble);
            //Console.WriteLine();

            //Console.WriteLine("\tInsertion");
            //ExibirVetor(vetorInsertion);
            //insertion.Sort(vetorInsertion);
            //ExibirVetor(vetorInsertion);
            //Console.WriteLine();

            //Console.WriteLine("\tShell");
            //ExibirVetor(vetorShell);
            //shell.Sort(vetorShell);
            //ExibirVetor(vetorShell);
            //Console.WriteLine();

            //Console.WriteLine("\tBubble");
            //ExibirVetor(vetorHeap);
            //heap.Sort(vetorHeap);
            //ExibirVetor(vetorHeap);
            //Console.WriteLine();

            //Console.WriteLine("\tQuick");
            //ExibirVetor(vetorQuick);
            //quick.Sort(vetorQuick);
            //ExibirVetor(vetorQuick);
            //Console.WriteLine();
            #endregion
        }

        #region Vetor
        static int[] GerarVetor(int tamanho)
        {
            int[] vetorGerado = new int[tamanho];
            Random random = new Random();

            for (int pos = 0; pos < tamanho; pos++)
                vetorGerado[pos] = random.Next(tamanho);

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
