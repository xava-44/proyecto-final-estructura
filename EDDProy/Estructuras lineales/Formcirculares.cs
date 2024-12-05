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
    public partial class Formcirculares : Form
    {
        public static Nodo Inicio = null;

        public List<int> BusquedaList;
        public Formcirculares()
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

        private void Formcirculares_Load(object sender, EventArgs e)
        {

        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(cajainsertar.Text);

                Nodo nuevo = new Nodo(valor, null);

                if (Inicio == null)
                {

                    Inicio = nuevo;
                    nuevo.sig = Inicio;


                }
                else

                {
                    Nodo tem = Inicio;

                    while (tem.sig != Inicio)
                    {
                        tem = tem.sig;

                    }

                    tem.sig = nuevo;
                    nuevo.sig = Inicio;
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
            int valor = int.Parse(cajabuscar.Text);

            if (Inicio == null)
            {
                MessageBox.Show("no hay elementos en la lista");

            }
            else if (Inicio.valor == valor)
            {
                MessageBox.Show("se encontro el valor " + valor);
            }
            else
            {

                Nodo aux = Inicio;
                var encontrado = false;

                while (aux != null)
                {

                    if (valor == aux.valor)
                    {

                        MessageBox.Show("el valor buscado :" + valor + " se encontro!!! ");
                        encontrado = true;
                        cajabuscar.Clear();
                        aux = null;
                    }
                    else
                    {
                        aux = aux.sig;
                    }


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

                int valor = int.Parse(cajaeliminar.Text);
                if (Inicio == null)
                {
                    MessageBox.Show("lista vacia");
                    return;
                }
                if (Inicio.valor == valor)
                {
                    Nodo aux = Inicio;


                    if (Inicio.sig == Inicio)
                    {
                        Inicio = null;  // La lista queda vacía
                    }
                    else
                    {
                        // Si hay más de un nodo, actualizamos el primer nodo
                        Nodo ultimo = Inicio;
                        while (ultimo.sig != Inicio)
                        {
                            ultimo = ultimo.sig;  // Llegamos al último nodo
                        }

                        // Actualizamos el puntero de último nodo para que apunte al siguiente nodo de Inicio
                        ultimo.sig = Inicio.sig;
                        Inicio = Inicio.sig;


                    }
                    MessageBox.Show("se elimino el valor :" + aux.valor);
                    aux = null;
                    Valores.Items.Remove(valor);
                    return;
                }
                else

                {
                    Nodo temp = Inicio;

                    while (temp.sig.valor != valor)
                    {
                        temp = temp.sig;

                    }

                    if (temp.sig.valor == valor)
                    {
                        Nodo aux = temp.sig;
                        temp.sig = temp.sig.sig;  // Se salta el nodo que se quiere eliminar

                        // Mostramos el mensaje de eliminación
                        MessageBox.Show("Se eliminó el valor: " + aux.valor);

                        // Liberamos el nodo
                        aux = null;

                        Valores.Items.Remove(valor);
                    }
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("no se encuentra el valor a eliminar");

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

        private void buttonvaciar_Click(object sender, EventArgs e)
        {
            if (Inicio == null)
            {
                MessageBox.Show("la cola esta vacia");

            }
            else
            {     Nodo temp= Inicio;
                while (temp.sig !=Inicio)
                {
                    Nodo aux = temp;
                    temp =temp.sig;
                    aux = null;
                }

              
                    Inicio = null;
                
                Valores.Items.Clear();
                BusquedaList.Clear();
            }
        }

    }
}
