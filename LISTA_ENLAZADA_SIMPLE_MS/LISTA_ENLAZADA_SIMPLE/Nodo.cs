using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_ENLAZADA_SIMPLE
{
    internal class Nodo
    {
        private int numero;
        private Nodo siguiente;

        public int Numero { get => numero; set => numero = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
