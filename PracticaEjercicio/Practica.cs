using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEjercicio
{
    public class Practica
    {
        public static void SortedListCollection()
        {
			//Calcular el factorial de un numero
			//(n!=1x2x3x4....xn)

			byte num, i;
			long result = 1;
			string linea;
			Console.Write("Digite un numero : "); 
			linea = Console.ReadLine();
			num = byte.Parse(linea);
			for (i = 2; i <= num; i++)
			{
				result = result * i;
			}
			Console.WriteLine("El factorial de {0} es {1}", num, result);

			Console.Write("Pulse una Tecla ");
			Console.ReadLine();

		}
    }
}
