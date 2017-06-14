using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesArbol
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        Nodo charEcuacion;
        Arbol miArbol = new Arbol();
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string ecuacion = txtOperacion.Text;
            char[] arrayEcuacion = ecuacion.ToCharArray();
            foreach (char x in arrayEcuacion)
            {
                charEcuacion = new Nodo(Convert.ToString(x));
                miArbol.agregarLista(charEcuacion);
            }

            miArbol.obtenerArbol();
            txtPostOrden.Text = miArbol.PostOrden();
            txtPreOrden.Text = miArbol.PreOrden();
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            string sPostOrden = txtPostOrden.Text;
            char[] arrayPostOrden = sPostOrden.ToCharArray();
            foreach (char x in arrayPostOrden)
            {
                charEcuacion = new Nodo(Convert.ToString(x));
                miArbol.agregarLista(charEcuacion);
            }

            txtPostOrdenResultado.Text = miArbol.resolverPostOrden();
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            string lPre = txtPreOrden.Text;

            char[] array = lPre.ToCharArray();

            foreach (char x in array)
            {
                charEcuacion = new Nodo(Convert.ToString(x));
                miArbol.agregarLista(charEcuacion);
            }

            txtPreOrdenResultado.Text = miArbol.resolverPreOrden();

        }
    }
}
