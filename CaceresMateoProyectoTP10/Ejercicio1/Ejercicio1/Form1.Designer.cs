﻿namespace Ejercicio1
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
            variable = new TextBox();
            mensaje = new Label();
            boton = new Button();
            SuspendLayout();
            // 
            // variable
            // 
            variable.Location = new Point(256, 200);
            variable.Name = "variable";
            variable.Size = new Size(269, 23);
            variable.TabIndex = 0;
            variable.TextChanged += variable_TextChanged;
            // 
            // mensaje
            // 
            mensaje.AutoSize = true;
            mensaje.Location = new Point(342, 79);
            mensaje.Name = "mensaje";
            mensaje.Size = new Size(105, 15);
            mensaje.TabIndex = 1;
            mensaje.Text = "Ingrese su nombre";
            mensaje.Click += mensaje_Click;
            // 
            // boton
            // 
            boton.Location = new Point(360, 305);
            boton.Name = "boton";
            boton.Size = new Size(75, 23);
            boton.TabIndex = 2;
            boton.Text = "Enviar";
            boton.UseVisualStyleBackColor = true;
            boton.Click += boton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(boton);
            Controls.Add(mensaje);
            Controls.Add(variable);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox variable;
        private Label mensaje;
        private Button boton;
    }
}