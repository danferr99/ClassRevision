using REVISAO_H1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace REVISAO_H1.Entidades
{
    public class FilaEstaticaInteiros : IFila<int>
    {
        public int Inicio { get; private set; }
        public int Final { get; private set; }

        public int TamanhoMaximo { get; private set; }

        private int[] VetorElementos { get; set; }


        public FilaEstaticaInteiros(int tamanhoMaximo)
        {
            TamanhoMaximo = tamanhoMaximo;
            VetorElementos = new int[tamanhoMaximo];
            Inicio = Final = 0;
        }

        public int Desenfilera()
        {
            if (EstaVazia())
            {
                throw new ArgumentException("Fila Vazia , elemento não removido");
            }
            int retorno = VetorElementos[Inicio];

            for (int i = 0; i < Final - 1; i++)
            {
                VetorElementos[i] = VetorElementos[i + 1];
            }
            VetorElementos[Final] = 0;

            Final--;

            return retorno;
        }

        public void Enfilera(int obj)
        {
            if (EstaCheia())
            {
                throw new ArgumentException("Fila cheia , elemento não inserido");
            }
            VetorElementos[Final] = obj;
            Final++;
        }

        public bool EstaVazia()
        {
            return Inicio == Final;
        }

        public IEnumerable<int> Imprime()
        {
            for (int i = 0; i < Final ; i++)
            {
                yield return VetorElementos[i];
            }
        }

        public int Tamanho()
        {
            return Final;
        }

        public bool EstaCheia()
        {
            return Final == TamanhoMaximo;
        }

        public IEnumerable<int> MultiPop(int k)


        {
            if (k > Tamanho ())

                    throw new ArgumentException 

                    ($"Não foi possível remover {k} . " + 
                    $"Pois a pilha tem {Tamanho()} elementos. ");


            for (int i = 0; i< k; i++)

            {

                yield return Desempilha();


            }




        }


    }
}
