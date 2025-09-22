using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monto.Dao
{
    public static class Calculo
    {
        /// <summary>
        /// Calcular monto por paso de valor
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static double CalcularMonto(Double precio)
        {
            precio *= 1.15;
            return precio;
        }

        /// <summary>
        /// Calcular monto por paso de referencia
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static double CalcularMonto(ref Double precio)
        {
            precio *= 1.15;
            return precio;
        }
    }
}
