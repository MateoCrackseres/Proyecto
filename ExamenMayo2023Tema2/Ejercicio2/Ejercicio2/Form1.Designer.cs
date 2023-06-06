namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            datos = new TextBox();
            texto = new Label();
            boton = new Button();
            SuspendLayout();
            // 
            // datos
            // 
            datos.Location = new Point(274, 232);
            datos.Name = "datos";
            datos.Size = new Size(247, 23);
            datos.TabIndex = 0;
            // 
            // texto
            // 
            texto.AutoSize = true;
            texto.Location = new Point(274, 214);
            texto.Name = "texto";
            texto.Size = new Size(247, 15);
            texto.TabIndex = 1;
            texto.Text = "Ingrese la cantidad de productos que compró";
            // 
            // boton
            // 
            boton.Location = new Point(359, 261);
            boton.Name = "boton";
            boton.Size = new Size(75, 23);
            boton.TabIndex = 2;
            boton.Text = "Siguiente";
            boton.UseVisualStyleBackColor = true;
            boton.Click += boton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boton);
            Controls.Add(texto);
            Controls.Add(datos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox datos;
        private Label texto;
        private Button boton;
    }
}