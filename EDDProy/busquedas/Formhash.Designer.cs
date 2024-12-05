namespace EDDemo
{
    partial class Formhash
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
            this.Elementos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttoninsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxvalor = new System.Windows.Forms.TextBox();
            this.textBoxbuscar = new System.Windows.Forms.TextBox();
            this.textBoxclave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttoninicializar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Elementos
            // 
            this.Elementos.Dock = System.Windows.Forms.DockStyle.Left;
            this.Elementos.FormattingEnabled = true;
            this.Elementos.ItemHeight = 20;
            this.Elementos.Location = new System.Drawing.Point(0, 0);
            this.Elementos.Name = "Elementos";
            this.Elementos.Size = new System.Drawing.Size(250, 817);
            this.Elementos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "mostrar elementos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoninsertar
            // 
            this.buttoninsertar.Location = new System.Drawing.Point(459, 310);
            this.buttoninsertar.Name = "buttoninsertar";
            this.buttoninsertar.Size = new System.Drawing.Size(163, 45);
            this.buttoninsertar.TabIndex = 2;
            this.buttoninsertar.Text = "Insertar";
            this.buttoninsertar.UseVisualStyleBackColor = true;
            this.buttoninsertar.Click += new System.EventHandler(this.buttoninsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "introduce el elemento";
            // 
            // textBoxvalor
            // 
            this.textBoxvalor.Location = new System.Drawing.Point(584, 167);
            this.textBoxvalor.Name = "textBoxvalor";
            this.textBoxvalor.Size = new System.Drawing.Size(100, 26);
            this.textBoxvalor.TabIndex = 4;
            // 
            // textBoxbuscar
            // 
            this.textBoxbuscar.Location = new System.Drawing.Point(584, 483);
            this.textBoxbuscar.Name = "textBoxbuscar";
            this.textBoxbuscar.Size = new System.Drawing.Size(100, 26);
            this.textBoxbuscar.TabIndex = 5;
            this.textBoxbuscar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxclave
            // 
            this.textBoxclave.Location = new System.Drawing.Point(584, 234);
            this.textBoxclave.Name = "textBoxclave";
            this.textBoxclave.Size = new System.Drawing.Size(100, 26);
            this.textBoxclave.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "introduce la clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "introduce la clave ";
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(459, 574);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(163, 45);
            this.buttonbuscar.TabIndex = 10;
            this.buttonbuscar.Text = "buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttoninicializar
            // 
            this.buttoninicializar.Location = new System.Drawing.Point(321, 31);
            this.buttoninicializar.Name = "buttoninicializar";
            this.buttoninicializar.Size = new System.Drawing.Size(182, 52);
            this.buttoninicializar.TabIndex = 11;
            this.buttoninicializar.Text = "inicializar elementos";
            this.buttoninicializar.UseVisualStyleBackColor = true;
            this.buttoninicializar.Click += new System.EventHandler(this.buttoninicializar_Click);
            // 
            // Formhash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 817);
            this.Controls.Add(this.buttoninicializar);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxclave);
            this.Controls.Add(this.textBoxbuscar);
            this.Controls.Add(this.textBoxvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoninsertar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Elementos);
            this.Name = "Formhash";
            this.Text = "Formhash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Elementos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttoninsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxvalor;
        private System.Windows.Forms.TextBox textBoxbuscar;
        private System.Windows.Forms.TextBox textBoxclave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttoninicializar;
    }
}