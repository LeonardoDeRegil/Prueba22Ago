namespace Prueba22Ago
{
    partial class Menu
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
            btnCongruencial = new Button();
            btnCuadradoMedio = new Button();
            btnProductoMedio = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCongruencial
            // 
            btnCongruencial.Location = new Point(296, 168);
            btnCongruencial.Name = "btnCongruencial";
            btnCongruencial.Size = new Size(183, 23);
            btnCongruencial.TabIndex = 0;
            btnCongruencial.Text = "Algoritmo Congruencial";
            btnCongruencial.UseVisualStyleBackColor = true;
            btnCongruencial.Click += btnCongruencial_Click;
            // 
            // btnCuadradoMedio
            // 
            btnCuadradoMedio.Location = new Point(296, 209);
            btnCuadradoMedio.Name = "btnCuadradoMedio";
            btnCuadradoMedio.Size = new Size(183, 23);
            btnCuadradoMedio.TabIndex = 1;
            btnCuadradoMedio.Text = "Algoritmo Cuadrado Medio";
            btnCuadradoMedio.UseVisualStyleBackColor = true;
            btnCuadradoMedio.Click += btnCuadradoMedio_Click;
            // 
            // btnProductoMedio
            // 
            btnProductoMedio.Location = new Point(296, 248);
            btnProductoMedio.Name = "btnProductoMedio";
            btnProductoMedio.Size = new Size(183, 23);
            btnProductoMedio.TabIndex = 2;
            btnProductoMedio.Text = "Algoritmo Producto Medio";
            btnProductoMedio.UseVisualStyleBackColor = true;
            btnProductoMedio.Click += btnProductoMedio_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 79);
            label1.Name = "label1";
            label1.Size = new Size(506, 32);
            label1.TabIndex = 3;
            label1.Text = "Generadores de números pseudoaleatorios";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnProductoMedio);
            Controls.Add(btnCuadradoMedio);
            Controls.Add(btnCongruencial);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCongruencial;
        private Button btnCuadradoMedio;
        private Button btnProductoMedio;
        private Label label1;
    }
}