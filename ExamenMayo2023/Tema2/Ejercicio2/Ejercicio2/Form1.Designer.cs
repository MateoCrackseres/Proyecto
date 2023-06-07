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
            components = new System.ComponentModel.Container();
            datos = new TextBox();
            texto = new Label();
            boton = new Button();
            label2 = new Label();
            textbox2 = new TextBox();
            btnEnviar2 = new Button();
            label1 = new Label();
            ptotal = new Label();
            label3 = new Label();
            pfinal = new Label();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // datos
            // 
            datos.Location = new Point(12, 84);
            datos.Name = "datos";
            datos.Size = new Size(247, 23);
            datos.TabIndex = 0;
            // 
            // texto
            // 
            texto.AutoSize = true;
            texto.Location = new Point(12, 66);
            texto.Name = "texto";
            texto.Size = new Size(247, 15);
            texto.TabIndex = 1;
            texto.Text = "Ingrese la cantidad de productos que compró";
            // 
            // boton
            // 
            boton.Location = new Point(184, 113);
            boton.Name = "boton";
            boton.Size = new Size(75, 23);
            boton.TabIndex = 2;
            boton.Text = "Siguiente";
            boton.UseVisualStyleBackColor = true;
            boton.Click += boton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el precio del producto";
            // 
            // textbox2
            // 
            textbox2.Enabled = false;
            textbox2.Location = new Point(12, 183);
            textbox2.Name = "textbox2";
            textbox2.Size = new Size(247, 23);
            textbox2.TabIndex = 4;
            // 
            // btnEnviar2
            // 
            btnEnviar2.Enabled = false;
            btnEnviar2.Location = new Point(184, 212);
            btnEnviar2.Name = "btnEnviar2";
            btnEnviar2.Size = new Size(75, 23);
            btnEnviar2.TabIndex = 5;
            btnEnviar2.Text = "Siguiente";
            btnEnviar2.UseVisualStyleBackColor = true;
            btnEnviar2.Click += btnEnviar2_Click;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(486, 66);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "Precio total:";
            // 
            // ptotal
            // 
            ptotal.AccessibleRole = AccessibleRole.None;
            ptotal.AutoSize = true;
            ptotal.Location = new Point(496, 84);
            ptotal.Name = "ptotal";
            ptotal.Size = new Size(10, 15);
            ptotal.TabIndex = 7;
            ptotal.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(486, 165);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 8;
            label3.Text = "Precio final:";
            // 
            // pfinal
            // 
            pfinal.AccessibleRole = AccessibleRole.None;
            pfinal.AutoSize = true;
            pfinal.Location = new Point(496, 183);
            pfinal.Name = "pfinal";
            pfinal.Size = new Size(10, 15);
            pfinal.TabIndex = 9;
            pfinal.Text = " ";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "Cantidad no valida";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pfinal);
            Controls.Add(label3);
            Controls.Add(ptotal);
            Controls.Add(label1);
            Controls.Add(btnEnviar2);
            Controls.Add(textbox2);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox textbox2;
        private Button btnEnviar2;
        private Label label1;
        private Label ptotal;
        private Label label3;
        private Label pfinal;
        private NotifyIcon notifyIcon1;
    }
}