using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp.DTO
{
    public class SquareDTO
    {
        public int Id { get; set; }
        public double? Area { get; set; }
        public double? Side { get; set; }
        public double? Perimeter { get; set; }
    }
}