using System;
using System.Collections.Generic;

namespace Prueba22Ago.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion() { }

        // Método de Producto Medio
        public List<int> GeneradorProductoMedio(int n, int x0, int x1)
        {
            List<int> listaSalida = new List<int>();
            int xi = x0;
            int xiPlus1 = x1;
            for (int i = 0; i < n; i++)
            {
                int producto = xi * xiPlus1;
                string productoStr = producto.ToString("D8"); // Convertir a string con 8 dígitos (relleno con ceros si es necesario)
                string medio = productoStr.Substring(2, 4);   // Extraer los dígitos del medio
                int nuevoNumero = int.Parse(medio);           // Convertir de vuelta a entero

                listaSalida.Add(nuevoNumero);

                // Actualizar semillas para la próxima iteración
                xi = xiPlus1;
                xiPlus1 = nuevoNumero;
            }

            return listaSalida;
        }
    }
}
