using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp.DTO
{
    public class RectangleDTO
    {
        public int Id { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Area { get; set; }
        public double? Perimeter { get; set; }
    }
}