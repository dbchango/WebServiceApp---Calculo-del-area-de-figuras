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
                    Side = s.Side
                }
            ).ToList();
        }

        public List<RingDTO> ListRings()
        {
            return DBContext.Ring.Select(
                s => new RingDTO
                {
                    Id = s.Id,
                    Radius = s.Radius,
                    Area = s.Area
                }
            ).ToList();
        }

        public List<RectangleDTO> ListRectangles()
        {
            return DBContext.Rectangle.Select(
                s => new RectangleDTO
                {
                    Id = s.Id,
                    Height = s.Height,
                    Width = s.Width,
                    Area = s.Area
                }
            ).ToList();
        }

        // Creacion
        public Triangle CreateTriangle(TriangleDTO Triangle)
        {
            double s = ((double)Triangle.SideA + (double)Triangle.SideB + (double)Triangle.SideC) / 2;
            Triangle.Area = Math.Sqrt(s * (s - (double)Triangle.SideA) * (s - (double)Triangle.SideB) * (s - (double)Triangle.SideC));
            Triangle.Perimeter = Triangle.SideA + Triangle.SideB + Triangle.SideC;
            var entity = new Triangle()
            {
                Area = Triangle.Area,
                SideA = Triangle.SideA,
                SideB = Triangle.SideB,
                SideC = Triangle.SideC,
                Perimeter = Triangle.Perimeter
            };
            DBContext.Triangle.Add(entity);
            DBContext.SaveChangesAsync();
            return entity;
        }

        public Square CreateSquare(SquareDTO Square)
        {
            Square.Area = Square.Side * Square.Side;
            Square.Perimeter = 4 * Square.Side;
            var entity = new Square()
            {
                Area = Square.Area,
                Side = Square.Side,
                Perimeter = Square.Perimeter
            };
            DBContext.Square.Add(entity);
            DBContext.SaveChangesAsync();
            return entity;
        }

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
        public Rectangle CreateRectangle(RectangleDTO Rectangle)
        {
            Rectangle.Area = Rectangle.Height * Rectangle.Width;
            Rectangle.Perimeter = 2 * Rectangle.Height + 2 * Rectangle.Width;
            var entity = new Rectangle()
            {
                Area = Rectangle.Area,
                Height = Rectangle.Height,
                Width = Rectangle.Width,
                Perimeter = Rectangle.Perimeter
            };
            DBContext.Rectangle.Add(entity);
            DBContext.SaveChangesAsync();
            return entity;
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
                    Side = s.Side
                }
            ).FirstOrDefault(s => s.Id == Id);
        }

        public RingDTO GetRingById(int Id)
        {
            return DBContext.Ring.Select(
                s => new RingDTO
                {
                    Id = s.Id,
                    Area = s.Area,
                    Radius = s.Radius
                }
                ).FirstOrDefault(s => s.Id == Id);
        }

        public RectangleDTO GetRectangleById(int Id)
        {
            return DBContext.Rectangle.Select(
                s => new RectangleDTO
                {
                    Id = s.Id,
                    Area = s.Area,
                    Height = s.Height,
                    Width = s.Width
                }
                ).FirstOrDefault(s => s.Id == Id);
        }
    }
}
