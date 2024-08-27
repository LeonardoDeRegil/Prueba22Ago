namespace Prueba22Ago
{
    partial class FormProductoMedio
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
            btnEjecutar = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(37, 155);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor Inicial n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(181, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(591, 278);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(697, 361);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Descarga";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 9;
            label2.Text = "Segundo valor n+1";
            label2.Click += label2_Click_1;
            // 
            // FormProductoMedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnEjecutar);
            Name = "FormProductoMedio";
            Text = "ProductoMedio";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjecutar;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
    }
}
