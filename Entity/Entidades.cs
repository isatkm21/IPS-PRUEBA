using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Class1
    {
        public int NumeroLiquidacion { get; set; }
        public string IdentificacionPaciente { get; set; }
        public string TipoAfiliacion { get; set; }
        public decimal SalarioDevengado { get; set; }
        public decimal ValorServicio { get; set; }
        public decimal Tarifa { get; set; }
        public decimal ValorCuotaModeradora { get; set; }
        public bool AplicoTopeMaximo { get; set; }
        public decimal ValorTopeMaximo { get; set; }
        public DateTime Fechaliquidacion { get; set; } //Fecha de liquidacion
    }

    //Se agrega el metodo calcularcuotamoderadora que realiza los calculor segun las reglas
    //mencionadas.Se ha movido aqui para que sea parte de la entidad.
    public void Calcularcuotamoderadora()
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
       else if (tipoAfiliacion == "Subsidiado")
        {
            tarifa = 0.05;
            topeMAx = 200000;
        }
        else
        {
            Console.WriteLine("Tipo de afiliación invalida");
        }

        cuotaModeradora = valorServicio * tarifa;

        if (cuotaModeradora > topeMAx)
        {
            cuotaModeradora = topeMAx;
            AplicoTopeMaximo = true;
        }
        else
        {
            AplicoTopeMaximo = false;
        }
    }
}