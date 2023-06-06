namespace Ejercicio6
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
            caja = new TextBox();
            calcular = new Button();
            label1 = new Label();
            cds = new Label();
            SuspendLayout();
            // 
            // caja
            // 
            caja.Location = new Point(284, 211);
            caja.Name = "caja";
            caja.Size = new Size(232, 23);
            caja.TabIndex = 0;
            caja.TextChanged += caja_TextChanged;
            // 
            // calcular
            // 
            calcular.Location = new Point(351, 240);
            calcular.Name = "calcular";
            calcular.Size = new Size(91, 24);
            calcular.TabIndex = 1;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 180);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 2;
            label1.Text = "Expresar la capacidad del disco (en GB)";
            // 
            // cds
            // 
            cds.AutoSize = true;
            cds.Location = new Point(522, 211);
            cds.Name = "cds";
            cds.Size = new Size(10, 15);
            cds.TabIndex = 3;
            cds.Text = " ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cds);
            Controls.Add(label1);
            Controls.Add(calcular);
            Controls.Add(caja);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox caja;
        private Button calcular;
        private Label label1;
        private Label cds;
    }
}