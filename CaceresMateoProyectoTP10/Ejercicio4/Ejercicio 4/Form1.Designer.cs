namespace Ejercicio_4
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
            label1 = new Label();
            letra = new TextBox();
            verif = new Button();
            label2 = new Label();
            vocal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 112);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese una letra";
            // 
            // letra
            // 
            letra.Location = new Point(376, 143);
            letra.Name = "letra";
            letra.Size = new Size(59, 23);
            letra.TabIndex = 1;
            // 
            // verif
            // 
            verif.Location = new Point(360, 185);
            verif.Name = "verif";
            verif.Size = new Size(94, 23);
            verif.TabIndex = 2;
            verif.Text = "Verificar";
            verif.UseVisualStyleBackColor = true;
            verif.Click += verif_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 250);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // vocal
            // 
            vocal.AutoSize = true;
            vocal.Location = new Point(360, 250);
            vocal.Name = "vocal";
            vocal.Size = new Size(10, 15);
            vocal.TabIndex = 4;
            vocal.Text = " ";
            vocal.Click += vocal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vocal);
            Controls.Add(label2);
            Controls.Add(verif);
            Controls.Add(letra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox letra;
        private Button verif;
        private Label label2;
        private Label vocal;
    }
}