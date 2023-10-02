using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabSemana02
{
     class ListaSimple
    {
        private Nodo vinicio;

        public Nodo inicio
        {
            get { return vinicio; }
            set { vinicio = value; }
        }

        public ListaSimple()
        {
            inicio = null;
        }


        public void insertaAlFinal(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (inicio == null)
                inicio = nuevo;
            else
            {
                Nodo actual = inicio;
                while (actual.sgte != null)
                { actual = actual.sgte; }
                actual.sgte = nuevo;
            }
        }

      
        public void mostrar(ListBox lst)
        {
            Nodo actual = inicio;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }

        public ListaSimple devolverCopia()
        {
            ListaSimple resultado = new ListaSimple();
            Nodo actual = inicio;
            while (actual != null)
            {
                resultado.insertaAlFinal(actual.info);
                actual = actual.sgte;
            }
            return resultado;
        }

        public void insertaListaDespues(ListaSimple listaB)
        {
            Nodo actualA = inicio;

            while (actualA.sgte != null)
            {
                actualA = actualA.sgte;
            }
            ListaSimple copia = listaB.devolverCopia();

            actualA.sgte = copia.inicio;

        }
        public ListaSimple Interseccion(ListaSimple otraLista)
        {
            ListaSimple resultado = new ListaSimple();
            Nodo actual = inicio;
            while (actual != null)
            {
                if (otraLista.Contiene(actual.info))
                {
                    resultado.insertaAlFinal(actual.info);
                }
                actual = actual.sgte;
            }
            return resultado;
        }
        public bool Contiene(int valor)
        {
            Nodo actual = inicio;
            while (actual != null)
            {
                if (actual.info == valor)
                {
                    return true;
                }
                actual = actual.sgte;
            }
            return false;
        }


    }
}
