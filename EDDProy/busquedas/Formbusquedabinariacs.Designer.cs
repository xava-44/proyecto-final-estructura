namespace EDDemo
{
    partial class Formbusquedabinariacs
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
            this.textBoxbuscar = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.valores = new System.Windows.Forms.ListBox();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.buttoncrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxbuscar
            // 
            this.textBoxbuscar.Location = new System.Drawing.Point(319, 162);
            this.textBoxbuscar.Name = "textBoxbuscar";
            this.textBoxbuscar.Size = new System.Drawing.Size(100, 26);
            this.textBoxbuscar.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(319, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 2;
            // 
            // valores
            // 
            this.valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.valores.FormattingEnabled = true;
            this.valores.ItemHeight = 20;
            this.valores.Location = new System.Drawing.Point(632, 0);
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(168, 450);
            this.valores.TabIndex = 3;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Location = new System.Drawing.Point(467, 154);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(101, 37);
            this.buttonbuscar.TabIndex = 4;
            this.buttonbuscar.Text = "buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // buttoncrear
            // 
            this.buttoncrear.Location = new System.Drawing.Point(467, 52);
            this.buttoncrear.Name = "buttoncrear";
            this.buttoncrear.Size = new System.Drawing.Size(101, 37);
            this.buttoncrear.TabIndex = 5;
            this.buttoncrear.Text = "crear";
            this.buttoncrear.UseVisualStyleBackColor = true;
            this.buttoncrear.Click += new System.EventHandler(this.buttoncrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ingresa el numero a buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ingresa el tamaño de la lista";
            // 
            // Formbusquedabinariacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttoncrear);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.valores);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxbuscar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Formbusquedabinariacs";
            this.Text = "Formbusquedabinariacs";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxbuscar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox valores;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.Button buttoncrear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}