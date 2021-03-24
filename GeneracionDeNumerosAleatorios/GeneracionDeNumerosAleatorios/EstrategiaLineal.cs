using System;
using System.Collections.Generic;
using System.Text;

namespace GeneracionDeNumerosAleatorios
{
    class EstrategiaLineal : IEstrategiaNumAleatorio
    {


        public bool sonPrimos(int a, int b)
        {
            int mayor = Math.Max(a, b);
            int menor = Math.Min(a, b);
            int res;
            do
            {
                res = menor;
                menor = mayor % menor;
                mayor = res;
            } while (menor != 0);

            if (res == 1)
                return true;

            return false;
        }
    }
}
