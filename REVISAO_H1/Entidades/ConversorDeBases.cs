using System;

using System.Collections.Generic;

using System.Text;



namespace REVISAO_H1.Entidades

{

    public class ConversorDeBases

    {

        public int ValorN { get; private set; }

        public int ValorBase { get; private set; }



        private PilhaEstatica p { get; set; }



        public ConversorDeBases(int valorN, int valorBase)

        {

            ValorN = valorN;

            ValorBase = valorBase;

            p = new PilhaEstatica();

        }



        public string valorConvertido()

        {

            int quociente = -1;

            int resto = -1;

            int divisor = ValorN;

            while (quociente != 0)

            {



                quociente = divisor / ValorBase;

                resto = divisor % ValorBase;

                divisor = quociente;

                p.Empilha(resto);

            }



            string valorFinal = "";

            int tamanho = p.Tamanho();

            for (int i = 0; i < tamanho; i++)

            {

                valorFinal = valorFinal + p.Desempilha().ToString();

            }

            return valorFinal;

        }

    }

}

