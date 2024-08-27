using Prueba22Ago.Algoritmos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prueba22Ago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condición de Vacío
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Los números semilla no pueden estar vacíos");
                return;
            }

            // Paso 1: Inicialización de parámetros
            int x0 = Convert.ToInt32(textBox1.Text);
            int x1 = Convert.ToInt32(textBox2.Text);

            // Paso 1.2: Condiciones
            if (x0 <= 0 || x1 <= 0)
            {
                MessageBox.Show("Valores de x0 y x1 tienen que ser mayores que cero");
                return;
            }

            // Paso 2: Declarar clase algoritmo
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();

            // Paso 3: Llamar método principal
            List<int> listaEnteros = algoritmo.GeneradorProductoMedio(100, x0, x1); // Aquí se genera una lista de 100 números

            // Paso 4: Llenar el grid
            llenarGrid(listaEnteros);
        }

        public void llenarGrid(List<int> lista)
        {
            // Paso 0: Indicar el número de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            // Paso 1: Determinar la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            // Paso 2: Recorrer el grid para cada fila y llenar los valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }
        }

        public void DescargaExcel(DataGridView data)
        {
            // Paso 0: Instalar completamente de Excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            // Paso 1: Construir columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }

            // Paso 2: Construir filas y llenar valores
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }

            // Paso 3: Visibilidad
            exportarExcel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
