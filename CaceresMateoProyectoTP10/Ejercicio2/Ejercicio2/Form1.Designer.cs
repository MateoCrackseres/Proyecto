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
            numero2 = new TextBox();
            numero1 = new TextBox();
            Enviar = new Button();
            label1 = new Label();
            suma = new Label();
            label2 = new Label();
            label3 = new Label();
            resta = new Label();
            mult = new Label();
            division = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // numero2
            // 
            numero2.Location = new Point(269, 276);
            numero2.Name = "numero2";
            numero2.Size = new Size(247, 23);
            numero2.TabIndex = 0;
            numero2.TextChanged += numero2_TextChanged;
            // 
            // numero1
            // 
            numero1.Location = new Point(269, 247);
            numero1.Name = "numero1";
            numero1.Size = new Size(247, 23);
            numero1.TabIndex = 1;
            numero1.TextChanged += numero1_TextChanged;
            // 
            // Enviar
            // 
            Enviar.Location = new Point(353, 327);
            Enviar.Name = "Enviar";
            Enviar.Size = new Size(75, 23);
            Enviar.TabIndex = 2;
            Enviar.Text = "Enviar";
            Enviar.UseVisualStyleBackColor = true;
            Enviar.Click += Enviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 68);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Resultado";
            // 
            // suma
            // 
            suma.AutoSize = true;
            suma.Location = new Point(141, 122);
            suma.Name = "suma";
            suma.Size = new Size(70, 15);
            suma.TabIndex = 4;
            suma.Text = "#########";
            suma.Click += resultado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 247);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Numero 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 279);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Numero 2:";
            // 
            // resta
            // 
            resta.AutoSize = true;
            resta.Location = new Point(287, 122);
            resta.Name = "resta";
            resta.Size = new Size(70, 15);
            resta.TabIndex = 7;
            resta.Text = "#########";
            // 
            // mult
            // 
            mult.AutoSize = true;
            mult.Location = new Point(427, 122);
            mult.Name = "mult";
            mult.Size = new Size(70, 15);
            mult.TabIndex = 8;
            mult.Text = "#########";
            // 
            // division
            // 
            division.AutoSize = true;
            division.Location = new Point(568, 122);
            division.Name = "division";
            division.Size = new Size(70, 15);
            division.TabIndex = 9;
            division.Text = "#########";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 98);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 10;
            label7.Text = "Suma:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(427, 98);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 11;
            label8.Text = "Multiplicacion:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(287, 98);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 12;
            label9.Text = "Resta:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(568, 98);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 13;
            label10.Text = "Division:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(division);
            Controls.Add(mult);
            Controls.Add(resta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(suma);
            Controls.Add(label1);
            Controls.Add(Enviar);
            Controls.Add(numero1);
            Controls.Add(numero2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numero2;
        private TextBox numero1;
        private Button Enviar;
        private Label label1;
        private Label suma;
        private Label label2;
        private Label label3;
        private Label resta;
        private Label mult;
        private Label division;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}