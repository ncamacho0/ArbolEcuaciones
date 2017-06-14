using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesArbol
{
    class Nodo
    {
        private string _ecuacion { get; }
        public string ecuacion { get { return _ecuacion; } }

        public Nodo arbolIzquierda { get; set; }
        public Nodo arbolDerecha { get; set; }
        public Nodo listaSiguiente { get; set; }
        public Nodo listaAnterior { get; set; }

        public Nodo(string nodo)
        {
            _ecuacion = nodo;
            arbolIzquierda = null;
            arbolDerecha = null;
            listaSiguiente = null;
            listaAnterior = null;
        }

        public override string ToString()
        {
            return _ecuacion + "";
        }

    }
}
