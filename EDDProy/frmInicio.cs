using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }       

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pIlasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                Form mPilas = new formpilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form colas = new formcolas1();
            colas.MdiParent = this;
            colas.Show();
        }

        private void listasSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form simple = new FormListasimple();
            simple.MdiParent = this;
            simple.Show();

        }

        private void lIstasDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form simple = new FormListasdobles();
            simple.MdiParent = this;
            simple.Show();
           
        }

        private void listasCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                  Form circulares = new Formcirculares();
            circulares.MdiParent = this;
            circulares.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Form busqueda01 = new Formbusquedabinariacs();
            busqueda01.MdiParent = this;
           busqueda01.Show(); 
        }

        private void hAstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                   Form hash = new Formhash();
            hash.MdiParent = this;
            hash.Show();
        }

        private void exponencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form expo = new Formexponecial();
            expo.MdiParent = this;
            expo.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form factorial= new Formfactorial();
            factorial.MdiParent = this;
            factorial.Show();



        }

        //private void busquedaBinariaToolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //    Form binaria  = new Formbinariacs();
        //    binaria.MdiParent = this;
        //    binaria.Show();

        //}

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fibonacci = new Formfibonacci();
            fibonacci.MdiParent = this;
            fibonacci.Show();
        }

        private void sumaDeUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form suma= new Formsuma();
            suma.MdiParent = this;
            suma.Show();

        }

    }
}
