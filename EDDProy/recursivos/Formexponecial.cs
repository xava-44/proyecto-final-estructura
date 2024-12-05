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
    public partial class Formexponecial : Form
    {
        public Formexponecial()
        {
            InitializeComponent();
        }

        private void buttonprocesar_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(textBoxvalor.Text);
            // se le asigna a una variable de tipo int , el texto que recibe CajaNumero convitiendo a un tipo de dato int
            //int expo = int.Parse(TextoExpo.Text);
            int expo = (int)numericUpDown1.Value;


            // se le asigna a una variable de tipo int , el texto que recibe CajaExpo convitiendo a un tipo de dato int

            Stopwatch tiempo = Stopwatch.StartNew();
            // se una variable de la clase Stopwatch , usando un metodo para medir el tiempo 

            MessageBox.Show("El resultado es :" + Exponente(numero, expo));
            //  se muestra el mensaje con una cadena concatenado con el metodo Exponenteel cual recibe dos  parametro numero y el exponente

            tiempo.Stop();
            //se detiene el contador de tiempo

            MessageBox.Show("El tiempo transcurrido es :" + tiempo.ElapsedMilliseconds + "ms");
            // se muestra el un mensaje con una cadena concatenado con la variable tiempo usando un metodo que mue
        }


        static int Exponente(int baseNum, int expo)
        // metodo publico estatico que retorna el exponente de un numero dado   
        {

            if (expo == 0)
            // si el exponente es igual a cero , retorna uno
            {
                return 1;
            }
            // Caso base cualquier número elevado a 1 es el mismo número
            if (expo == 1)
            {
                return baseNum;
            }
            // Caso recursivo baseNum elevado a expo
            return baseNum * Exponente(baseNum, expo - 1);
        }

    }
}
