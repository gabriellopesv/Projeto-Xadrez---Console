using System.Security.Cryptography.X509Certificates;
using tabuleiro;

namespace xadrez_console

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}