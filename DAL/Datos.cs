using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos

{
    public class Class1
    {
        public class Liquidacioncuotamoderadora
        {
            public void insertarLiquidacion(Liquidacioncuotamoderadora liquidacion)
            {
                using (var context = new MyDbContext())
                {
                    context.Liquidacioncuotamoderadora.add(liquidacion);
                    context.SaveChanges();
                }
            }
            public Liquidacioncuotamoderadora obtenerliquidacionpornumero(int numeroliquidacion)
            {
                using(var context = new MyDbContext())
                {
                    return context.Liquidacioncuotamoderadora.FirsOrDefault(1=> 1.Numero liquidacion == numeroliquidacion);

                }

            }
            public void Actualizarliquidacion(Liquidacioncuotamoderadora liquidacion)
            {
                using (var context = new MyDbcontext())
                {
                    // Marca la liquidación como modificada para que Entidades Framework realice una actualización
                    context.Entry(liquidacion).State = EntidadesState.Modified;
                    context.SaveChanges();
                }
            }
                


        }
        
    }
}
