namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerif
            // 
            this.btnVerif.Location = new System.Drawing.Point(249, 229);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(54, 20);
            this.btnVerif.TabIndex = 0;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese una letra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbx
            // 
            this.txtbx.Location = new System.Drawing.Point(207, 229);
            this.txtbx.Name = "txtbx";
            this.txtbx.Size = new System.Drawing.Size(36, 20);
            this.txtbx.TabIndex = 2;
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(355, 203);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(10, 13);
            this.texto.TabIndex = 3;
            this.texto.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 396);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.txtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerif);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx;
        private System.Windows.Forms.Label texto;
    }
}

