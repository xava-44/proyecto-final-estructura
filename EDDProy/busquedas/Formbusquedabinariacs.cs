using EDDemo.busquedas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo
{
    public partial class Formbusquedabinariacs : Form
    {
        busquedabinar busquedabinaria;
        int[] array;
            
        public Formbusquedabinariacs()
        {
            InitializeComponent();
            busquedabinaria=new busquedabinar();
            
        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {
            int dato = (int)numericUpDown1.Value;

              array=busquedabinar.crearlista(dato);

            busquedabinar.sort(array, 0, array.Length - 1);

            imprimirdatos(array);


        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBoxbuscar.Text);
                Stopwatch tiempo = Stopwatch.StartNew();
                int valor = busquedabinar.busqueda(array, num, 0, array.Length);
                tiempo.Stop();

                if (valor == -1)
                {
                    MessageBox.Show("no se encuentra el numero  en la lista");
                }
                else
                {

                    MessageBox.Show("se encontro el numero :" + num);
                    MessageBox.Show("El tiempo transcurrido es :" + tiempo.ElapsedMilliseconds + "ms");
                }
            }catch(Exception ex)
            {

                MessageBox.Show("ingrese un dato a buscar");
            }
          
        }

        private void imprimirdatos(int[] array)
        // este metod privado no retona valor y muestra los elementos que se agragaron ala BusquedaList
        {
            valores.Items.Clear();
            // se limpia la listbox llamada valores
            foreach (int item in array)
            // ciclo foreach el cual itera con item
            {
                valores.Items.Add(item);
                // se agrega a listbox valores los elementos de la lista Busquedalist
            }

        }

       






    }
}
