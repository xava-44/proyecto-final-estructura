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
    public partial class Formsuma : Form
    {
        public int[] array;
        public static List<int> BusquedaList;
        public Formsuma()
        {
            InitializeComponent();
            BusquedaList = new List<int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                MessageBox.Show("total de la suma :" + SumarElementos(array, 0));

            }
            catch

            {
                MessageBox.Show("ocurrio un error ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tam = (int)numericUpDown1.Value;
            array = crearlista(tam);

            imprimirdatos(array);

        }

        static int SumarElementos(int[] arreglo, int indice)
        // el metodo regresa la cantidad de la suma de los elementos de un arreglo
        {

            if (indice == arreglo.Length)
            // si ya se recorrio el arreglo , retorna 0
            {
                return 0;
            }

            return arreglo[indice] + SumarElementos(arreglo, indice + 1);
            // sino el arreglo se suma al metodo SumarElementos incrementando en uno     
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
        public static int[] crearlista(int tam)
        {
            Random rnd = new Random();

            int[] a = new int[tam];
            for (int i = 0; i < a.Length; i++)
            {


                a[i] = rnd.Next(1, 100);



            }

            return a;
        }
    }
}
