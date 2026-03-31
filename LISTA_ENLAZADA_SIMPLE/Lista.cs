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
        public void Eliminar(int num)
        {
            Nodo actual = primero;
            Nodo anterior = null;
            while(actual!=null)
            {
                if(actual.Numero==num)
                {
                    if (actual == primero)
                        primero = primero.Siguiente;
                    else if (actual == ultimo)
                    {
                        anterior.Siguiente = null;
                        ultimo = anterior;
                    }
                    else
                        anterior.Siguiente = actual.Siguiente;
                }
                anterior = actual;
                actual=actual.Siguiente;
            }
        }
        public bool Buscar(int num)
        {
            Nodo actual = primero;
            while(actual!=null)
            {
                if (actual.Numero == num)
                    return true;
                actual = actual.Siguiente;
            }
            return false;
        }
        public void Ordenar()
        {
            Nodo actual = primero;
            while(actual!=null)
            {
                Nodo sig = actual.Siguiente;
                while(sig!=null)
                {
                    if(actual.Numero>sig.Numero)
                    {
                        int temp = actual.Numero;
                        actual.Numero = sig.Numero;
                        sig.Numero = temp;
                    }
                    sig = sig.Siguiente;
                }
                actual = actual.Siguiente;
            }
        }
    }
}
