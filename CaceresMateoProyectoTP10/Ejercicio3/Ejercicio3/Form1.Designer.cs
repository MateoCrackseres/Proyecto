namespace Ejercicio3
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
            numero1 = new TextBox();
            enviar = new Button();
            numero2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            resultado2 = new Label();
            resultado1 = new Label();
            SuspendLayout();
            // 
            // numero1
            // 
            numero1.Location = new Point(254, 251);
            numero1.Name = "numero1";
            numero1.Size = new Size(100, 23);
            numero1.TabIndex = 0;
            // 
            // enviar
            // 
            enviar.Location = new Point(359, 286);
            enviar.Name = "enviar";
            enviar.Size = new Size(82, 23);
            enviar.TabIndex = 1;
            enviar.Text = "Enviar";
            enviar.UseVisualStyleBackColor = true;
            enviar.Click += enviar_Click;
            // 
            // numero2
            // 
            numero2.Location = new Point(441, 251);
            numero2.Name = "numero2";
            numero2.Size = new Size(100, 23);
            numero2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 233);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Valor a";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 233);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 80);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "Resultado (a+b)*(a-b)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 80);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 6;
            label4.Text = "Resultado a^2 - b^2";
            // 
            // resultado2
            // 
            resultado2.AutoSize = true;
            resultado2.Location = new Point(445, 107);
            resultado2.Name = "resultado2";
            resultado2.Size = new Size(84, 15);
            resultado2.TabIndex = 7;
            resultado2.Text = "###########";
            // 
            // resultado1
            // 
            resultado1.AutoSize = true;
            resultado1.Location = new Point(260, 107);
            resultado1.Name = "resultado1";
            resultado1.Size = new Size(84, 15);
            resultado1.TabIndex = 8;
            resultado1.Text = "###########";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado1);
            Controls.Add(resultado2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numero2);
            Controls.Add(enviar);
            Controls.Add(numero1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numero1;
        private Button enviar;
        private TextBox numero2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label resultado2;
        private Label resultado1;
    }
}