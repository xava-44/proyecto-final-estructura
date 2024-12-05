using EDDemo.Estructuras_No_Lineales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class formpilas : Form
    {
        public static Nodo top = null;
        public static Nodo bottom = null;
        public List<int> BusquedaList;
        public formpilas()
        {
            InitializeComponent();
            BusquedaList = new List<int>();
        }
        public class Nodo
        {
            public int valor;
            public Nodo sig;

            public Nodo(int valor, Nodo sig)
            {
                this.valor = valor;
                this.sig = sig;
            }



        }

        private void buttonpush_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(cajainsertar.Text);


                Nodo nuevo = new Nodo(valor, null);

                if (top == null)
                {
                    top = nuevo;
                    bottom = nuevo;
                }
                else
                {
                    Nodo aux = top;
                    top = nuevo;
                    top.sig = aux;
                }
                BusquedaList.Add(valor);
                cajainsertar.Clear();
                Mostrarelementos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("valor incorrecto");

            }


        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            if (top == null)
            {
                MessageBox.Show("no hay elementos en la pila");
            }
            else
            {
                int valor = int.Parse(cajabuscar.Text);
                Nodo aux = top;
                int pos = 1;
                bool encontrado = false;

                while (aux != null)
                {

                    if (valor == aux.valor)
                    {
                        MessageBox.Show("el valor buscado se encontro en la posicion:" + pos);
                        encontrado = true;
                        cajabuscar.Clear();
                        aux = null;
                    }
                    else
                    {
                        aux = aux.sig;
                    }
                    pos++;
                }

                if (!encontrado)
                {
                    MessageBox.Show("no se encontro el numero buscado");

                    cajabuscar.Clear();
                }
            }

        }

        private void buttonvaciar_Click(object sender, EventArgs e)
        {

            if (top == null)
            {
                MessageBox.Show("pila vacia");

            }
            else
            {
                while (top != null)
                {
                    Nodo aux = top;
                    top = top.sig;
                    aux = null;
                }
                Valores.Items.Clear();
                BusquedaList.Clear();
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {

            if (top == null)
            {
                MessageBox.Show("pila vacia");

            }
            else
            {
                int valor = top.valor;
                Nodo aux = top;
                top = top.sig;
                aux = null;
                MessageBox.Show("se elimino de la pila :" + valor);
                Valores.Items.Remove(valor);

            }

        }

        private void Mostrarelementos()
        {
            //    Valores.Items.Clear();

            //    foreach (int item in BusquedaList)
            //    {
            //        Valores.Items.Add(item);
            //    }


            Valores.Items.Clear(); // Limpiar el ListBox antes de agregar los elementos

            Nodo aux = top; // Empezar desde el inicio de la lista

            while (aux != null) // Recorrer la lista
            {
                Valores.Items.Add(aux.valor); // Agregar el valor del nodo al ListBox
                aux = aux.sig; // Moverse al siguiente nodo

            }
        }

        private void buttongrafica_Click(object sender, EventArgs e)
        {
             String ToDot(Nodo nodo)
            {
                StringBuilder bs = new StringBuilder();
                if (nodo.sig!= null)
                {
                    bs.AppendFormat("{0}->{1} [side=L] {2} ", nodo.valor.ToString(), nodo.sig.valor.ToString(), Environment.NewLine);
                    bs.Append(ToDot(nodo.sig));
                    
                }

                //if (nodo.Der != null)
                //{
                //    b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                //    b.Append(ToDot(nodo.Der));
                //}
                return bs.ToString();
            }

            String graphVizString;

            Nodo principal = top;
            if (principal == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { ");
            b.AppendLine("rankdir=LR;");
         b.AppendLine( "node [shape=\"rectangle\"]; " + Environment.NewLine);
            b.Append(ToDot(top));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }
    }
}
