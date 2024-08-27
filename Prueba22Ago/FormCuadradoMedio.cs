using Prueba22Ago.Algoritmos;

namespace Prueba22Ago
{
    public partial class FormCuadradoMedio : Form
    {
        public FormCuadradoMedio()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            // Paso 0: Condici�n de Vac�o
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Los n�meros tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            // Paso 1: Inicializaci�n de par�metros
            int n = Convert.ToInt32(textBox1.Text);

            //Paso 1.2: Condiciones
            if (n <= 99 || n > 999)
            {
                MessageBox.Show("El valor de n tiene que ser de TRES digitos.");
                return;
            }

            // Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoCuadradoMedio algoritmo = new AlgoritmoCuadradoMedio();

            // Paso 3: Llamar m�todo principal
            List<int> listaEnteros = algoritmo.GeneradorCuadradoMedio(n);

            // Paso 4: Llenar el grid
            llenarGrid(listaEnteros);

        }

        public void llenarGrid(List<int> lista)
        {
            // Paso 0: Indicas el n�mero de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            // Paso 1: Determinas la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            // Paso 2: Recorres el grid para cada fila llenas los valores aleatorios
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

            // Paso 1: Construyes columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }

            // Paso 2: Construyes filas y llenas valores
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
