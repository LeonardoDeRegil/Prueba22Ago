using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba22Ago.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion() { }
        public List<int> GenerarValores(int n)
        { 
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaSalida.Add(5*(i+1));
            }

            return listaSalida;
        }

        public bool ChecarPrimo(int n)
        {
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<int> GeneradorCongruencial(int a, int c, int m, int x0)
        {
            List<int> listaSalida = new List<int>();
            bool entra = true;
            int xi = x0;
            while (entra)
            {
                xi = (a*xi + c) % m;
                if (!listaSalida.Contains(xi))
                {
                    listaSalida.Add((xi + 1) % m);
                }

                else
                {
                    entra = false;
                }
            }
            
            return listaSalida;
        }
    }
}
