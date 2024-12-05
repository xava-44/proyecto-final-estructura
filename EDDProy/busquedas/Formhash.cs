using EDDemo.busquedas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDDemo
{
    public partial class Formhash : Form
    {
        public bool activado = false;
        metodoshash objec = new metodoshash();

        public Formhash()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (activado == true)
            {
                MostrarEnTextBox();
            }
            else
            {
                MessageBox.Show("no sean inicializado los datos");
                return;

            }




        }

        public void agregardatos()
        {
            try
            {
                string datos = @"archivos/paises.txt";
                if (File.Exists(datos))
                {
                    string[] lineas = File.ReadAllLines(datos);

                    foreach (string linea in lineas)
                    {
                        string[] partes = linea.Split('.');
                        if (partes.Length == 2)
                        {
                            int clave = int.Parse(partes[0].Trim());
                            string valor = partes[1].Trim();
                            objec.Insertar(clave, valor);
                        }
                        else
                        {
                            MessageBox.Show("no se genero el formato esperado ");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("El archivo no existe. Asegúrate de que 'datos.txt' esté en el directorio correcto.");
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ocurrio un error al inicializar los datos ");
                return;
            }

        }

        public void MostrarEnTextBox()
        {

            Elementos.Items.Clear();

            for (int i = 0; i < objec.settam(); i++)
            {

                if (objec.claves[i] != -1)
                {

                    string texto = $"Clave: {objec.claves[i]}, Valor: {objec.valores[i]}";


                    Elementos.Items.Add(texto + Environment.NewLine);
                }
            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = int.Parse(textBoxbuscar.Text);

                Stopwatch tiempo = Stopwatch.StartNew();

                string res = objec.Buscar(clave);
                tiempo.Stop();


                if (res != null)
                {
                    MessageBox.Show("clave:" + clave + " " + "pais:" + res);
                    MessageBox.Show("El tiempo transcurrido es :" + tiempo.ElapsedMilliseconds + "ms");
                }
                else
                {
                    MessageBox.Show("no se encontro la clave buscada ");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("introduce un valor a buscar");



            }

        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            try

            {
                int clave = int.Parse(textBoxclave.Text);
                string valor = (string)(textBoxvalor.Text);

                foreach (int com in objec.claves)
                {

                    if (com == clave)
                    {
                        MessageBox.Show("la clave ya esta resgistrada");
                        return;
                    }


                }

                objec.Insertar(clave, valor);

                MessageBox.Show("se inserto la clave:" + clave + "," + "valor:" + valor);
                MostrarEnTextBox();
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show("ocurrio un error al ingresar los datos ");
                return;
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoninicializar_Click(object sender, EventArgs e)
        {
            activado = true;
            agregardatos();
            MessageBox.Show("se inicializaron los datos correctamente");
        }
    }
}