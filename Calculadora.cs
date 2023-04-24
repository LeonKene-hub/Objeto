using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Objetos
{
    public class Calculadora
    {
        public float n1;
        public float n2;

        public float Adicao(float n1, float n2)
        {
            return(n1 + n2);
        }

        public float Subtrcao(float n1, float n2)
        {
            return(n1 - n2);
        }

        public float Divisao(float n1, float n2)
        {
            return(n1 / n2);
        }

        public float Multiplicacao(float n1, float n2)
        {
            return(n1 * n2);
        }
    }
}