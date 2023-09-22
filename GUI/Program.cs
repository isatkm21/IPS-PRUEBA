using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
     class Program
    {
        static LiquidacionCuotaModeradoraBLL liquidacion = new LiquidacionCuotaModeradoraBLL();

        static void Main(string[] args)
        {
            bool seguir = true;
            while (seguir) 
            {
                Console.WriteLine("+++++++Menú+++++++++");
                Console.WriteLine("¨1- Registrar liquidación");
                Console.WriteLine("2-  Consultar liquidaciones");
                Console.WriteLine("3-  Actualizar valor del servicio");
                Console.WriteLine("4-  Eliminar liquidación");
                Console.WriteLine("5-  Consultar liquidaciones por mes y año");
                Console.WriteLine("6-  Salir");
                Console.WriteLine("\n");
                Console.WriteLine("Selecciones una opción por favor");

                if (int.TryParse(Console.ReadLine().out int opcion))
                {
                    switch(opcion) 
                    {
                        case 1:
                            Registrarliquidación();
                            break;
                        case 2:
                            Consultarliquidaciones();
                            break;
                        case 3:
                            Actualizarvalorservicio();
                            break;
                        case 4:
                            ELiminarliquidacion();
                            break;
                        case 5:
                            Consultarliquidacionespormesyaño();
                            break;
                        case 6:
                            seguir= false;
                            break;
                        default:
                            Console.WriteLine("Error...OPCION INVAlIDA");
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Entrada no válida, ingrese un numero que esté en el menú");
                }
                Console.WriteLine();
            }

        }
        static void Registrarliquidacion()
        {

        }
     }
}
