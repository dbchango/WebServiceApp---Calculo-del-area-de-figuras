using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceApp.DTO;
using WebServiceApp.Models;

namespace WebServiceApp
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        private readonly areasContext DBContext = new areasContext();
        // Listados implementacion
  

        public List<RingDTO> ListRings()
        {
            return DBContext.Ring.Select(
                s => new RingDTO
                {
                    Id = s.Id,
                    Radius = s.Radius,
                    Perimeter = s.Perimeter,
                    Area = s.Area
                }
            ).ToList();
        }


        // Creacion

        public Ring CreateRing(RingDTO Ring)
        {
            Ring.Area = Math.PI * Ring.Radius * Ring.Radius;
            Ring.Perimeter = 2 * Math.PI * Ring.Radius;
            var entity = new Ring()
            {
                Area = Ring.Area,
                Radius = Ring.Radius,
                Perimeter = Ring.Perimeter
            };
            DBContext.Ring.Add(entity);
            DBContext.SaveChangesAsync();
            return entity;
        }
       

  
  
        public RingDTO GetRingById(int Id)
        {
            return DBContext.Ring.Select(
                s => new RingDTO
                {
                    Id = s.Id,
                    Area = s.Area,
                    Radius = s.Radius,
                    Perimeter = s.Perimeter
                }
                ).FirstOrDefault(s => s.Id == Id);
        }

   
    }
}
