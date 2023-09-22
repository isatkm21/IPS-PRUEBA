using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos

{
    public class Class1
    {
        public class Liquidacionescuotamoderadora
        {
            public void insertarLiquidacion(Liquidacioncuotamoderadora liquidacion)
            {
                using (var context = new MyDbContext())
                {
                    context.Liquidacionescuotamoderadora.add(liquidacion);
                    context.SaveChanges();
                }
            }
            public Liquidacioncuotamoderadora obtenerliquidacionpornumero(int numeroliquidacion)
            {
                using(var context = new MyDbContext())
                {
                    return context.Liquidacioesncuotamoderadora.FirsOrDefault(1=> 1.Numero liquidacion == numeroliquidacion);

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
            public List<Liquidacioncuotamoderadora>consultarliquidaciones()
            {
                using(var context = new MyDbContext())
                {
                    return context.Liquidacionescuotamoderadora.ToList();
                }
            }
            public void ELiminarliquidacion(int numeroliquidacion)
            {
                using(var context = new MyDbContext())
                {
                    var liquidacion = context.Liquidacionescuotamoderadora.FirstOrDefault(1 => 1.Numero liquidacion == numeroliquidacion);
                    if (liquidacion == null)
                    {
                        context.Liquidacionescuotamoderadora.Remove(liquidacion);
                        context.SaveChanges(); //guarda los cambios en la base de datos 
                    }
                }
            }
            public List<Liquidacionescuotamoderadora> consultarliquidacionesporMESYAÑO(int MES, int AÑO)
            {
                using (var context = new MyDbContext())
                {
                    return context.Liquidacionescuotamoderadora
                        .Where(1 => FechaLiquidacion.Mes == MES && 1.FechaLiquidacion.Año == AÑO);
                        .ToList();
                }
            }


        }
        
    }
}
