namespace EDDemo
{
    partial class Formfibonacci
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
            this.buttonsiguiente = new System.Windows.Forms.Button();
            this.valores = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsiguiente
            // 
            this.buttonsiguiente.Location = new System.Drawing.Point(298, 213);
            this.buttonsiguiente.Name = "buttonsiguiente";
            this.buttonsiguiente.Size = new System.Drawing.Size(117, 44);
            this.buttonsiguiente.TabIndex = 0;
            this.buttonsiguiente.Text = "siguiente";
            this.buttonsiguiente.UseVisualStyleBackColor = true;
            this.buttonsiguiente.Click += new System.EventHandler(this.buttonsiguiente_Click);
            // 
            // valores
            // 
            this.valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.valores.FormattingEnabled = true;
            this.valores.ItemHeight = 20;
            this.valores.Location = new System.Drawing.Point(450, 0);
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(139, 450);
            this.valores.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(295, 142);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ingresa el numero";
            // 
            // Formfibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.valores);
            this.Controls.Add(this.buttonsiguiente);
            this.Name = "Formfibonacci";
            this.Text = "Formfibonacci";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonsiguiente;
        private System.Windows.Forms.ListBox valores;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}