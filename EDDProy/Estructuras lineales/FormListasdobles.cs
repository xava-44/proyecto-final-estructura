using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class FormListasdobles : Form
    {
        public static Nodo inicio = null;
        public static Nodo final = null;
        public List<int> BusquedaList;

        public FormListasdobles()
        {
            InitializeComponent();
            BusquedaList = new List<int>();
        }
        public class Nodo
        {
            public int valor;
            public Nodo sig;
            public Nodo ant;

            public Nodo(int valor, Nodo sig, Nodo ant)
            {
                this.valor = valor;
                this.sig = sig;
                this.ant = ant;
            }



        }

        private void buttonagregar_Click(object sender, EventArgs e)
        {


            try
            {
                int valor = int.Parse(cajaagregar.Text);


                Nodo nuevo = new Nodo(valor, null, null);

                if (inicio == null && final == null)
                {
                    inicio = nuevo;
                    final = nuevo;
                }
                else
                {
                    nuevo.sig = inicio;
                    inicio.ant = nuevo;
                    inicio = nuevo;
                }
                BusquedaList.Add(valor);
                cajaagregar.Clear();
                Mostrarelementos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("valor incorrecto");

            }

        }


        





































        private void Mostrarelementos()
        {
            Valores.Items.Clear();
            Nodo aux = inicio;

            while (aux != null)
            {
                Valores.Items.Add(aux.valor);
                aux = aux.sig;

            }
        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            if (inicio == null)
            {
                MessageBox.Show("no se acreado un lista");
                cajaposicion.Clear();
                cajavalor.Clear();
            }


            try
            {
                int valor = int.Parse(cajavalor.Text);
                int pos = int.Parse(cajaposicion.Text);
                Nodo nuevo = new Nodo(valor, null, null);

                if (pos == 0)
                {
                    nuevo.sig = inicio;
                    inicio.ant = nuevo;
                    inicio = nuevo;

                }
                else
                {
                    Nodo aux = inicio;
                    int indice = 0;

                    while (aux != null && indice < pos)
                    {

                        aux = aux.sig;

                        indice++;
                    }

                    if (aux != null)
                    {
                        nuevo.sig = aux;
                        nuevo.ant = aux.ant;

                        if (aux.ant != null)
                        {
                            aux.ant.sig = nuevo;


                        }
                        aux.ant = nuevo;
                    }
                    else
                    {
                        nuevo.ant = final;

                        if (final != null)
                        {
                            final.sig = nuevo;
                        }
                        final = nuevo;
                    }

                }

                BusquedaList.Add(valor);
                cajaposicion.Clear();
                Mostrarelementos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se a creado un lista");
            }




        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            if (inicio == null)
            {
                MessageBox.Show("no hay elementos en la lista");

            }
            else
            {
                int valor = int.Parse(cajabuscar.Text);
                Nodo aux = inicio;
                int pos = 0;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {

            try
            {
                int pos = int.Parse(cajaeliminar.Text);
                if (inicio == null && final == null)
                {
                    MessageBox.Show("lista vacia");
                    return;
                }
                else if (pos == 0)
                {

                    Nodo aux = inicio;
                    if (inicio == final)
                    {
                        inicio = null;
                        final = null;

                    }
                    else
                    {
                        inicio = inicio.sig;
                        inicio.ant = null;
                    }
                    aux = null;
                    cajaeliminar.Clear();
                    Mostrarelementos();
                    return;



                }
                else
                {
                    Nodo aux = inicio;
                    int indice = 0;
                    while (aux != null && indice < pos)
                    {
                        aux = aux.sig;


                        indice++;
                    }
                    if (aux == null)
                    {
                        MessageBox.Show("Posición fuera de la lista.");
                        return;
                    }


                    if (aux.ant != null)
                    {
                        aux.ant.sig = aux.sig;
                    }

                    if (aux.sig != null)
                    {
                        aux.sig.ant = aux.ant;
                    }
                    else
                    {
                        final = aux.ant;
                    }

                    aux = null;

                    cajaeliminar.Clear();
                    Mostrarelementos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se a creado un lista");
            }
        }

        private void buttonvaciar_Click(object sender, EventArgs e)
        {
            if (inicio == null)
            {
                MessageBox.Show("La lista está vacía.");
                return;
            }

            while (inicio != null)
            {
                Nodo aux = inicio;
                inicio = inicio.sig;


                if (inicio != null)
                {
                    inicio.ant = null;
                }


            }

            final = null;
            Valores.Items.Clear();
            BusquedaList.Clear();

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

               // if (nodo.ant != null)
               // {
               //     bs.AppendFormat("{0}->{1} [side=R] {2} ", nodo.valor.ToString(), nodo.ant.valor.ToString(), Environment.NewLine);
               //     bs.Append(ToDot(nodo.ant));
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
