using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoNumeroSecretoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocalizarNumeroSecreto();
        }
        static void LocalizarNumeroSecreto()
        {
            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1, 101);

            int tentativa;
            int numeroTentativas = 1;

            do
            {
                Console.WriteLine("Escolha um número entre 1 e 100");
                tentativa = int.Parse(Console.ReadLine());

                if (numeroSecreto == tentativa)
                {
                    Console.WriteLine($"Você acertou com {numeroTentativas} tentativas");

                }
                else
                {
                    if (numeroSecreto > tentativa)
                    {
                        Console.WriteLine($"O número secreto é maior que {tentativa}");
                    }
                    else
                    {
                        Console.WriteLine($"O número secreto é menor que {tentativa}");
                    }

                    Console.WriteLine("Clique no enter para tentar novamente");
                    Console.ReadKey();
                    Console.Clear();
                }
                numeroTentativas++;
            }
            while (tentativa != numeroSecreto);

        }
    }
}
