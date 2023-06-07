namespace Ejercicio1
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
            numero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            romano = new Label();
            error = new Label();
            enviar = new Button();
            SuspendLayout();
            // 
            // numero
            // 
            numero.Location = new Point(364, 213);
            numero.Name = "numero";
            numero.Size = new Size(70, 23);
            numero.TabIndex = 0;
            numero.TextChanged += numero_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 195);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese un numero del 1 al 10:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 285);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 2;
            label2.Text = "Equivalente en número romano:\r\n";
            // 
            // romano
            // 
            romano.AutoSize = true;
            romano.Location = new Point(391, 319);
            romano.Name = "romano";
            romano.Size = new Size(10, 15);
            romano.TabIndex = 3;
            romano.Text = " ";
            // 
            // error
            // 
            error.AutoSize = true;
            error.Location = new Point(192, 148);
            error.Name = "error";
            error.Size = new Size(10, 15);
            error.TabIndex = 4;
            error.Text = " ";
            // 
            // enviar
            // 
            enviar.Location = new Point(360, 242);
            enviar.Name = "enviar";
            enviar.Size = new Size(75, 23);
            enviar.TabIndex = 5;
            enviar.Text = "Enviar";
            enviar.UseVisualStyleBackColor = true;
            enviar.Click += enviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(enviar);
            Controls.Add(error);
            Controls.Add(romano);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numero;
        private Label label1;
        private Label label2;
        private Label romano;
        private Label error;
        private Button enviar;
    }
}