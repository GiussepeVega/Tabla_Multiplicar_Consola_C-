using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // preguntamos al usuario que ingrese un nro de la tabla a consultar
                Console.WriteLine("Ingrese un número: ");
                String getNumero = Console.ReadLine();
                // convertimos el numero ingresado de tipo int
                int numeroInt = Convert.ToInt32(getNumero);

                // creamos variables adicionales para que halla un acumulador por cada tabla y otro
                // acumulador para la suma en general
                int acumuladorXTabla = 0;
                int acumuladorGeneral = 0;

                // agregamos un bucle para la tabla 
                for (int i = 0; i <= numeroInt; i++) 
                {
                    // dentro de el, agregamos otro bucle, este sera el encargado de multiplicar
                    // el nro ingresado hasta el nro 12
                    for (int j = 0; j <= 12; j++)
                    {
                        int resultado = i * j;
                        // acumula por cada tabla que pase
                        acumuladorXTabla+= resultado;
                        // acumula la suma en general
                        acumuladorGeneral+= resultado;
                        Console.WriteLine("{0} x {1} = {2}", i, j, resultado);
                    }
                    Console.WriteLine("----------------");
                    Console.WriteLine("Suma total: {0}", acumuladorXTabla);
                    // reiniciamos el acumulador por tabla para que sume la siguiente tabla desde 0
                    acumuladorXTabla = 0;
                    Console.WriteLine("");
                }
                // imprimimos la suma general de todas las tablas

                // el acumulador en general obtendra el resultado despues de pasar y terminar todo el bucle,
                // por eso no se reinicia y se mantiene.
                Console.WriteLine("====================");
                Console.WriteLine("Suma total acumulada: {0}", acumuladorGeneral);
            }
            catch (Exception e) 
            {
                Console.WriteLine("Ingrese un valor numerico.");
            }

        }
    }
}
