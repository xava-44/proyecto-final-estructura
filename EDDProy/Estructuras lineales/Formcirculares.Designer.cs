namespace EDDemo
{
    partial class Formcirculares
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
            this.label4 = new System.Windows.Forms.Label();
            this.cajaeliminar = new System.Windows.Forms.TextBox();
            this.Valores = new System.Windows.Forms.ListBox();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.cajainsertar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonvaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "ingresa el valor a eliminar";
            // 
            // cajaeliminar
            // 
            this.cajaeliminar.Location = new System.Drawing.Point(275, 235);
            this.cajaeliminar.Name = "cajaeliminar";
            this.cajaeliminar.Size = new System.Drawing.Size(100, 26);
            this.cajaeliminar.TabIndex = 22;
            // 
            // Valores
            // 
            this.Valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(680, 0);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(120, 450);
            this.Valores.TabIndex = 21;
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(275, 145);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 20;
            // 
            // cajainsertar
            // 
            this.cajainsertar.Location = new System.Drawing.Point(275, 85);
            this.cajainsertar.Name = "cajainsertar";
            this.cajainsertar.Size = new System.Drawing.Size(100, 26);
            this.cajainsertar.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ingresa el valor a buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "ingresa el valor a insertar";
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(413, 71);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(122, 40);
            this.buttoninsertar.TabIndex = 24;
            this.buttoninsertar.Text = "Insertar";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(407, 145);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(122, 42);
            this.buttonbuscar.TabIndex = 25;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(407, 220);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(128, 41);
            this.buttoneliminar.TabIndex = 26;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonvaciar
            // 
            this.buttonvaciar.Location = new System.Drawing.Point(275, 320);
            this.buttonvaciar.Name = "buttonvaciar";
            this.buttonvaciar.Size = new System.Drawing.Size(93, 47);
            this.buttonvaciar.TabIndex = 27;
            this.buttonvaciar.Text = "Vaciar";
            this.buttonvaciar.UseVisualStyleBackColor = true;
            this.buttonvaciar.Click += new System.EventHandler(this.buttonvaciar_Click);
            // 
            // Formcirculares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonvaciar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cajaeliminar);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajainsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formcirculares";
            this.Text = "Formcirculares";
            this.Load += new System.EventHandler(this.Formcirculares_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cajaeliminar;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.TextBox cajainsertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonvaciar;
    }
}