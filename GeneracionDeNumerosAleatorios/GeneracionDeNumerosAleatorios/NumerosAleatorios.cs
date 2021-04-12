using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;

namespace GeneracionDeNumerosAleatorios
{
    class NumerosAleatorios
    {
        private IList<double> numeros = new List<double>();

        public NumerosAleatorios(IList<double> num)
        {
            numeros = num;
        }
    }

    
   
}
