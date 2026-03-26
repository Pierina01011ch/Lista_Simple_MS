using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA_ENLAZADA_SIMPLE
{
    internal class Lista
    {
        private Nodo primero = null;
        private Nodo ultimo = null;

        public void Insertar(int num)
        {
            Nodo nuevo = new Nodo();
            nuevo.Numero = num;
            if(primero==null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }
        }

        public void Mostrar(ListBox list)
        {
            Nodo actual = primero;
            while(actual!=null)
            {
                list.Items.Add(actual.Numero);
                actual = actual.Siguiente;
            }
        }
    }
}
