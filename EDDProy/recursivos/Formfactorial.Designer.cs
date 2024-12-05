namespace EDDemo
{
    partial class Formfactorial
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
            this.botonsiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxvalor = new System.Windows.Forms.TextBox();
            this.valores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // botonsiguiente
            // 
            this.botonsiguiente.Location = new System.Drawing.Point(136, 214);
            this.botonsiguiente.Name = "botonsiguiente";
            this.botonsiguiente.Size = new System.Drawing.Size(118, 29);
            this.botonsiguiente.TabIndex = 0;
            this.botonsiguiente.Text = "siguiente";
            this.botonsiguiente.UseVisualStyleBackColor = true;
            this.botonsiguiente.Click += new System.EventHandler(this.botonsiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "introduce un numero";
            // 
            // textBoxvalor
            // 
            this.textBoxvalor.Location = new System.Drawing.Point(145, 128);
            this.textBoxvalor.Name = "textBoxvalor";
            this.textBoxvalor.Size = new System.Drawing.Size(100, 26);
            this.textBoxvalor.TabIndex = 2;
            this.textBoxvalor.TextChanged += new System.EventHandler(this.textBoxvalor_TextChanged);
            // 
            // valores
            // 
            this.valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.valores.FormattingEnabled = true;
            this.valores.ItemHeight = 20;
            this.valores.Location = new System.Drawing.Point(355, 0);
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(120, 505);
            this.valores.TabIndex = 3;
            // 
            // Formfactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 505);
            this.Controls.Add(this.valores);
            this.Controls.Add(this.textBoxvalor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonsiguiente);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Formfactorial";
            this.Text = "Formfactorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonsiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxvalor;
        private System.Windows.Forms.ListBox valores;
    }
}