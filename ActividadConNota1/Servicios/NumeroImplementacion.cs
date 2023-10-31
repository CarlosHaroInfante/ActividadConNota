using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadConNota1.Servicios
{
    internal class NumeroImplementacion : NumeroInterfaz
    {
        public int Mes()
        {
            {
                int numero;
                Console.WriteLine("Dame el número de un mes: ");
                numero = Convert.ToInt32(Console.ReadLine());
                return numero;
            }
        
        }

        public int año()
        {
            int numeroDia;
            Console.WriteLine("Dame el año: ");
            numeroDia = Convert.ToInt32(Console.ReadLine());
            return numeroDia;
        }
        

        
    }
}
