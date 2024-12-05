namespace EDDemo.Estructuras_Lineales
{
    partial class FormListasdobles
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaagregar = new System.Windows.Forms.TextBox();
            this.cajavalor = new System.Windows.Forms.TextBox();
            this.cajaposicion = new System.Windows.Forms.TextBox();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.cajaeliminar = new System.Windows.Forms.TextBox();
            this.Valores = new System.Windows.Forms.ListBox();
            this.buttonagregar = new System.Windows.Forms.Button();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonvaciar = new System.Windows.Forms.Button();
            this.buttongrafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 40);
            this.label5.TabIndex = 29;
            this.label5.Text = "ingresa la posicion \r\ndel nodo a eliminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 40);
            this.label4.TabIndex = 19;
            this.label4.Text = "ingresa los valores \r\nde la lista doble";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "ingresa el valor a buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ingresa la posicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ingresa el valor a insertar";
            // 
            // cajaagregar
            // 
            this.cajaagregar.Location = new System.Drawing.Point(290, 62);
            this.cajaagregar.Name = "cajaagregar";
            this.cajaagregar.Size = new System.Drawing.Size(100, 26);
            this.cajaagregar.TabIndex = 32;
            // 
            // cajavalor
            // 
            this.cajavalor.Location = new System.Drawing.Point(290, 140);
            this.cajavalor.Name = "cajavalor";
            this.cajavalor.Size = new System.Drawing.Size(100, 26);
            this.cajavalor.TabIndex = 33;
            // 
            // cajaposicion
            // 
            this.cajaposicion.Location = new System.Drawing.Point(290, 205);
            this.cajaposicion.Name = "cajaposicion";
            this.cajaposicion.Size = new System.Drawing.Size(100, 26);
            this.cajaposicion.TabIndex = 34;
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(290, 272);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 35;
            this.cajabuscar.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cajaeliminar
            // 
            this.cajaeliminar.Location = new System.Drawing.Point(290, 338);
            this.cajaeliminar.Name = "cajaeliminar";
            this.cajaeliminar.Size = new System.Drawing.Size(100, 26);
            this.cajaeliminar.TabIndex = 36;
            // 
            // Valores
            // 
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(639, 15);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(120, 584);
            this.Valores.TabIndex = 37;
            // 
            // buttonagregar
            // 
            this.buttonagregar.Location = new System.Drawing.Point(415, 57);
            this.buttonagregar.Name = "buttonagregar";
            this.buttonagregar.Size = new System.Drawing.Size(127, 37);
            this.buttonagregar.TabIndex = 38;
            this.buttonagregar.Text = "agregar";
            this.buttonagregar.UseVisualStyleBackColor = true;
            this.buttonagregar.Click += new System.EventHandler(this.buttonagregar_Click);
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(415, 197);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(127, 42);
            this.buttoninsertar.TabIndex = 39;
            this.buttoninsertar.Text = "insertar";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(415, 264);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(127, 43);
            this.buttonbuscar.TabIndex = 40;
            this.buttonbuscar.Text = "buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(415, 338);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(127, 36);
            this.buttoneliminar.TabIndex = 41;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonvaciar
            // 
            this.buttonvaciar.Location = new System.Drawing.Point(263, 441);
            this.buttonvaciar.Name = "buttonvaciar";
            this.buttonvaciar.Size = new System.Drawing.Size(143, 49);
            this.buttonvaciar.TabIndex = 42;
            this.buttonvaciar.Text = "vaciar";
            this.buttonvaciar.UseVisualStyleBackColor = true;
            this.buttonvaciar.Click += new System.EventHandler(this.buttonvaciar_Click);
            // 
            // buttongrafica
            // 
            this.buttongrafica.Location = new System.Drawing.Point(281, 549);
            this.buttongrafica.Name = "buttongrafica";
            this.buttongrafica.Size = new System.Drawing.Size(100, 50);
            this.buttongrafica.TabIndex = 43;
            this.buttongrafica.Text = "grafica";
            this.buttongrafica.UseVisualStyleBackColor = true;
            this.buttongrafica.Click += new System.EventHandler(this.buttongrafica_Click);
            // 
            // FormListasdobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.buttongrafica);
            this.Controls.Add(this.buttonvaciar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.buttonagregar);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.cajaeliminar);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajaposicion);
            this.Controls.Add(this.cajavalor);
            this.Controls.Add(this.cajaagregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormListasdobles";
            this.Text = "FormListasdobles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaagregar;
        private System.Windows.Forms.TextBox cajavalor;
        private System.Windows.Forms.TextBox cajaposicion;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.TextBox cajaeliminar;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.Button buttonagregar;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttoneliminar;
        public System.Windows.Forms.Button buttonvaciar;
        private System.Windows.Forms.Button buttongrafica;
    }
}