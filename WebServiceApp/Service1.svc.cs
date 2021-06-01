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
                    Area = s.Area,
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
        public dynamic CreateTriangle(TriangleDTO Triangle)
        {
            try
            {
                double s = ((double)Triangle.SideA + (double)Triangle.SideB + (double)Triangle.SideC) / 2;
                Triangle.Area = Math.Sqrt(s*(s- (double)Triangle.SideA) * (s - (double)Triangle.SideB) * (s - (double)Triangle.SideC));
                var entity = new Triangle()
                {
                    Area = Triangle.Area,
                    SideA = Triangle.SideA,
                    SideB = Triangle.SideB,
                    SideC = Triangle.SideC
                };
                DBContext.Triangle.Add(entity);
                DBContext.SaveChangesAsync();
                return entity.Area;

            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public dynamic CreateSquare(SquareDTO Square)
        {
            try
            {
                Square.Area = Square.Width * Square.Height;
                var entity = new Square()
                {
                    Area = Square.Area,
                    Height = Square.Height,
                    Width = Square.Width
                };
                DBContext.Square.Add(entity);
                DBContext.SaveChangesAsync();
                return entity.Area;
                
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public dynamic CreateCircle(CircleDTO Circle)
        {
            try
            {
                Circle.Area = Math.PI * Math.Pow((double)Circle.Radius, 2);
                var entity = new Circle()
                {
                    Area = Circle.Area,
                    Radius = Circle.Radius
                };
                DBContext.Circle.Add(entity);
                DBContext.SaveChangesAsync();
                return entity.Area;
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public TriangleDTO GetTriangleById(int Id)
        {
            return DBContext.Triangle.Select(
                s => new TriangleDTO
                {
                    Id = s.Id,
                    SideA = s.SideA,
                    SideB = s.SideB,
                    SideC = s.SideC,
                    Area = s.Area
                }
            ).FirstOrDefault(s => s.Id == Id);
        }

        public SquareDTO GetSquareById(int Id)
        {
            return DBContext.Square.Select(
                s => new SquareDTO
                {
                    Id = s.Id,
                    Area = s.Area,
                    Height = s.Height,
                    Width = s.Width
                }
            ).FirstOrDefault(s => s.Id == Id);
        }

        public CircleDTO GetCircleById(int Id)
        {
            return DBContext.Circle.Select(
                s => new CircleDTO
                {
                    Id = s.Id,
                    Area = s.Area,
                    Radius = s.Radius
                }
                ).FirstOrDefault(s => s.Id == Id);
        }
    }
}
