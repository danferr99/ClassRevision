using System;
using System.Collections.Generic;
using System.Text;

namespace REVISAO_H1.Interfaces
{
    public interface IFila<T>
    {
        public void Enfilera(T obj);

        public T Desenfilera();

        public IEnumerable<T> Imprime();

        public int Tamanho();

        public bool EstaVazia();
        
        public IEnumerable<T> MultiPop(int k);



    }
}
