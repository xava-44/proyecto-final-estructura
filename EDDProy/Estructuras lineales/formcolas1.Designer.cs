namespace EDDemo
{
    partial class formcolas1
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
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.cajainsertar = new System.Windows.Forms.TextBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.Vaciar = new System.Windows.Forms.Button();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Valores = new System.Windows.Forms.ListBox();
            this.buttongrafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(296, 143);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 0;
            // 
            // cajainsertar
            // 
            this.cajainsertar.Location = new System.Drawing.Point(296, 71);
            this.cajainsertar.Name = "cajainsertar";
            this.cajainsertar.Size = new System.Drawing.Size(100, 26);
            this.cajainsertar.TabIndex = 1;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(428, 132);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(102, 47);
            this.buttonbuscar.TabIndex = 2;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(401, 255);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(129, 58);
            this.buttoneliminar.TabIndex = 3;
            this.buttoneliminar.Text = "Dequeve";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // Vaciar
            // 
            this.Vaciar.Location = new System.Drawing.Point(156, 257);
            this.Vaciar.Name = "Vaciar";
            this.Vaciar.Size = new System.Drawing.Size(134, 55);
            this.Vaciar.TabIndex = 4;
            this.Vaciar.Text = "Vaciar";
            this.Vaciar.UseVisualStyleBackColor = true;
            this.Vaciar.Click += new System.EventHandler(this.Vaciar_Click);
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(428, 63);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(102, 43);
            this.buttoninsertar.TabIndex = 5;
            this.buttoninsertar.Text = "Enqueve";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Introduce los valores ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "indroduce el valor a buscar";
            // 
            // Valores
            // 
            this.Valores.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(595, 21);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(144, 404);
            this.Valores.TabIndex = 8;
            // 
            // buttongrafica
            // 
            this.buttongrafica.Location = new System.Drawing.Point(284, 364);
            this.buttongrafica.Name = "buttongrafica";
            this.buttongrafica.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttongrafica.Size = new System.Drawing.Size(140, 44);
            this.buttongrafica.TabIndex = 9;
            this.buttongrafica.Text = "Grafica";
            this.buttongrafica.UseVisualStyleBackColor = true;
            this.buttongrafica.Click += new System.EventHandler(this.buttongrafica_Click);
            // 
            // formcolas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttongrafica);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.Vaciar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.cajainsertar);
            this.Controls.Add(this.cajabuscar);
            this.Name = "formcolas1";
            this.Text = "formcolas1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.TextBox cajainsertar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button Vaciar;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.Button buttongrafica;
    }
}