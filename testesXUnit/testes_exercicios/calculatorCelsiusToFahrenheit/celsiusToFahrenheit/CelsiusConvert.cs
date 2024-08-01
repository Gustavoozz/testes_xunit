using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celsiusToFahrenheit
{
    public static class CelsiusConvert
    {
        public static double Calculate(double g)
        {
            return (g * 1.8 + 32);
        }
    }
}
