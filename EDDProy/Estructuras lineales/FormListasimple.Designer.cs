namespace EDDemo
{
    partial class FormListasimple
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
            this.cajaeliminar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cajainsertarvalor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cajaposicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.cajainsertar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Valores = new System.Windows.Forms.ListBox();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.botoninsertapos = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonvaciar = new System.Windows.Forms.Button();
            this.buttongraficar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaeliminar
            // 
            this.cajaeliminar.Location = new System.Drawing.Point(314, 397);
            this.cajaeliminar.Name = "cajaeliminar";
            this.cajaeliminar.Size = new System.Drawing.Size(100, 26);
            this.cajaeliminar.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 42);
            this.label5.TabIndex = 30;
            this.label5.Text = "ingresa la posicion \r\ndel nodo a eliminar";
            // 
            // cajainsertarvalor
            // 
            this.cajainsertarvalor.Location = new System.Drawing.Point(314, 142);
            this.cajainsertarvalor.Name = "cajainsertarvalor";
            this.cajainsertarvalor.Size = new System.Drawing.Size(100, 26);
            this.cajainsertarvalor.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 42);
            this.label4.TabIndex = 27;
            this.label4.Text = "ingresa el valor del\r\n   nodo a insetar";
            // 
            // cajaposicion
            // 
            this.cajaposicion.Location = new System.Drawing.Point(314, 218);
            this.cajaposicion.Name = "cajaposicion";
            this.cajaposicion.Size = new System.Drawing.Size(100, 26);
            this.cajaposicion.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 42);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ingresa la posicion donde \r\nquieres insertar el nodo";
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(314, 298);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 22;
            // 
            // cajainsertar
            // 
            this.cajainsertar.Location = new System.Drawing.Point(314, 60);
            this.cajainsertar.Name = "cajainsertar";
            this.cajainsertar.Size = new System.Drawing.Size(100, 26);
            this.cajainsertar.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "ingresa el valor a buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "inserta valores para \r\ncrear un lista";
            // 
            // Valores
            // 
            this.Valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.Valores.FormattingEnabled = true;
            this.Valores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(680, 0);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(120, 780);
            this.Valores.TabIndex = 33;
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(441, 52);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(129, 39);
            this.buttoninsertar.TabIndex = 34;
            this.buttoninsertar.Text = "Insertar";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // botoninsertapos
            // 
            this.botoninsertapos.Location = new System.Drawing.Point(434, 214);
            this.botoninsertapos.Name = "botoninsertapos";
            this.botoninsertapos.Size = new System.Drawing.Size(186, 35);
            this.botoninsertapos.TabIndex = 35;
            this.botoninsertapos.Text = "Insertar por pocision";
            this.botoninsertapos.UseVisualStyleBackColor = true;
            this.botoninsertapos.Click += new System.EventHandler(this.botoninsertapos_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(434, 288);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(136, 46);
            this.buttonbuscar.TabIndex = 36;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(441, 387);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(129, 46);
            this.buttoneliminar.TabIndex = 37;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonvaciar
            // 
            this.buttonvaciar.Location = new System.Drawing.Point(301, 486);
            this.buttonvaciar.Name = "buttonvaciar";
            this.buttonvaciar.Size = new System.Drawing.Size(123, 43);
            this.buttonvaciar.TabIndex = 38;
            this.buttonvaciar.Text = "vaciar";
            this.buttonvaciar.UseVisualStyleBackColor = true;
            this.buttonvaciar.Click += new System.EventHandler(this.buttonvaciar_Click);
            // 
            // buttongraficar
            // 
            this.buttongraficar.Location = new System.Drawing.Point(301, 596);
            this.buttongraficar.Name = "buttongraficar";
            this.buttongraficar.Size = new System.Drawing.Size(123, 48);
            this.buttongraficar.TabIndex = 39;
            this.buttongraficar.Text = "graficar";
            this.buttongraficar.UseVisualStyleBackColor = true;
            this.buttongraficar.Click += new System.EventHandler(this.buttongraficar_Click);
            // 
            // FormListasimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 780);
            this.Controls.Add(this.buttongraficar);
            this.Controls.Add(this.buttonvaciar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.botoninsertapos);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.cajaeliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cajainsertarvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cajaposicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajainsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormListasimple";
            this.Text = "FormListasimple";
            this.Load += new System.EventHandler(this.FormListasimple_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cajaeliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cajainsertarvalor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cajaposicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.TextBox cajainsertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.Button botoninsertapos;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonvaciar;
        private System.Windows.Forms.Button buttongraficar;
    }
}