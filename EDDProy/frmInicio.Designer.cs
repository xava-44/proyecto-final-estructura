
namespace EDDemo
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estructuraLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIlasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIstasDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasCircularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosDeBusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosRecursivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exponencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaDeUnArregloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructuraLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem,
            this.algoritmosDeBusquedaToolStripMenuItem,
            this.algoritmosRecursivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1192, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructuraLinealesToolStripMenuItem
            // 
            this.estructuraLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIlasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasSimplesToolStripMenuItem,
            this.lIstasDoblesToolStripMenuItem,
            this.listasCircularesToolStripMenuItem});
            this.estructuraLinealesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estructuraLinealesToolStripMenuItem.Image = global::EDDemo.Properties.Resources.descarga__1_;
            this.estructuraLinealesToolStripMenuItem.Name = "estructuraLinealesToolStripMenuItem";
            this.estructuraLinealesToolStripMenuItem.Size = new System.Drawing.Size(241, 36);
            this.estructuraLinealesToolStripMenuItem.Text = "Estructura lineales ";
            // 
            // pIlasToolStripMenuItem
            // 
            this.pIlasToolStripMenuItem.Name = "pIlasToolStripMenuItem";
            this.pIlasToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.pIlasToolStripMenuItem.Text = "PIlas";
            this.pIlasToolStripMenuItem.Click += new System.EventHandler(this.pIlasToolStripMenuItem_Click_1);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // listasSimplesToolStripMenuItem
            // 
            this.listasSimplesToolStripMenuItem.Name = "listasSimplesToolStripMenuItem";
            this.listasSimplesToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.listasSimplesToolStripMenuItem.Text = "Listas simples ";
            this.listasSimplesToolStripMenuItem.Click += new System.EventHandler(this.listasSimplesToolStripMenuItem_Click);
            // 
            // lIstasDoblesToolStripMenuItem
            // 
            this.lIstasDoblesToolStripMenuItem.Name = "lIstasDoblesToolStripMenuItem";
            this.lIstasDoblesToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.lIstasDoblesToolStripMenuItem.Text = "LIstas dobles";
            this.lIstasDoblesToolStripMenuItem.Click += new System.EventHandler(this.lIstasDoblesToolStripMenuItem_Click);
            // 
            // listasCircularesToolStripMenuItem
            // 
            this.listasCircularesToolStripMenuItem.Name = "listasCircularesToolStripMenuItem";
            this.listasCircularesToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.listasCircularesToolStripMenuItem.Text = "Listas circulares";
            this.listasCircularesToolStripMenuItem.Click += new System.EventHandler(this.listasCircularesToolStripMenuItem_Click);
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estructurasNoLibealesToolStripMenuItem.Image = global::EDDemo.Properties.Resources.descarga;
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no lineales";
            this.estructurasNoLibealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasNoLibealesToolStripMenuItem_Click);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // algoritmosDeBusquedaToolStripMenuItem
            // 
            this.algoritmosDeBusquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaBinariaToolStripMenuItem,
            this.hAstToolStripMenuItem});
            this.algoritmosDeBusquedaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmosDeBusquedaToolStripMenuItem.Image = global::EDDemo.Properties.Resources.descarga__2_;
            this.algoritmosDeBusquedaToolStripMenuItem.Name = "algoritmosDeBusquedaToolStripMenuItem";
            this.algoritmosDeBusquedaToolStripMenuItem.Size = new System.Drawing.Size(291, 36);
            this.algoritmosDeBusquedaToolStripMenuItem.Text = "Algoritmos de busqueda";
            // 
            // busquedaBinariaToolStripMenuItem
            // 
            this.busquedaBinariaToolStripMenuItem.Name = "busquedaBinariaToolStripMenuItem";
            this.busquedaBinariaToolStripMenuItem.Size = new System.Drawing.Size(278, 36);
            this.busquedaBinariaToolStripMenuItem.Text = "Busqueda binaria";
            this.busquedaBinariaToolStripMenuItem.Click += new System.EventHandler(this.busquedaBinariaToolStripMenuItem_Click);
            // 
            // hAstToolStripMenuItem
            // 
            this.hAstToolStripMenuItem.Name = "hAstToolStripMenuItem";
            this.hAstToolStripMenuItem.Size = new System.Drawing.Size(278, 36);
            this.hAstToolStripMenuItem.Text = "Hash";
            this.hAstToolStripMenuItem.Click += new System.EventHandler(this.hAstToolStripMenuItem_Click);
            // 
            // algoritmosRecursivosToolStripMenuItem
            // 
            this.algoritmosRecursivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.factorialToolStripMenuItem,
            this.exponencialToolStripMenuItem,
            this.fibonacciToolStripMenuItem,
            this.sumaDeUnArregloToolStripMenuItem});
            this.algoritmosRecursivosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmosRecursivosToolStripMenuItem.Name = "algoritmosRecursivosToolStripMenuItem";
            this.algoritmosRecursivosToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.algoritmosRecursivosToolStripMenuItem.Text = "Algoritmos recursivos";
            // 
            // factorialToolStripMenuItem
            // 
            this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
            this.factorialToolStripMenuItem.Size = new System.Drawing.Size(299, 36);
            this.factorialToolStripMenuItem.Text = "Factorial";
            this.factorialToolStripMenuItem.Click += new System.EventHandler(this.factorialToolStripMenuItem_Click);
            // 
            // exponencialToolStripMenuItem
            // 
            this.exponencialToolStripMenuItem.Name = "exponencialToolStripMenuItem";
            this.exponencialToolStripMenuItem.Size = new System.Drawing.Size(299, 36);
            this.exponencialToolStripMenuItem.Text = "Exponencial ";
            this.exponencialToolStripMenuItem.Click += new System.EventHandler(this.exponencialToolStripMenuItem_Click);
            // 
            // fibonacciToolStripMenuItem
            // 
            this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
            this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(299, 36);
            this.fibonacciToolStripMenuItem.Text = "Fibonacci";
            this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.fibonacciToolStripMenuItem_Click);
            // 
            // sumaDeUnArregloToolStripMenuItem
            // 
            this.sumaDeUnArregloToolStripMenuItem.Name = "sumaDeUnArregloToolStripMenuItem";
            this.sumaDeUnArregloToolStripMenuItem.Size = new System.Drawing.Size(299, 36);
            this.sumaDeUnArregloToolStripMenuItem.Text = "Suma de un arreglo";
            this.sumaDeUnArregloToolStripMenuItem.Click += new System.EventHandler(this.sumaDeUnArregloToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1192, 654);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIlasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIstasDoblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasCircularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosDeBusquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosRecursivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaBinariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exponencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaDeUnArregloToolStripMenuItem;
    }
}

