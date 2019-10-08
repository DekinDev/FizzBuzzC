using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzEZ
{
    class NumberControl
    {
        public String FizzBuzz(string i)
        {
            Logs oLog = new Logs(Application.StartupPath + @"\Logs");
            Logs oLog2 = new Logs(Application.StartupPath + @"\Logs");

            oLog2.Add2("DEBUG: Inicio Funcion: NumberControl");

            int z = Convert.ToInt32(i);

            if (z % 3 == 0 || z % 5 == 0)
            {
                if (z % 3 != 0)
                {
                    oLog.Add(i + " / Buzz");
                    oLog2.Add2("DEBUG: Fin Funcion: NumberControl");
                    return "Buzz";
                }
                else if (z % 5 != 0)
                {
                    oLog.Add(i + " / Fizz");
                    oLog2.Add2("DEBUG: Fin Funcion: NumberControl");
                    return "Fizz";
                }
                else
                {
                    oLog.Add(i + " / FizzBuzz");
                    oLog2.Add2("DEBUG: Fin Funcion: NumberControl");
                    return "FizzBuzz";
                }
            }
            else
            {
                oLog.Add(i);
                oLog2.Add2("DEBUG: Fin Funcion: NumberControl");
                return null;
            }
        }
    }
}
