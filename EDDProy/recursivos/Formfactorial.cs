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

namespace EDDemo
{
    public partial class Formfactorial : Form
    {
        public static List<int> BusquedaList;

        public Formfactorial()
        {
            InitializeComponent();
            BusquedaList = new List<int>();
        }

        private void textBoxvalor_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonsiguiente_Click(object sender, EventArgs e)
        {
           
            int fac = int.Parse(textBoxvalor.Text);
            // se asigna a un variable de tipo int , el valor de tipo texto de CajaTexto4 y se convierte a un int

            Stopwatch tiempo = Stopwatch.StartNew();
            // se una variable de la clase Stopwatch , usando un metodo para medir el tiempo 
 
            
            MessageBox.Show("el factorial es :" + factorial(fac));
            //se muestra el mensaje con una cadena concatenando el metodo factorial el cual regresa el factorial de un numero dado7
            mostrardatos();

            tiempo.Stop();
            // se detiene el tiempo 
            MessageBox.Show("El tiempo transcurrido es :" + tiempo.ElapsedMilliseconds + "ms");
            // se muestra el un mensaje con una cadena concatenado con la variable tiempo usando un metodo que muetra el tiempo en milisegundos
        }

        public static int factorial(int num)
        // metodo publico estatico que regresa un int , el cual es el factorial de un numero dado
        { 
            
            if (num == 1)
            // condicional if para comparar si el parametro es igual a uno 
            {

                return num;
                // si es igual entonces lo regresara
            } 
            BusquedaList.Add(num);

            return num * factorial(num - 1);
            // si no es igaul a uno entonces el parametro se multiplica por el metodo factorial decrementando en uno su parametro

        }
        public void mostrardatos()
        {
            valores.Items.Clear();

            foreach (int item in BusquedaList)
            {
                valores.Items.Add(item);
            }

        }
    }
}
