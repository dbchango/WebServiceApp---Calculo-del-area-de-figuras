using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp.DTO
{
    public class TriangleDTO
    {
        public int Id { get; set; }
        public double? Area { get; set; }
        public double? SideA { get; set; }
        public double? SideB { get; set; }
        public double? SideC { get; set; }
    }
}