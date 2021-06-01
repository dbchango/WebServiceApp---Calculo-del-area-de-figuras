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
        private readonly figuresContext DBContext = new figuresContext();
        // Listados implementacion
        public List<TriangleDTO> ListTriangles()
        {
            return DBContext.Triangle.Select(
                s => new TriangleDTO
                {
                    Id = s.Id,
                    Area = s.Area,
                    SideA = s.SideA,
                    SideB = s.SideB,
                    SideC = s.SideC
                }
            ).ToList();
        }

        public List<SquareDTO> ListSquares()
        {
            return DBContext.Square.Select(
                s => new SquareDTO
                {
                    Id = s.Id,
                    Base = s.Base,
                    Width = s.Width,
                    Height = s.Height
                }
            ).ToList();
        }

        public List<CircleDTO> ListCircles()
        {
            return DBContext.Circle.Select(
                s => new CircleDTO
                {
                    Id = s.Id,
                    Radius = s.Radius,
                    Area = s.Area
                }
            ).ToList();
        }

        // Creacion
        public bool CreateTriangle(TriangleDTO Triangle)
        {
            try
            {
                var entity = new Triangle()
                {
                    Area = Triangle.Area,
                    SideA = Triangle.SideA,
                    SideB = Triangle.SideB,
                    SideC = Triangle.SideC
                };
                DBContext.Triangle.Add(entity);
                DBContext.SaveChangesAsync();
                return true;

            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool CreateSquare(SquareDTO Square)
        {
            try
            {
                var entity = new Square()
                {
                    Base = Square.Base,
                    Height = Square.Height,
                    Width = Square.Width
                };
                DBContext.Square.Add(entity);
                DBContext.SaveChangesAsync();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool CreateCircle(CircleDTO Circle)
        {
            try
            {
                var entity = new Circle()
                {
                    Area = Circle.Area,
                    Radius = Circle.Radius
                };
                DBContext.Circle.Add(entity);
                DBContext.SaveChangesAsync();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
