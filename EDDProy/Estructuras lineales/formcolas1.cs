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
    public partial class formcolas1 : Form
    {  public static Nodo inicio = null;
        public static Nodo final = null;
        public List<int> BusquedaList;

        public formcolas1()
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

        private void buttoninsertar_Click(object sender, EventArgs e)
        {

            try
            {
                int valor = int.Parse(cajainsertar.Text);
                Nodo nuevo = new Nodo(valor, null);

                if (final == null)
                {

                    final = nuevo;
                    inicio = nuevo;
                }
                else
                {
                    final.sig = nuevo;
                    final = nuevo;
                }

                BusquedaList.Add(valor);
                cajainsertar.Clear();
                Mostrarelementos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("dato incorrecto");
            }

        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {


            if (inicio == null)
            {
                MessageBox.Show("no hay elementos en la cola");

            }

            else
            {
                int valor = int.Parse(cajabuscar.Text);
                Nodo aux = inicio;
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

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            if (inicio == null)
            {

                MessageBox.Show("cola vacia");
                final = null;
            }
            else
            {
                int valor = inicio.valor;
                Nodo aux = inicio;
                inicio = inicio.sig;
                aux = null;
                MessageBox.Show("se elimino el valor" + valor + "de la cola");
                Valores.Items.Remove(valor);
            }
        }

        private void Vaciar_Click(object sender, EventArgs e)
        {
            if (inicio == null)
            {
                MessageBox.Show("la cola esta vacia");

            }
            else
            {
                while (inicio != null)
                {
                    Nodo aux = inicio;
                    inicio = inicio.sig;
                    aux = null;
                }
                Valores.Items.Clear();
                BusquedaList.Clear();
            }
        }
        private void Mostrarelementos()
        {
            Valores.Items.Clear();

            foreach (int item in BusquedaList)
            {
                Valores.Items.Add(item);
            }

        }

        private void buttongrafica_Click(object sender, EventArgs e)
        {
            String ToDot(Nodo nodo)
            {
                StringBuilder bs = new StringBuilder();
                if (nodo.sig != null)
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

            Nodo principal = inicio;
            if (principal == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { ");
            b.AppendLine("rankdir=LR;");
            b.AppendLine("node [shape=\"rectangle\"]; " + Environment.NewLine);
            b.Append(ToDot(inicio));
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
