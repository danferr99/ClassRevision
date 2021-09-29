using REVISAO_H1.Entidades;
using System;

namespace REVISAO_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            FilaEstaticaInteiros f = new FilaEstaticaInteiros(10);
            f.Enfilera(10);
            f.Enfilera(20);
            int t = f.Tamanho();
            bool b = f.EstaVazia();
            bool b1 = f.EstaCheia();
            int x = f.Desenfilera();

            Console.WriteLine("Teste Fila!");
            Console.ReadLine();
        }
    }
}
