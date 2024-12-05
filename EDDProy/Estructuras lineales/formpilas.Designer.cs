namespace EDDemo
{
    partial class formpilas
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
            this.Buscar = new System.Windows.Forms.Button();
            this.buttonpush = new System.Windows.Forms.Button();
            this.buttonvaciar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Valores = new System.Windows.Forms.ListBox();
            this.cajainsertar = new System.Windows.Forms.TextBox();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.buttongrafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(450, 128);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(85, 40);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // buttonpush
            // 
            this.buttonpush.Location = new System.Drawing.Point(450, 47);
            this.buttonpush.Name = "buttonpush";
            this.buttonpush.Size = new System.Drawing.Size(85, 43);
            this.buttonpush.TabIndex = 1;
            this.buttonpush.Text = "push";
            this.buttonpush.UseVisualStyleBackColor = true;
            this.buttonpush.Click += new System.EventHandler(this.buttonpush_Click);
            // 
            // buttonvaciar
            // 
            this.buttonvaciar.Location = new System.Drawing.Point(411, 223);
            this.buttonvaciar.Name = "buttonvaciar";
            this.buttonvaciar.Size = new System.Drawing.Size(114, 62);
            this.buttonvaciar.TabIndex = 2;
            this.buttonvaciar.Text = "Vaciar";
            this.buttonvaciar.UseVisualStyleBackColor = true;
            this.buttonvaciar.Click += new System.EventHandler(this.buttonvaciar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(232, 228);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(118, 57);
            this.buttoneliminar.TabIndex = 3;
            this.buttoneliminar.Text = "Pop";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ingresa el valor de la pila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ingresa el valor a buscar";
            // 
            // Valores
            // 
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(607, 14);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(135, 384);
            this.Valores.TabIndex = 6;
            // 
            // cajainsertar
            // 
            this.cajainsertar.Location = new System.Drawing.Point(305, 55);
            this.cajainsertar.Name = "cajainsertar";
            this.cajainsertar.Size = new System.Drawing.Size(100, 26);
            this.cajainsertar.TabIndex = 7;
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(305, 135);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 8;
            // 
            // buttongrafica
            // 
            this.buttongrafica.Location = new System.Drawing.Point(330, 332);
            this.buttongrafica.Name = "buttongrafica";
            this.buttongrafica.Size = new System.Drawing.Size(103, 44);
            this.buttongrafica.TabIndex = 9;
            this.buttongrafica.Text = "Grafica";
            this.buttongrafica.UseVisualStyleBackColor = true;
            this.buttongrafica.Click += new System.EventHandler(this.buttongrafica_Click);
            // 
            // formpilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttongrafica);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajainsertar);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonvaciar);
            this.Controls.Add(this.buttonpush);
            this.Controls.Add(this.Buscar);
            this.Name = "formpilas";
            this.Text = "formpilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button buttonpush;
        private System.Windows.Forms.Button buttonvaciar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.TextBox cajainsertar;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.Button buttongrafica;
    }
}