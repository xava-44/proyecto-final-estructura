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
    public partial class FormListasimple : Form
    {
        public static Nodo inicio = null;
        public static Nodo final = null;
        public List<int> BusquedaList;
        public FormListasimple()
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

       

        private void FormListasimple_Load(object sender, EventArgs e)
        {

        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(cajainsertar.Text);


                Nodo nuevo = new Nodo(valor, null);

                if (inicio == null)
                {
                    inicio = nuevo;
                    final = nuevo;
                }
                else
                {
                    nuevo.sig = inicio;
                    inicio = nuevo;
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

        private void botoninsertapos_Click(object sender, EventArgs e)
        {

            if (inicio == null)
            {
                MessageBox.Show("no se acreado un lista");
            }
            else
            {

                try
                {
                    int valor = int.Parse(cajainsertarvalor.Text);
                    int pos = int.Parse(cajaposicion.Text);
                    Nodo nuevo = new Nodo(valor, null);

                    if (pos == 0)
                    {
                        nuevo.sig = inicio;
                        inicio = nuevo;



                    }
                    else
                    {
                        Nodo aux = inicio;
                        int indice = 0;

                        while (aux != null && indice < pos - 1)
                        {

                            aux = aux.sig;

                            indice++;
                        }

                        if (aux == null)
                        {
                            MessageBox.Show("posicion fuera de la lista ");
                        }

                        nuevo.sig = aux.sig;
                        aux.sig = nuevo;



                        if (nuevo.sig == null)
                        {
                            final = nuevo;


                        }

                    }
                    BusquedaList.Add(valor);
                    cajainsertar.Clear();
                    Mostrarelementos();




                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se a creado un lista");
                }
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

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (inicio == null)
                {
                    MessageBox.Show("lista vacia");

                }
                else
                {


                    int pos = int.Parse(cajaeliminar.Text);


                    if (pos == 0)
                    {
                        int valorinicio = inicio.valor;
                        Nodo aux = inicio;
                        inicio = inicio.sig;
                        aux = null;



                    }
                    else
                    {
                        Nodo aux = inicio;
                        int indice = 1;

                        while (aux != null && indice < pos - 1)
                        {

                            aux = aux.sig;

                            indice++;
                        }

                        if (aux == null || aux.sig == null)
                        {
                            MessageBox.Show("posicion fuera de la lista ");
                            return;
                        }

                        Nodo nodotem = aux.sig;
                        aux.sig = nodotem.sig;


                        if (nodotem.sig == null)
                        {
                            final = aux;


                        }


                        nodotem = null;
                    }

                    cajaeliminar.Clear();
                    Mostrarelementos();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cajaeliminar.Clear();
            }


        }

        private void buttonvaciar_Click(object sender, EventArgs e)
        {

            if (inicio == null)
            {
                MessageBox.Show("pila vacia");

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

        private void buttongraficar_Click(object sender, EventArgs e)
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
