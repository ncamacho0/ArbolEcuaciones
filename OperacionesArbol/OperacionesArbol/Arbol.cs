using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesArbol
{
    class Arbol
    {

        private Nodo inicio, final, raiz, inicioPila, finalPila, pila;

        public void agregarLista(Nodo n)
        {
            if (inicio != null)
                agregar(n, inicio);
            else
                inicio = n;

        }
        private void agregar(Nodo n, Nodo ultimo)
        {
            if (ultimo.listaSiguiente == null)
            {
                ultimo.listaSiguiente = n;
                n.listaAnterior = ultimo;
                final = n;
            }
            else
                agregar(n, ultimo.listaSiguiente);
        }


        private void push(Nodo n)
        {
            if (inicioPila == null)
                inicioPila = n;
            else
                agregarAPila(n, inicioPila);
        }

        private void agregarAPila(Nodo n, Nodo ultimo)
        {
            if (ultimo.listaSiguiente == null)
            {
                ultimo.listaSiguiente = n;
                n.listaAnterior = ultimo;
                finalPila = n;
            }
            else
                agregarAPila(n, ultimo.listaSiguiente);
        }


        private string pop()
        {
            string num;
            num = Convert.ToString(finalPila.ecuacion);
            finalPila = finalPila.listaAnterior;
            if (finalPila != null)
                finalPila.listaSiguiente = null;
            return num;
        }

        public void obtenerArbol()
        {
            raiz = null;
            string sSigno;

            Nodo actual = inicio, anterior = null, siguiente = null;
            while (actual != null) 
            {
                siguiente = actual.listaSiguiente;
                sSigno = Convert.ToString(actual.ecuacion);
                if (sSigno == "*" || sSigno == "/")
                {
                    raiz = actual;
                    actual.arbolIzquierda = actual.listaAnterior;
                    actual.arbolDerecha = actual.listaSiguiente;
                    eliminarNodos(actual, anterior, siguiente);
                }
                anterior = actual;
                actual = actual.listaSiguiente;
            }

            actual = inicio;
            anterior = null;
            siguiente = null;
            while (actual != null) 
            {
                siguiente = actual.listaSiguiente;
                sSigno = Convert.ToString(actual.ecuacion);
                if (sSigno == "+" || sSigno == "-")
                {
                    raiz = actual;
                    actual.arbolIzquierda = actual.listaAnterior;
                    actual.arbolDerecha = actual.listaSiguiente;
                    eliminarNodos(actual, anterior, siguiente);
                }
                anterior = actual;
                actual = actual.listaSiguiente;
            }
            inicio = null;
        }


        private void eliminarNodos(Nodo actual, Nodo anterior, Nodo siguiente)
        {
            if (actual.listaAnterior == inicio)
            {
                inicio = inicio.listaSiguiente;
                inicio.listaAnterior = null;
            }
            else
            {
                actual.listaAnterior = anterior.listaAnterior;
                anterior.listaAnterior.listaSiguiente = actual;
            }

            if (actual.listaSiguiente == final)
            {
                final.listaAnterior.listaSiguiente = null;
                final = final.listaAnterior;
            }
            else
            {
                actual.listaSiguiente = siguiente.listaSiguiente;
                siguiente.listaSiguiente.listaAnterior = actual;
            }
        }


        public string PostOrden()
        {
            if (raiz != null)
                return PostOrder(raiz);
            else
                return null;
        }

        private string PostOrder(Nodo n)
        {
            string lista = "";
            if (n.arbolIzquierda != null)
            {
                lista += PostOrder(n.arbolIzquierda); // Izq

            }
            if (n.arbolDerecha != null)
            {
                lista += PostOrder(n.arbolDerecha);// Der
            }
            lista += n.ToString();// Raiz

            return lista;
        }


        public string resolverPostOrden()
        {
            int res = 0;
            string resultado = "";
            Nodo actual = inicio;

            while (actual != null) 
            {
                if (Char.IsNumber(Convert.ToChar(actual.ecuacion)) == true)
                {
                    pila = new Nodo(actual.ecuacion);
                    push(pila);
                }
                else
                {
                    string signo = actual.ToString();
                    string sRes;
                    int num1 = Convert.ToInt32(pop());
                    int num2 = Convert.ToInt32(pop());
                    if (signo == "+")
                        res = num2 + num1;
                    if (signo == "-")
                        res = num2 - num1;
                    if (signo == "*")
                        res = num2 * num1; 
                    if (signo == "/")
                        res = num2 / num1;
                    sRes = Convert.ToString(res);
                    pila = new Nodo(sRes);
                    push(pila);
                }
                actual = actual.listaSiguiente;
                if (actual == null)
                    resultado = Convert.ToString(pop());
            }
            inicioPila = null;
            finalPila = null;
            inicio = null;
            return resultado;
        }

        public string PreOrden()
        {
            if (raiz != null)
                return PreOrder(raiz);
            else
                return null;

        }

        private string PreOrder(Nodo n)
        {
            string lista = "";
            lista += n.ToString();// Raiz
            if (n.arbolIzquierda != null)
            {
                lista += PreOrder(n.arbolIzquierda); // Izq
            }
            if (n.arbolDerecha != null)
            {
                lista += PreOrder(n.arbolDerecha);// Der
            }
            return lista;
        }

        public string resolverPreOrden()
        {
            int res = 0;
            string respuesta = null;
            Nodo actual = final;
            while (actual != null)
            {
                if (Char.IsNumber(Convert.ToChar(actual.ecuacion)) == true)
                {
                    pila = new Nodo(actual.ecuacion);
                    push(pila);
                }
                else
                {
                    string signo = actual.ToString();
                    string sRes;
                    int num1 = Convert.ToInt32(pop()), num2 = Convert.ToInt32(pop());
                    if (signo == "+")
                        res = num2 + num1;
                    if (signo == "-")
                        res = num2 - num1;
                    if (signo == "*")
                        res = num2 * num1;
                    if (signo == "/")
                        res = num2 / num1;
                    sRes = Convert.ToString(res);
                    pila = new Nodo(sRes);
                    push(pila);
                }
                actual = actual.listaAnterior;
                if (actual == null)
                    respuesta = Convert.ToString(pop());
            }
            inicioPila = null;
            finalPila = null;
            inicio = null;
            return respuesta;
        }

        
    }
}
