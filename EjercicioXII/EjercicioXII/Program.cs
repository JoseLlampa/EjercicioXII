using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXII
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1;
            DateTime fecha2;
            bool error = false;

            Console.WriteLine("Ingrese una fecha");
            
            do
            {
                error = false;
                if (!DateTime.TryParse((Console.ReadLine()), out fecha1))
                {
                    Console.WriteLine("No se ha ingresado una fecha");
                    error = true;
                }
            } while (error);

            Console.WriteLine("Ingrese una fecha para comparar");

            do
            {
                error = false;
                if (!DateTime.TryParse((Console.ReadLine()), out fecha2))
                {
                    Console.WriteLine("No se ha ingresado una fecha");
                    error = true;
                }
            } while (error);

            double totalDias = Math.Abs((fecha2 - fecha1).TotalDays);
            double año = Math.Floor(totalDias / 365);
            totalDias = totalDias - (año * 365);
            double mes= Math.Floor(totalDias / 30);
            totalDias = totalDias - (mes * 30);
            double dias = totalDias;

            Console.WriteLine("La diferencia es de " + año + " años, " + mes + " meses, " + dias + " dias.");
            Console.ReadKey();
        }
    }
}
