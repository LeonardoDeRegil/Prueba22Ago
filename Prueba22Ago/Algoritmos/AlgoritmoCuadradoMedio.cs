using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba22Ago.Algoritmos
{
    public class AlgoritmoCuadradoMedio
    {
        public int ObtieneMRn2(int a)
        {
            string s = a.ToString();
            int longitud = s.Length;
            string cadenaMRn2 = "";

            for (int i = 1; i < longitud - 1; i++)
            {
                cadenaMRn2 = cadenaMRn2 + s[i];
            }

            int MRn2 = Int32.Parse(cadenaMRn2);

            return MRn2;
        }


        public List<int> ObtieneVal1y2(int a)
        {
            List<int> listaSalida = new List<int>();

            if (a == 0)
            {
                listaSalida.Add(0);
                listaSalida.Add(0);

                return listaSalida;
            }

            string s = a.ToString();
            int longitud = s.Length;

            if (longitud == 3)
            {
                listaSalida.Add(a);
                listaSalida.Add(0);
            }

            else
            {
                string cadenaV1 = "";
                string cadenaV2 = "";

                for (int i = 0; i < longitud - 1; i++)
                {
                    cadenaV1 += s[i];
                }

                for (int i = 1; i < longitud; i++)
                {
                    cadenaV2 += s[i];
                }

                int v1 = Int32.Parse(cadenaV1);
                int v2 = Int32.Parse(cadenaV2);

                listaSalida.Add(v1);
                listaSalida.Add(v2);
            }

            return listaSalida;
        }

        public List<int> GeneradorCuadradoMedio(int inputN)
        {
            List<int> listaSalida = new List<int>();
            bool continua = true;
            int n = 0;
            int Rn = inputN;
            while (continua)
            {
                int Rn2 = (int)Math.Pow(Rn, 2);
                int MRn2 = ObtieneMRn2(Rn2);

                List<int> val1y2 = ObtieneVal1y2(MRn2);

                int val1 = val1y2[0];

                listaSalida.Add(val1);

                continua = val1 != 0;

                n = +1;

                Rn = val1;
            }

            return listaSalida;
        }
    }
}
