using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica

{
    public class Class1
    {
        // LiquidacionCuotaModeradoraBLL.cs
        public class LiquidacionCuotaModeradoraBLL
        {
            public decimal CalcularCuotaModeradora(
                string tipoAfiliacion,
                decimal salarioDevengado,
                decimal valorServicio)
            {
                decimal tarifa = 0;
                decimal topeMAx = 0;

                if (tipoAfiliacion == "Contributivo")
                {
                    if (salarioDevengado < 2)
                    {
                        tarifa = 0.15;
                        topeMAx = 250000;
                    }
                    else if (salarioDevengado >= 2 && salarioDevengado <= 5)
                    {
                        tarifa = 0.20;
                        topeMAx = 900000;
                    }
                    else
                    {
                        tarifa = 0.25;
                        topeMAx = 1500000;

                    }
                }
                if(tipoAfiliacion == "Subsidiado")
                {
                    tarifa = 0.05;
                    topeMAx = 200000;
                }
                else
                {
                    Console.WriteLine("Tipo de afiliación invalida");
                }

                decimal cuotaModeradora = valorServicio * tarifa;

                if(cuotaModeradora > topeMAx)
                {
                    cuotaModeradora = topeMAx;
                }
                return cuotaModeradora;
               // Lógica para calcular la cuota moderadora según las reglas.
            }

            public void ActualizarValorServicio(int numeroLiquidacion, decimal nuevoValorServicio)
            {
                // Lógica para actualizar el valor del servicio y recalcular la cuota moderadora.
            }

            public List<LiquidacionCuotaModeradora> ConsultarLiquidaciones()
            {
                // Lógica para consultar todas las liquidaciones.
            }

            // Otros métodos para realizar consultas y operaciones específicas.
        }

    }
}
