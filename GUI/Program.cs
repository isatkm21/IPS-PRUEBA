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
            Console.WriteLine("Ingrese los datos de la liquidacion que desea registrar");
            Console.Write("Numero de la liquidación=> ");
            int numeroliquidacion = int.Parse(Console.ReadLine());

            Console.WriteLine("Identificación del paciente=> ");
            string idpaciente = Console.ReadLine();
            Console.Write("Tipo de afiliación (Contributivo o Subsidiado)=> ");
            string tipoafiliacion = Console.ReadLine();
            Console.Write("Salario devengado del paciente=> ");
            decimal salariodevengado = decimal.Parse(Console.ReadLine());
            Console.Write("Valor del servicio de hospitalización prestado=> ");
            decimal valorservicio = decimal.Parse(Console.ReadLine());

            Liquidacioncuotamoderadora liquidacion = new Liquidacioncuotamoderadora
            {
                Numeroliquidacion = numeroliquidacion,
                Idpaciente = idpaciente,
                Tipoafiliacion = tipoafiliacion,
                Salariodevengado = salariodevengado,
                Valorservicio = valorservicio
            };

            liquidacion.Calcularcuotamoderadora();
            LiquidacionCuotaModeradoraBLL(liquidacion);

            Console.WriteLine("La liquidación ha sido registrada correctamente");
        }

        static void Consultarliquidaciones()
        {
            List<Liquidacioncuotamoderadora> liquidaciones = LiquidacionCuotaModeradoraBLL.Consultarliquidaciones();
            Console.WriteLine("Listado de liquidaciones");
            foreach (var liquidacion in liquidaciones)
            {
                Console.WriteLine($"Numero de liquidación: {liquidacion.Numeroliquidacion}");
                Console.WriteLine($"Identificacion del paciente: {liquidacion.Idpaciente}");
                Console.WriteLine($"Tipo de afiliacion del paciente: {liquidacion.Tipoafiliacion}");
                Console.WriteLine($"Salario devengado del paciente: {liquidacion.Salariodevengado:C}");
                Console.WriteLine($"Valor dell servicio brindado: {liquidacion.Valorservicio:C}");
                Console.WriteLine($"Tarifa: {liquidacion.Tarifa:P}");
                Console.WriteLine($"Numero de liquidación: {liquidacion.ValorCuotaModeradora:C}");
                Console.WriteLine($"Numero de liquidación: {(liquidacion.AplicoTopeMaximo? "Si" :"No")}");
                Console.WriteLine($"Numero de liquidación: {liquidacion.ValorTopeMaximo:C}");
                Console.WriteLine();
            }
        }
     }
}
